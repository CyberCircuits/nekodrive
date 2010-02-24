﻿namespace NekoDrive
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.gbTargetConnection = new System.Windows.Forms.GroupBox();
            this.lblTimeOut = new System.Windows.Forms.Label();
            this.nupTimeOut = new System.Windows.Forms.NumericUpDown();
            this.lblCurrentFile = new System.Windows.Forms.Label();
            this.cboxVer = new System.Windows.Forms.ComboBox();
            this.lblUserId = new System.Windows.Forms.Label();
            this.lblGroupId = new System.Windows.Forms.Label();
            this.tbUserId = new System.Windows.Forms.TextBox();
            this.tbGroupId = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.gboxMount = new System.Windows.Forms.GroupBox();
            this.lblRemoteDevices = new System.Windows.Forms.Label();
            this.cboxRemoteDevices = new System.Windows.Forms.ComboBox();
            this.lblLocalDrive = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnMount = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ipAddressControl1 = new NekoDrive.Controls.IPAddressControl();
            this.gbTargetConnection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupTimeOut)).BeginInit();
            this.gboxMount.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTargetConnection
            // 
            this.gbTargetConnection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTargetConnection.Controls.Add(this.tbGroupId);
            this.gbTargetConnection.Controls.Add(this.tbUserId);
            this.gbTargetConnection.Controls.Add(this.lblGroupId);
            this.gbTargetConnection.Controls.Add(this.lblUserId);
            this.gbTargetConnection.Controls.Add(this.ipAddressControl1);
            this.gbTargetConnection.Controls.Add(this.lblTimeOut);
            this.gbTargetConnection.Controls.Add(this.nupTimeOut);
            this.gbTargetConnection.Controls.Add(this.lblCurrentFile);
            this.gbTargetConnection.Controls.Add(this.cboxVer);
            this.gbTargetConnection.Controls.Add(this.btnConnect);
            this.gbTargetConnection.Location = new System.Drawing.Point(12, 12);
            this.gbTargetConnection.Name = "gbTargetConnection";
            this.gbTargetConnection.Size = new System.Drawing.Size(388, 91);
            this.gbTargetConnection.TabIndex = 5;
            this.gbTargetConnection.TabStop = false;
            this.gbTargetConnection.Text = "Target Connection";
            // 
            // lblTimeOut
            // 
            this.lblTimeOut.AutoSize = true;
            this.lblTimeOut.Location = new System.Drawing.Point(177, 21);
            this.lblTimeOut.Name = "lblTimeOut";
            this.lblTimeOut.Size = new System.Drawing.Size(50, 13);
            this.lblTimeOut.TabIndex = 9;
            this.lblTimeOut.Text = "Time Out";
            // 
            // nupTimeOut
            // 
            this.nupTimeOut.Location = new System.Drawing.Point(233, 19);
            this.nupTimeOut.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nupTimeOut.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nupTimeOut.Name = "nupTimeOut";
            this.nupTimeOut.Size = new System.Drawing.Size(43, 20);
            this.nupTimeOut.TabIndex = 8;
            this.nupTimeOut.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // lblCurrentFile
            // 
            this.lblCurrentFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentFile.AutoSize = true;
            this.lblCurrentFile.Location = new System.Drawing.Point(187, 13);
            this.lblCurrentFile.Name = "lblCurrentFile";
            this.lblCurrentFile.Size = new System.Drawing.Size(0, 13);
            this.lblCurrentFile.TabIndex = 6;
            // 
            // cboxVer
            // 
            this.cboxVer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxVer.FormattingEnabled = true;
            this.cboxVer.Items.AddRange(new object[] {
            "V2",
            "V3"});
            this.cboxVer.Location = new System.Drawing.Point(124, 21);
            this.cboxVer.Name = "cboxVer";
            this.cboxVer.Size = new System.Drawing.Size(46, 21);
            this.cboxVer.TabIndex = 4;
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(7, 60);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(38, 13);
            this.lblUserId.TabIndex = 11;
            this.lblUserId.Text = "UserId";
            // 
            // lblGroupId
            // 
            this.lblGroupId.AutoSize = true;
            this.lblGroupId.Location = new System.Drawing.Point(177, 60);
            this.lblGroupId.Name = "lblGroupId";
            this.lblGroupId.Size = new System.Drawing.Size(45, 13);
            this.lblGroupId.TabIndex = 11;
            this.lblGroupId.Text = "GroupId";
            // 
            // tbUserId
            // 
            this.tbUserId.Location = new System.Drawing.Point(70, 57);
            this.tbUserId.Name = "tbUserId";
            this.tbUserId.Size = new System.Drawing.Size(100, 20);
            this.tbUserId.TabIndex = 12;
            this.tbUserId.Text = "0";
            // 
            // tbGroupId
            // 
            this.tbGroupId.Location = new System.Drawing.Point(233, 57);
            this.tbGroupId.Name = "tbGroupId";
            this.tbGroupId.Size = new System.Drawing.Size(100, 20);
            this.tbGroupId.TabIndex = 12;
            this.tbGroupId.Text = "0";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(297, 18);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // gboxMount
            // 
            this.gboxMount.Controls.Add(this.lblLocalDrive);
            this.gboxMount.Controls.Add(this.lblRemoteDevices);
            this.gboxMount.Controls.Add(this.comboBox1);
            this.gboxMount.Controls.Add(this.cboxRemoteDevices);
            this.gboxMount.Controls.Add(this.btnMount);
            this.gboxMount.Location = new System.Drawing.Point(12, 109);
            this.gboxMount.Name = "gboxMount";
            this.gboxMount.Size = new System.Drawing.Size(388, 84);
            this.gboxMount.TabIndex = 6;
            this.gboxMount.TabStop = false;
            this.gboxMount.Text = "Mount";
            // 
            // lblRemoteDevices
            // 
            this.lblRemoteDevices.AutoSize = true;
            this.lblRemoteDevices.Location = new System.Drawing.Point(14, 23);
            this.lblRemoteDevices.Name = "lblRemoteDevices";
            this.lblRemoteDevices.Size = new System.Drawing.Size(86, 13);
            this.lblRemoteDevices.TabIndex = 2;
            this.lblRemoteDevices.Text = "Remote Devices";
            // 
            // cboxRemoteDevices
            // 
            this.cboxRemoteDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxRemoteDevices.FormattingEnabled = true;
            this.cboxRemoteDevices.Location = new System.Drawing.Point(106, 19);
            this.cboxRemoteDevices.Name = "cboxRemoteDevices";
            this.cboxRemoteDevices.Size = new System.Drawing.Size(121, 21);
            this.cboxRemoteDevices.TabIndex = 3;
            // 
            // lblLocalDrive
            // 
            this.lblLocalDrive.AutoSize = true;
            this.lblLocalDrive.Location = new System.Drawing.Point(14, 50);
            this.lblLocalDrive.Name = "lblLocalDrive";
            this.lblLocalDrive.Size = new System.Drawing.Size(61, 13);
            this.lblLocalDrive.TabIndex = 2;
            this.lblLocalDrive.Text = "Local Drive";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(106, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(32, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // btnMount
            // 
            this.btnMount.Location = new System.Drawing.Point(297, 19);
            this.btnMount.Name = "btnMount";
            this.btnMount.Size = new System.Drawing.Size(75, 23);
            this.btnMount.TabIndex = 3;
            this.btnMount.Text = "Mount";
            this.btnMount.UseVisualStyleBackColor = true;
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "NekoDrive";
            this.notifyIcon.Visible = true;
            // 
            // ipAddressControl1
            // 
            this.ipAddressControl1.BackColor = System.Drawing.SystemColors.Window;
            this.ipAddressControl1.Location = new System.Drawing.Point(6, 21);
            this.ipAddressControl1.MinimumSize = new System.Drawing.Size(112, 20);
            this.ipAddressControl1.Name = "ipAddressControl1";
            this.ipAddressControl1.ReadOnly = false;
            this.ipAddressControl1.Size = new System.Drawing.Size(112, 20);
            this.ipAddressControl1.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 205);
            this.Controls.Add(this.gboxMount);
            this.Controls.Add(this.gbTargetConnection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "NekoDrive Settings";
            this.gbTargetConnection.ResumeLayout(false);
            this.gbTargetConnection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupTimeOut)).EndInit();
            this.gboxMount.ResumeLayout(false);
            this.gboxMount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTargetConnection;
        private System.Windows.Forms.Label lblTimeOut;
        private System.Windows.Forms.NumericUpDown nupTimeOut;
        private System.Windows.Forms.Label lblCurrentFile;
        private System.Windows.Forms.ComboBox cboxVer;
        private NekoDrive.Controls.IPAddressControl ipAddressControl1;
        private System.Windows.Forms.Label lblGroupId;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.TextBox tbGroupId;
        private System.Windows.Forms.TextBox tbUserId;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox gboxMount;
        private System.Windows.Forms.Label lblLocalDrive;
        private System.Windows.Forms.Label lblRemoteDevices;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cboxRemoteDevices;
        private System.Windows.Forms.Button btnMount;
        private System.Windows.Forms.NotifyIcon notifyIcon;

    }
}