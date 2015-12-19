﻿namespace WoWmapper_360Driver.Forms
{
    partial class KeybindForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelCenterCursor = new System.Windows.Forms.Label();
            this.textPS = new System.Windows.Forms.TextBox();
            this.labelBindHow = new System.Windows.Forms.Label();
            this.textOptions = new System.Windows.Forms.TextBox();
            this.textShare = new System.Windows.Forms.TextBox();
            this.panelCamera = new System.Windows.Forms.Panel();
            this.labelCamera = new System.Windows.Forms.Label();
            this.numRSpeed = new System.Windows.Forms.NumericUpDown();
            this.numRCurve = new System.Windows.Forms.NumericUpDown();
            this.numRDeadzone = new System.Windows.Forms.NumericUpDown();
            this.labelRightSpeed = new System.Windows.Forms.Label();
            this.panelRStickAxis = new System.Windows.Forms.Panel();
            this.labelRightCurve = new System.Windows.Forms.Label();
            this.labelRightDead = new System.Windows.Forms.Label();
            this.textSquare = new System.Windows.Forms.TextBox();
            this.textCross = new System.Windows.Forms.TextBox();
            this.textCircle = new System.Windows.Forms.TextBox();
            this.textTriangle = new System.Windows.Forms.TextBox();
            this.textDpadLeft = new System.Windows.Forms.TextBox();
            this.textDpadDown = new System.Windows.Forms.TextBox();
            this.textDpadRight = new System.Windows.Forms.TextBox();
            this.textDpadUp = new System.Windows.Forms.TextBox();
            this.panelMovement = new System.Windows.Forms.Panel();
            this.labelMovement = new System.Windows.Forms.Label();
            this.textMoveLeft = new System.Windows.Forms.TextBox();
            this.textMoveBackward = new System.Windows.Forms.TextBox();
            this.textMoveRight = new System.Windows.Forms.TextBox();
            this.textMoveForward = new System.Windows.Forms.TextBox();
            this.textR2 = new System.Windows.Forms.TextBox();
            this.textR1 = new System.Windows.Forms.TextBox();
            this.textL2 = new System.Windows.Forms.TextBox();
            this.textL1 = new System.Windows.Forms.TextBox();
            this.timerUpdateUI = new System.Windows.Forms.Timer(this.components);
            this.picConfigR2 = new System.Windows.Forms.PictureBox();
            this.picConfigL2 = new System.Windows.Forms.PictureBox();
            this.picResetBinds = new System.Windows.Forms.PictureBox();
            this.picLStickLeft = new System.Windows.Forms.PictureBox();
            this.picLStickDown = new System.Windows.Forms.PictureBox();
            this.picLStickRight = new System.Windows.Forms.PictureBox();
            this.picLStickUp = new System.Windows.Forms.PictureBox();
            this.picDS4 = new System.Windows.Forms.PictureBox();
            this.panelCamera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRCurve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRDeadzone)).BeginInit();
            this.panelMovement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picConfigR2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picConfigL2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResetBinds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLStickLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLStickDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLStickRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLStickUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDS4)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCenterCursor
            // 
            this.labelCenterCursor.AutoSize = true;
            this.labelCenterCursor.ForeColor = System.Drawing.Color.White;
            this.labelCenterCursor.Location = new System.Drawing.Point(648, 363);
            this.labelCenterCursor.Name = "labelCenterCursor";
            this.labelCenterCursor.Size = new System.Drawing.Size(80, 30);
            this.labelCenterCursor.TabIndex = 72;
            this.labelCenterCursor.Text = "Control+R3:\r\nCenter Cursor";
            // 
            // textPS
            // 
            this.textPS.Location = new System.Drawing.Point(312, 331);
            this.textPS.Name = "textPS";
            this.textPS.ReadOnly = true;
            this.textPS.Size = new System.Drawing.Size(116, 23);
            this.textPS.TabIndex = 56;
            this.textPS.Tag = "CenterMiddle";
            this.textPS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textPS.DoubleClick += new System.EventHandler(this.BindBox_DoubleClick);
            // 
            // labelBindHow
            // 
            this.labelBindHow.AutoSize = true;
            this.labelBindHow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBindHow.ForeColor = System.Drawing.Color.White;
            this.labelBindHow.Location = new System.Drawing.Point(256, 5);
            this.labelBindHow.Name = "labelBindHow";
            this.labelBindHow.Size = new System.Drawing.Size(249, 21);
            this.labelBindHow.TabIndex = 65;
            this.labelBindHow.Text = "Double click binding to change";
            // 
            // textOptions
            // 
            this.textOptions.Location = new System.Drawing.Point(370, 53);
            this.textOptions.Name = "textOptions";
            this.textOptions.ReadOnly = true;
            this.textOptions.Size = new System.Drawing.Size(80, 23);
            this.textOptions.TabIndex = 53;
            this.textOptions.Tag = "CenterRight";
            this.textOptions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textOptions.DoubleClick += new System.EventHandler(this.BindBox_DoubleClick);
            // 
            // textShare
            // 
            this.textShare.Location = new System.Drawing.Point(284, 53);
            this.textShare.Name = "textShare";
            this.textShare.ReadOnly = true;
            this.textShare.Size = new System.Drawing.Size(80, 23);
            this.textShare.TabIndex = 52;
            this.textShare.Tag = "CenterLeft";
            this.textShare.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textShare.DoubleClick += new System.EventHandler(this.BindBox_DoubleClick);
            // 
            // panelCamera
            // 
            this.panelCamera.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCamera.Controls.Add(this.labelCamera);
            this.panelCamera.Controls.Add(this.numRSpeed);
            this.panelCamera.Controls.Add(this.numRCurve);
            this.panelCamera.Controls.Add(this.numRDeadzone);
            this.panelCamera.Controls.Add(this.labelRightSpeed);
            this.panelCamera.Controls.Add(this.panelRStickAxis);
            this.panelCamera.Controls.Add(this.labelRightCurve);
            this.panelCamera.Controls.Add(this.labelRightDead);
            this.panelCamera.Location = new System.Drawing.Point(484, 396);
            this.panelCamera.Name = "panelCamera";
            this.panelCamera.Size = new System.Drawing.Size(247, 107);
            this.panelCamera.TabIndex = 64;
            // 
            // labelCamera
            // 
            this.labelCamera.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelCamera.Location = new System.Drawing.Point(3, 2);
            this.labelCamera.Name = "labelCamera";
            this.labelCamera.Size = new System.Drawing.Size(76, 22);
            this.labelCamera.TabIndex = 30;
            this.labelCamera.Text = "camera";
            // 
            // numRSpeed
            // 
            this.numRSpeed.Location = new System.Drawing.Point(175, 72);
            this.numRSpeed.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numRSpeed.Name = "numRSpeed";
            this.numRSpeed.Size = new System.Drawing.Size(58, 23);
            this.numRSpeed.TabIndex = 29;
            this.numRSpeed.ValueChanged += new System.EventHandler(this.numRSpeed_ValueChanged);
            // 
            // numRCurve
            // 
            this.numRCurve.Location = new System.Drawing.Point(175, 38);
            this.numRCurve.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numRCurve.Name = "numRCurve";
            this.numRCurve.Size = new System.Drawing.Size(58, 23);
            this.numRCurve.TabIndex = 28;
            this.numRCurve.ValueChanged += new System.EventHandler(this.numRCurve_ValueChanged);
            // 
            // numRDeadzone
            // 
            this.numRDeadzone.Location = new System.Drawing.Point(175, 5);
            this.numRDeadzone.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numRDeadzone.Name = "numRDeadzone";
            this.numRDeadzone.Size = new System.Drawing.Size(58, 23);
            this.numRDeadzone.TabIndex = 27;
            this.numRDeadzone.ValueChanged += new System.EventHandler(this.numRDeadzone_ValueChanged);
            // 
            // labelRightSpeed
            // 
            this.labelRightSpeed.AutoSize = true;
            this.labelRightSpeed.ForeColor = System.Drawing.Color.White;
            this.labelRightSpeed.Location = new System.Drawing.Point(86, 74);
            this.labelRightSpeed.Name = "labelRightSpeed";
            this.labelRightSpeed.Size = new System.Drawing.Size(38, 15);
            this.labelRightSpeed.TabIndex = 24;
            this.labelRightSpeed.Text = "speed";
            // 
            // panelRStickAxis
            // 
            this.panelRStickAxis.Location = new System.Drawing.Point(3, 23);
            this.panelRStickAxis.Name = "panelRStickAxis";
            this.panelRStickAxis.Size = new System.Drawing.Size(76, 75);
            this.panelRStickAxis.TabIndex = 26;
            this.panelRStickAxis.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRStick_Paint);
            // 
            // labelRightCurve
            // 
            this.labelRightCurve.AutoSize = true;
            this.labelRightCurve.ForeColor = System.Drawing.Color.White;
            this.labelRightCurve.Location = new System.Drawing.Point(86, 40);
            this.labelRightCurve.Name = "labelRightCurve";
            this.labelRightCurve.Size = new System.Drawing.Size(36, 15);
            this.labelRightCurve.TabIndex = 22;
            this.labelRightCurve.Text = "curve";
            // 
            // labelRightDead
            // 
            this.labelRightDead.AutoSize = true;
            this.labelRightDead.ForeColor = System.Drawing.Color.White;
            this.labelRightDead.Location = new System.Drawing.Point(86, 7);
            this.labelRightDead.Name = "labelRightDead";
            this.labelRightDead.Size = new System.Drawing.Size(58, 15);
            this.labelRightDead.TabIndex = 21;
            this.labelRightDead.Text = "deadzone";
            // 
            // textSquare
            // 
            this.textSquare.Location = new System.Drawing.Point(612, 199);
            this.textSquare.Name = "textSquare";
            this.textSquare.ReadOnly = true;
            this.textSquare.Size = new System.Drawing.Size(116, 23);
            this.textSquare.TabIndex = 63;
            this.textSquare.Tag = "RFaceLeft";
            this.textSquare.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textSquare.DoubleClick += new System.EventHandler(this.BindBox_DoubleClick);
            // 
            // textCross
            // 
            this.textCross.Location = new System.Drawing.Point(612, 170);
            this.textCross.Name = "textCross";
            this.textCross.ReadOnly = true;
            this.textCross.Size = new System.Drawing.Size(116, 23);
            this.textCross.TabIndex = 62;
            this.textCross.Tag = "RFaceDown";
            this.textCross.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textCross.DoubleClick += new System.EventHandler(this.BindBox_DoubleClick);
            // 
            // textCircle
            // 
            this.textCircle.Location = new System.Drawing.Point(612, 141);
            this.textCircle.Name = "textCircle";
            this.textCircle.ReadOnly = true;
            this.textCircle.Size = new System.Drawing.Size(116, 23);
            this.textCircle.TabIndex = 61;
            this.textCircle.Tag = "RFaceRight";
            this.textCircle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textCircle.DoubleClick += new System.EventHandler(this.BindBox_DoubleClick);
            // 
            // textTriangle
            // 
            this.textTriangle.Location = new System.Drawing.Point(612, 112);
            this.textTriangle.Name = "textTriangle";
            this.textTriangle.ReadOnly = true;
            this.textTriangle.Size = new System.Drawing.Size(116, 23);
            this.textTriangle.TabIndex = 60;
            this.textTriangle.Tag = "RFaceUp";
            this.textTriangle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textTriangle.DoubleClick += new System.EventHandler(this.BindBox_DoubleClick);
            // 
            // textDpadLeft
            // 
            this.textDpadLeft.Location = new System.Drawing.Point(7, 296);
            this.textDpadLeft.Name = "textDpadLeft";
            this.textDpadLeft.ReadOnly = true;
            this.textDpadLeft.Size = new System.Drawing.Size(116, 23);
            this.textDpadLeft.TabIndex = 59;
            this.textDpadLeft.Tag = "LFaceRight";
            this.textDpadLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textDpadLeft.DoubleClick += new System.EventHandler(this.BindBox_DoubleClick);
            // 
            // textDpadDown
            // 
            this.textDpadDown.Location = new System.Drawing.Point(7, 267);
            this.textDpadDown.Name = "textDpadDown";
            this.textDpadDown.ReadOnly = true;
            this.textDpadDown.Size = new System.Drawing.Size(116, 23);
            this.textDpadDown.TabIndex = 58;
            this.textDpadDown.Tag = "LFaceDown";
            this.textDpadDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textDpadDown.DoubleClick += new System.EventHandler(this.BindBox_DoubleClick);
            // 
            // textDpadRight
            // 
            this.textDpadRight.Location = new System.Drawing.Point(7, 204);
            this.textDpadRight.Name = "textDpadRight";
            this.textDpadRight.ReadOnly = true;
            this.textDpadRight.Size = new System.Drawing.Size(116, 23);
            this.textDpadRight.TabIndex = 57;
            this.textDpadRight.Tag = "LFaceLeft";
            this.textDpadRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textDpadRight.DoubleClick += new System.EventHandler(this.BindBox_DoubleClick);
            // 
            // textDpadUp
            // 
            this.textDpadUp.Location = new System.Drawing.Point(7, 162);
            this.textDpadUp.Name = "textDpadUp";
            this.textDpadUp.ReadOnly = true;
            this.textDpadUp.Size = new System.Drawing.Size(116, 23);
            this.textDpadUp.TabIndex = 55;
            this.textDpadUp.Tag = "LFaceUp";
            this.textDpadUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textDpadUp.DoubleClick += new System.EventHandler(this.BindBox_DoubleClick);
            // 
            // panelMovement
            // 
            this.panelMovement.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMovement.Controls.Add(this.labelMovement);
            this.panelMovement.Controls.Add(this.picLStickLeft);
            this.panelMovement.Controls.Add(this.textMoveLeft);
            this.panelMovement.Controls.Add(this.picLStickDown);
            this.panelMovement.Controls.Add(this.textMoveBackward);
            this.panelMovement.Controls.Add(this.picLStickRight);
            this.panelMovement.Controls.Add(this.textMoveRight);
            this.panelMovement.Controls.Add(this.picLStickUp);
            this.panelMovement.Controls.Add(this.textMoveForward);
            this.panelMovement.Location = new System.Drawing.Point(7, 396);
            this.panelMovement.Name = "panelMovement";
            this.panelMovement.Size = new System.Drawing.Size(340, 107);
            this.panelMovement.TabIndex = 54;
            // 
            // labelMovement
            // 
            this.labelMovement.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelMovement.Location = new System.Drawing.Point(199, 2);
            this.labelMovement.Name = "labelMovement";
            this.labelMovement.Size = new System.Drawing.Size(133, 22);
            this.labelMovement.TabIndex = 31;
            this.labelMovement.Text = "movement";
            this.labelMovement.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textMoveLeft
            // 
            this.textMoveLeft.Location = new System.Drawing.Point(2, 36);
            this.textMoveLeft.Name = "textMoveLeft";
            this.textMoveLeft.ReadOnly = true;
            this.textMoveLeft.Size = new System.Drawing.Size(116, 23);
            this.textMoveLeft.TabIndex = 33;
            this.textMoveLeft.Tag = "LStickLeft";
            this.textMoveLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textMoveLeft.DoubleClick += new System.EventHandler(this.BindBox_DoubleClick);
            // 
            // textMoveBackward
            // 
            this.textMoveBackward.Location = new System.Drawing.Point(29, 69);
            this.textMoveBackward.Name = "textMoveBackward";
            this.textMoveBackward.ReadOnly = true;
            this.textMoveBackward.Size = new System.Drawing.Size(116, 23);
            this.textMoveBackward.TabIndex = 31;
            this.textMoveBackward.Tag = "LStickDown";
            this.textMoveBackward.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textMoveBackward.DoubleClick += new System.EventHandler(this.BindBox_DoubleClick);
            // 
            // textMoveRight
            // 
            this.textMoveRight.Location = new System.Drawing.Point(217, 37);
            this.textMoveRight.Name = "textMoveRight";
            this.textMoveRight.ReadOnly = true;
            this.textMoveRight.Size = new System.Drawing.Size(116, 23);
            this.textMoveRight.TabIndex = 29;
            this.textMoveRight.Tag = "LStickRight";
            this.textMoveRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textMoveRight.DoubleClick += new System.EventHandler(this.BindBox_DoubleClick);
            // 
            // textMoveForward
            // 
            this.textMoveForward.Location = new System.Drawing.Point(29, 3);
            this.textMoveForward.Name = "textMoveForward";
            this.textMoveForward.ReadOnly = true;
            this.textMoveForward.Size = new System.Drawing.Size(116, 23);
            this.textMoveForward.TabIndex = 27;
            this.textMoveForward.Tag = "LStickUp";
            this.textMoveForward.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textMoveForward.DoubleClick += new System.EventHandler(this.BindBox_DoubleClick);
            // 
            // textR2
            // 
            this.textR2.Location = new System.Drawing.Point(431, 29);
            this.textR2.Name = "textR2";
            this.textR2.ReadOnly = true;
            this.textR2.Size = new System.Drawing.Size(116, 23);
            this.textR2.TabIndex = 51;
            this.textR2.Tag = "TriggerRight";
            this.textR2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textR2.DoubleClick += new System.EventHandler(this.BindBox_DoubleClick);
            // 
            // textR1
            // 
            this.textR1.Location = new System.Drawing.Point(612, 83);
            this.textR1.Name = "textR1";
            this.textR1.ReadOnly = true;
            this.textR1.Size = new System.Drawing.Size(116, 23);
            this.textR1.TabIndex = 50;
            this.textR1.Tag = "BumperRight";
            this.textR1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textR1.DoubleClick += new System.EventHandler(this.BindBox_DoubleClick);
            // 
            // textL2
            // 
            this.textL2.Location = new System.Drawing.Point(189, 29);
            this.textL2.Name = "textL2";
            this.textL2.ReadOnly = true;
            this.textL2.Size = new System.Drawing.Size(116, 23);
            this.textL2.TabIndex = 49;
            this.textL2.Tag = "TriggerLeft";
            this.textL2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textL2.DoubleClick += new System.EventHandler(this.BindBox_DoubleClick);
            // 
            // textL1
            // 
            this.textL1.Location = new System.Drawing.Point(7, 83);
            this.textL1.Name = "textL1";
            this.textL1.ReadOnly = true;
            this.textL1.Size = new System.Drawing.Size(116, 23);
            this.textL1.TabIndex = 48;
            this.textL1.Tag = "BumperLeft";
            this.textL1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textL1.DoubleClick += new System.EventHandler(this.BindBox_DoubleClick);
            // 
            // timerUpdateUI
            // 
            this.timerUpdateUI.Enabled = true;
            this.timerUpdateUI.Interval = 50;
            this.timerUpdateUI.Tick += new System.EventHandler(this.timerUpdateUI_Tick);
            // 
            // picConfigR2
            // 
            this.picConfigR2.Location = new System.Drawing.Point(553, 29);
            this.picConfigR2.Name = "picConfigR2";
            this.picConfigR2.Size = new System.Drawing.Size(28, 28);
            this.picConfigR2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picConfigR2.TabIndex = 74;
            this.picConfigR2.TabStop = false;
            this.picConfigR2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // picConfigL2
            // 
            this.picConfigL2.Location = new System.Drawing.Point(155, 24);
            this.picConfigL2.Name = "picConfigL2";
            this.picConfigL2.Size = new System.Drawing.Size(28, 28);
            this.picConfigL2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picConfigL2.TabIndex = 73;
            this.picConfigL2.TabStop = false;
            this.picConfigL2.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picResetBinds
            // 
            this.picResetBinds.Location = new System.Drawing.Point(604, 12);
            this.picResetBinds.Name = "picResetBinds";
            this.picResetBinds.Size = new System.Drawing.Size(28, 28);
            this.picResetBinds.TabIndex = 71;
            this.picResetBinds.TabStop = false;
            this.picResetBinds.Click += new System.EventHandler(this.picResetBinds_Click);
            // 
            // picLStickLeft
            // 
            this.picLStickLeft.Location = new System.Drawing.Point(126, 36);
            this.picLStickLeft.Name = "picLStickLeft";
            this.picLStickLeft.Size = new System.Drawing.Size(28, 28);
            this.picLStickLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLStickLeft.TabIndex = 34;
            this.picLStickLeft.TabStop = false;
            // 
            // picLStickDown
            // 
            this.picLStickDown.Location = new System.Drawing.Point(154, 68);
            this.picLStickDown.Name = "picLStickDown";
            this.picLStickDown.Size = new System.Drawing.Size(28, 28);
            this.picLStickDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLStickDown.TabIndex = 32;
            this.picLStickDown.TabStop = false;
            // 
            // picLStickRight
            // 
            this.picLStickRight.Location = new System.Drawing.Point(182, 36);
            this.picLStickRight.Name = "picLStickRight";
            this.picLStickRight.Size = new System.Drawing.Size(28, 28);
            this.picLStickRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLStickRight.TabIndex = 30;
            this.picLStickRight.TabStop = false;
            // 
            // picLStickUp
            // 
            this.picLStickUp.Location = new System.Drawing.Point(154, 3);
            this.picLStickUp.Name = "picLStickUp";
            this.picLStickUp.Size = new System.Drawing.Size(28, 28);
            this.picLStickUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLStickUp.TabIndex = 28;
            this.picLStickUp.TabStop = false;
            // 
            // picDS4
            // 
            this.picDS4.Image = global::WoWmapper.Xbox360.Properties.Resources._360_drawn;
            this.picDS4.Location = new System.Drawing.Point(57, 32);
            this.picDS4.Name = "picDS4";
            this.picDS4.Size = new System.Drawing.Size(766, 471);
            this.picDS4.TabIndex = 47;
            this.picDS4.TabStop = false;
            // 
            // KeybindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(124)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(736, 508);
            this.Controls.Add(this.picConfigR2);
            this.Controls.Add(this.picConfigL2);
            this.Controls.Add(this.labelCenterCursor);
            this.Controls.Add(this.picResetBinds);
            this.Controls.Add(this.textPS);
            this.Controls.Add(this.labelBindHow);
            this.Controls.Add(this.textOptions);
            this.Controls.Add(this.textShare);
            this.Controls.Add(this.panelCamera);
            this.Controls.Add(this.textSquare);
            this.Controls.Add(this.textCross);
            this.Controls.Add(this.textCircle);
            this.Controls.Add(this.textTriangle);
            this.Controls.Add(this.textDpadLeft);
            this.Controls.Add(this.textDpadDown);
            this.Controls.Add(this.textDpadRight);
            this.Controls.Add(this.textDpadUp);
            this.Controls.Add(this.panelMovement);
            this.Controls.Add(this.textR2);
            this.Controls.Add(this.textR1);
            this.Controls.Add(this.textL2);
            this.Controls.Add(this.textL1);
            this.Controls.Add(this.picDS4);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "KeybindForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WoWmapper Xbox Controller Keybindings";
            this.panelCamera.ResumeLayout(false);
            this.panelCamera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRCurve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRDeadzone)).EndInit();
            this.panelMovement.ResumeLayout(false);
            this.panelMovement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picConfigR2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picConfigL2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResetBinds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLStickLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLStickDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLStickRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLStickUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDS4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picConfigR2;
        private System.Windows.Forms.PictureBox picConfigL2;
        private System.Windows.Forms.Label labelCenterCursor;
        private System.Windows.Forms.PictureBox picResetBinds;
        private System.Windows.Forms.TextBox textPS;
        private System.Windows.Forms.Label labelBindHow;
        private System.Windows.Forms.TextBox textOptions;
        private System.Windows.Forms.TextBox textShare;
        private System.Windows.Forms.Panel panelCamera;
        private System.Windows.Forms.Label labelCamera;
        private System.Windows.Forms.NumericUpDown numRSpeed;
        private System.Windows.Forms.NumericUpDown numRCurve;
        private System.Windows.Forms.NumericUpDown numRDeadzone;
        private System.Windows.Forms.Label labelRightSpeed;
        private System.Windows.Forms.Panel panelRStickAxis;
        private System.Windows.Forms.Label labelRightCurve;
        private System.Windows.Forms.Label labelRightDead;
        private System.Windows.Forms.TextBox textSquare;
        private System.Windows.Forms.TextBox textCross;
        private System.Windows.Forms.TextBox textCircle;
        private System.Windows.Forms.TextBox textTriangle;
        private System.Windows.Forms.TextBox textDpadLeft;
        private System.Windows.Forms.TextBox textDpadDown;
        private System.Windows.Forms.TextBox textDpadRight;
        private System.Windows.Forms.TextBox textDpadUp;
        private System.Windows.Forms.Panel panelMovement;
        private System.Windows.Forms.Label labelMovement;
        private System.Windows.Forms.PictureBox picLStickLeft;
        private System.Windows.Forms.TextBox textMoveLeft;
        private System.Windows.Forms.PictureBox picLStickDown;
        private System.Windows.Forms.TextBox textMoveBackward;
        private System.Windows.Forms.PictureBox picLStickRight;
        private System.Windows.Forms.TextBox textMoveRight;
        private System.Windows.Forms.PictureBox picLStickUp;
        private System.Windows.Forms.TextBox textMoveForward;
        private System.Windows.Forms.TextBox textR2;
        private System.Windows.Forms.TextBox textR1;
        private System.Windows.Forms.TextBox textL2;
        private System.Windows.Forms.TextBox textL1;
        private System.Windows.Forms.PictureBox picDS4;
        private System.Windows.Forms.Timer timerUpdateUI;
    }
}