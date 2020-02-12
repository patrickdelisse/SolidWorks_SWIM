namespace TC_NX_Launch
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ListApp = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelselect = new System.Windows.Forms.Panel();
            this.Nxlaunch_label = new System.Windows.Forms.LinkLabel();
            this.Nx_icon = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.paneloverview = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.LBL_TC_Server = new System.Windows.Forms.Label();
            this.LBL_Fixed_NX = new System.Windows.Forms.Label();
            this.LAUNCH_NX = new System.Windows.Forms.Button();
            this.Lbl_NX_versie = new System.Windows.Forms.Label();
            this.labelVerise = new System.Windows.Forms.Label();
            this.Foldup = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.launch_logo = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.LBL_AppVersion = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Cancel = new System.Windows.Forms.Button();
            this.SettingsEdit = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Folddown = new System.Windows.Forms.PictureBox();
            this.NXbar = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelselect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nx_icon)).BeginInit();
            this.paneloverview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Foldup)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.launch_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Folddown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NXbar)).BeginInit();
            this.SuspendLayout();
            // 
            // ListApp
            // 
            this.ListApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ListApp.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ListApp.FormattingEnabled = true;
            this.ListApp.ItemHeight = 19;
            this.ListApp.Location = new System.Drawing.Point(24, 34);
            this.ListApp.Name = "ListApp";
            this.ListApp.Size = new System.Drawing.Size(197, 99);
            this.ListApp.TabIndex = 60;
            this.toolTip1.SetToolTip(this.ListApp, "Allowed versions of SolidWorks");
            this.ListApp.SelectedIndexChanged += new System.EventHandler(this.ListApp_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(20, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 19);
            this.label1.TabIndex = 65;
            this.label1.Text = "SW Versions allowed";
            // 
            // panelselect
            // 
            this.panelselect.BackColor = System.Drawing.Color.Maroon;
            this.panelselect.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelselect.Controls.Add(this.label1);
            this.panelselect.Controls.Add(this.ListApp);
            this.panelselect.Location = new System.Drawing.Point(15, 373);
            this.panelselect.Name = "panelselect";
            this.panelselect.Size = new System.Drawing.Size(246, 146);
            this.panelselect.TabIndex = 66;
            this.toolTip1.SetToolTip(this.panelselect, "Close selection panel");
            // 
            // Nxlaunch_label
            // 
            this.Nxlaunch_label.Location = new System.Drawing.Point(0, 0);
            this.Nxlaunch_label.Name = "Nxlaunch_label";
            this.Nxlaunch_label.Size = new System.Drawing.Size(100, 23);
            this.Nxlaunch_label.TabIndex = 0;
            // 
            // Nx_icon
            // 
            this.Nx_icon.Location = new System.Drawing.Point(0, 0);
            this.Nx_icon.Name = "Nx_icon";
            this.Nx_icon.Size = new System.Drawing.Size(100, 50);
            this.Nx_icon.TabIndex = 0;
            this.Nx_icon.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 45);
            this.label2.TabIndex = 87;
            this.label2.Text = "SolidWorks (TC)";
            // 
            // paneloverview
            // 
            this.paneloverview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.paneloverview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneloverview.Controls.Add(this.label4);
            this.paneloverview.Controls.Add(this.LBL_TC_Server);
            this.paneloverview.Controls.Add(this.LBL_Fixed_NX);
            this.paneloverview.Controls.Add(this.LAUNCH_NX);
            this.paneloverview.Controls.Add(this.Lbl_NX_versie);
            this.paneloverview.Controls.Add(this.labelVerise);
            this.paneloverview.Location = new System.Drawing.Point(15, 180);
            this.paneloverview.Name = "paneloverview";
            this.paneloverview.Size = new System.Drawing.Size(246, 146);
            this.paneloverview.TabIndex = 88;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(7, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 86;
            this.label4.Text = "TC Server";
            // 
            // LBL_TC_Server
            // 
            this.LBL_TC_Server.AutoSize = true;
            this.LBL_TC_Server.BackColor = System.Drawing.Color.Transparent;
            this.LBL_TC_Server.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_TC_Server.ForeColor = System.Drawing.Color.Lime;
            this.LBL_TC_Server.Location = new System.Drawing.Point(106, 42);
            this.LBL_TC_Server.Name = "LBL_TC_Server";
            this.LBL_TC_Server.Size = new System.Drawing.Size(14, 19);
            this.LBL_TC_Server.TabIndex = 85;
            this.LBL_TC_Server.Text = "-";
            // 
            // LBL_Fixed_NX
            // 
            this.LBL_Fixed_NX.AutoSize = true;
            this.LBL_Fixed_NX.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Fixed_NX.ForeColor = System.Drawing.Color.Red;
            this.LBL_Fixed_NX.Location = new System.Drawing.Point(6, 37);
            this.LBL_Fixed_NX.Name = "LBL_Fixed_NX";
            this.LBL_Fixed_NX.Size = new System.Drawing.Size(139, 26);
            this.LBL_Fixed_NX.TabIndex = 4;
            this.LBL_Fixed_NX.Text = "Fixed SW in TC";
            this.LBL_Fixed_NX.Visible = false;
            // 
            // LAUNCH_NX
            // 
            this.LAUNCH_NX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.LAUNCH_NX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LAUNCH_NX.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.LAUNCH_NX.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.LAUNCH_NX.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.LAUNCH_NX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LAUNCH_NX.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAUNCH_NX.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LAUNCH_NX.Image = global::SolidWorks_SWIM.Properties.Resources.swim1;
            this.LAUNCH_NX.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LAUNCH_NX.Location = new System.Drawing.Point(9, 74);
            this.LAUNCH_NX.Name = "LAUNCH_NX";
            this.LAUNCH_NX.Size = new System.Drawing.Size(225, 61);
            this.LAUNCH_NX.TabIndex = 2;
            this.LAUNCH_NX.Text = "SolidWorks SWIM";
            this.LAUNCH_NX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LAUNCH_NX.UseVisualStyleBackColor = false;
            this.LAUNCH_NX.Click += new System.EventHandler(this.LAUNCH_NX_Click);
            this.LAUNCH_NX.MouseEnter += new System.EventHandler(this.LAUNCH_NX_MouseEnter);
            // 
            // Lbl_NX_versie
            // 
            this.Lbl_NX_versie.AutoSize = true;
            this.Lbl_NX_versie.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_NX_versie.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NX_versie.ForeColor = System.Drawing.Color.Lime;
            this.Lbl_NX_versie.Location = new System.Drawing.Point(106, 18);
            this.Lbl_NX_versie.Name = "Lbl_NX_versie";
            this.Lbl_NX_versie.Size = new System.Drawing.Size(14, 19);
            this.Lbl_NX_versie.TabIndex = 84;
            this.Lbl_NX_versie.Text = "-";
            // 
            // labelVerise
            // 
            this.labelVerise.AutoSize = true;
            this.labelVerise.BackColor = System.Drawing.Color.Transparent;
            this.labelVerise.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVerise.ForeColor = System.Drawing.Color.Yellow;
            this.labelVerise.Location = new System.Drawing.Point(7, 18);
            this.labelVerise.Name = "labelVerise";
            this.labelVerise.Size = new System.Drawing.Size(83, 19);
            this.labelVerise.TabIndex = 65;
            this.labelVerise.Text = "SW Version";
            // 
            // Foldup
            // 
            this.Foldup.BackColor = System.Drawing.Color.White;
            this.Foldup.Image = global::SolidWorks_SWIM.Properties.Resources.border_up;
            this.Foldup.Location = new System.Drawing.Point(239, 363);
            this.Foldup.Name = "Foldup";
            this.Foldup.Size = new System.Drawing.Size(22, 22);
            this.Foldup.TabIndex = 90;
            this.Foldup.TabStop = false;
            this.toolTip1.SetToolTip(this.Foldup, "Close selection window");
            this.Foldup.Visible = false;
            this.Foldup.Click += new System.EventHandler(this.Foldup_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.launch_logo);
            this.panel1.Controls.Add(this.logo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 143);
            this.panel1.TabIndex = 97;
            // 
            // launch_logo
            // 
            this.launch_logo.BackColor = System.Drawing.Color.Transparent;
            this.launch_logo.Image = ((System.Drawing.Image)(resources.GetObject("launch_logo.Image")));
            this.launch_logo.Location = new System.Drawing.Point(192, 12);
            this.launch_logo.Name = "launch_logo";
            this.launch_logo.Size = new System.Drawing.Size(69, 85);
            this.launch_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.launch_logo.TabIndex = 88;
            this.launch_logo.TabStop = false;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = global::SolidWorks_SWIM.Properties.Resources.logo;
            this.logo.Location = new System.Drawing.Point(15, 14);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(121, 83);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // LBL_AppVersion
            // 
            this.LBL_AppVersion.AutoSize = true;
            this.LBL_AppVersion.BackColor = System.Drawing.Color.Transparent;
            this.LBL_AppVersion.Cursor = System.Windows.Forms.Cursors.Help;
            this.LBL_AppVersion.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_AppVersion.ForeColor = System.Drawing.Color.Gray;
            this.LBL_AppVersion.Location = new System.Drawing.Point(29, 6);
            this.LBL_AppVersion.Name = "LBL_AppVersion";
            this.LBL_AppVersion.Size = new System.Drawing.Size(12, 14);
            this.LBL_AppVersion.TabIndex = 99;
            this.LBL_AppVersion.Text = "v";
            this.LBL_AppVersion.Click += new System.EventHandler(this.LBL_AppVersion_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.Cancel);
            this.panel2.Controls.Add(this.SettingsEdit);
            this.panel2.Controls.Add(this.LBL_AppVersion);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel2.Location = new System.Drawing.Point(5, 332);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 25);
            this.panel2.TabIndex = 101;
            // 
            // Cancel
            // 
            this.Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.FlatAppearance.BorderSize = 0;
            this.Cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Cancel.Location = new System.Drawing.Point(212, 0);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(58, 25);
            this.Cancel.TabIndex = 89;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // SettingsEdit
            // 
            this.SettingsEdit.BackColor = System.Drawing.Color.Transparent;
            this.SettingsEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsEdit.Image = global::SolidWorks_SWIM.Properties.Resources.settingsicon;
            this.SettingsEdit.Location = new System.Drawing.Point(3, 3);
            this.SettingsEdit.Name = "SettingsEdit";
            this.SettingsEdit.Size = new System.Drawing.Size(20, 20);
            this.SettingsEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SettingsEdit.TabIndex = 96;
            this.SettingsEdit.TabStop = false;
            this.toolTip1.SetToolTip(this.SettingsEdit, "Show the settingspanel");
            this.SettingsEdit.Click += new System.EventHandler(this.SettingsEdit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Violet;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Image = global::SolidWorks_SWIM.Properties.Resources.border_bar;
            this.label3.Location = new System.Drawing.Point(22, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 14);
            this.label3.TabIndex = 94;
            this.label3.Text = "SolidWorks (TEAMCENTER integration)";
            // 
            // Folddown
            // 
            this.Folddown.BackColor = System.Drawing.Color.White;
            this.Folddown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Folddown.Image = global::SolidWorks_SWIM.Properties.Resources.border_down;
            this.Folddown.Location = new System.Drawing.Point(239, 160);
            this.Folddown.Name = "Folddown";
            this.Folddown.Size = new System.Drawing.Size(22, 22);
            this.Folddown.TabIndex = 89;
            this.Folddown.TabStop = false;
            this.toolTip1.SetToolTip(this.Folddown, "Select the installed NX version and or Group environment");
            this.Folddown.Click += new System.EventHandler(this.Folddown_Click);
            // 
            // NXbar
            // 
            this.NXbar.Image = global::SolidWorks_SWIM.Properties.Resources.border_bar;
            this.NXbar.Location = new System.Drawing.Point(15, 160);
            this.NXbar.Name = "NXbar";
            this.NXbar.Size = new System.Drawing.Size(224, 22);
            this.NXbar.TabIndex = 91;
            this.NXbar.TabStop = false;
            this.NXbar.Click += new System.EventHandler(this.NXbar_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 600;
            this.toolTip1.AutoPopDelay = 6000;
            this.toolTip1.InitialDelay = 600;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 120;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(276, 531);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Foldup);
            this.Controls.Add(this.Folddown);
            this.Controls.Add(this.NXbar);
            this.Controls.Add(this.panelselect);
            this.Controls.Add(this.paneloverview);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KMWE SolidWorks - SWIM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelselect.ResumeLayout(false);
            this.panelselect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nx_icon)).EndInit();
            this.paneloverview.ResumeLayout(false);
            this.paneloverview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Foldup)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.launch_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Folddown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NXbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        internal System.Windows.Forms.ListBox ListApp;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelselect;
        private System.Windows.Forms.PictureBox Nx_icon;
        private System.Windows.Forms.LinkLabel Nxlaunch_label;
        private System.Windows.Forms.Panel paneloverview;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label labelVerise;
        internal System.Windows.Forms.PictureBox Folddown;
        internal System.Windows.Forms.PictureBox Foldup;
        internal System.Windows.Forms.PictureBox NXbar;
        internal System.Windows.Forms.Label Lbl_NX_versie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox SettingsEdit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LBL_AppVersion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox launch_logo;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button LAUNCH_NX;
        private System.Windows.Forms.Label LBL_Fixed_NX;
        private System.Windows.Forms.ToolTip toolTip1;
        internal System.Windows.Forms.Label LBL_TC_Server;
        internal System.Windows.Forms.Label label4;
    }
}

