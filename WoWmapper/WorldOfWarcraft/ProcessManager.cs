﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ThreadState = System.Threading.ThreadState;

namespace WoWmapper.WorldOfWarcraft
{
    internal static class ProcessManager
    {
        #region Natives
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetWindowRect(HandleRef hWnd, out RECT lpRect);

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;        // x position of upper-left corner
            public int Top;         // y position of upper-left corner
            public int Right;       // x position of lower-right corner
            public int Bottom;      // y position of lower-right corner
        }
        #endregion

        private static readonly string[] WoWProcessNames = new[] { "wow", "wow-64", "wowt", "wowt-64", "wowb", "wowb-64"};
        private static bool _threadRunning = false;
        private static readonly Thread ProcessThread = new Thread(ProcessThreadMethod);

        public static Process GameProcess { get; private set; }
        public static bool GameRunning => GameProcess != null;

        public static Rectangle GetWindowRectangle()
        {
            var windowRect = new RECT();
            GetWindowRect(new HandleRef(null, GameProcess.MainWindowHandle), out windowRect);

            var outRectangle = new Rectangle(windowRect.Left, windowRect.Top, windowRect.Right-windowRect.Left, windowRect.Bottom-windowRect.Top);
            return outRectangle;
        }

        private static void ProcessThreadMethod()
        {
            // Process watcher thread
            while (ProcessThread.ThreadState == ThreadState.Running)
            {
                if (GameProcess != null)
                {
                    // Attach/detach memory reader as necessary
                    if (Properties.Settings.Default.EnableMemoryReading && !MemoryManager.IsAttached)
                        MemoryManager.Attach(GameProcess);

                    if (!Properties.Settings.Default.EnableMemoryReading && MemoryManager.IsAttached)
                        MemoryManager.Detach();

                    // Test process validity
                    if (GameProcess.HasExited)
                    {
                        Log.WriteLine($"Process invalidated: [{GameProcess.Id}] {GameProcess.ProcessName} ");
                        GameProcess.Dispose();
                        GameProcess = null;
                    }
                }

                if (GameProcess == null)
                {
                    // Acquire a list of all processes
                    var wowProcess = Process.GetProcesses().FirstOrDefault(process => WoWProcessNames.Contains(process.ProcessName.ToLower()) && process.HasExited == false);
                    if (wowProcess != null)
                    {
                        try
                        {
                            Log.WriteLine($"Process found: [{wowProcess.Id}] {wowProcess.ProcessName}");

                            GameProcess = wowProcess;
                            


                            if (Properties.Settings.Default.EnableMemoryReading) // Attach memory reader
                                MemoryManager.Attach(wowProcess);

                            
                        }
                        catch
                        {
                            MemoryManager.Detach();
                            GameProcess = null;
                        }
                        // Attempt to export bindings
                        ConsolePort.BindWriter.WriteBinds();
                    }
                }

                Thread.Sleep(500);
            }
        }

        internal static void Start()
        {
            Log.WriteLine("Process watcher starting up");
            _threadRunning = true;
            ProcessThread.Start();
        }
        internal static void Stop()
        {
            Log.WriteLine("Process watcher shutting down");
            MemoryManager.Detach();
            _threadRunning = false;
            ProcessThread.Abort();
            
        }
    }

    internal enum ProcessType
    {
        None,
        WoW32,
        WoW64,
        WoWT,
        WoWT64
    }
}
