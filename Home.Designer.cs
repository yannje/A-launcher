using System;

namespace MikraftProjet
{
    partial class Home
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Logout = new Guna.UI2.WinForms.Guna2Button();
            this.Game = new Guna.UI2.WinForms.Guna2Button();
            this.NameMC = new System.Windows.Forms.Label();
            this.Head = new System.Windows.Forms.PictureBox();
            this.InfoMC = new System.Windows.Forms.Label();
            this.SettingsBox = new Guna.UI2.WinForms.Guna2GroupBox();
            this.ScreenResolution = new Guna.UI2.WinForms.Guna2GroupBox();
            this.ResCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.RamCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Java = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OtherSettings = new Guna.UI2.WinForms.Guna2GroupBox();
            this.NewsScreen = new System.Windows.Forms.WebBrowser();
            this.pourcentage = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.versions = new Guna.UI2.WinForms.Guna2ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Head)).BeginInit();
            this.SettingsBox.SuspendLayout();
            this.ScreenResolution.SuspendLayout();
            this.Java.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.versions);
            this.groupBox1.Controls.Add(this.Logout);
            this.groupBox1.Controls.Add(this.Game);
            this.groupBox1.Controls.Add(this.NameMC);
            this.groupBox1.Controls.Add(this.Head);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 613);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1264, 68);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // Logout
            // 
            this.Logout.BorderRadius = 10;
            this.Logout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Logout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Logout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Logout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Logout.FillColor = System.Drawing.Color.White;
            this.Logout.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.Logout.ForeColor = System.Drawing.Color.Black;
            this.Logout.Location = new System.Drawing.Point(1069, 15);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(180, 45);
            this.Logout.TabIndex = 4;
            this.Logout.Text = "Logout";
            this.Logout.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // Game
            // 
            this.Game.BorderRadius = 10;
            this.Game.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Game.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Game.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Game.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Game.FillColor = System.Drawing.Color.White;
            this.Game.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.Game.ForeColor = System.Drawing.Color.Black;
            this.Game.Location = new System.Drawing.Point(552, 15);
            this.Game.Name = "Game";
            this.Game.Size = new System.Drawing.Size(180, 45);
            this.Game.TabIndex = 3;
            this.Game.Text = "Launch";
            this.Game.Click += new System.EventHandler(this.Game_Click);
            // 
            // NameMC
            // 
            this.NameMC.AutoSize = true;
            this.NameMC.Font = new System.Drawing.Font("Miriam Libre", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameMC.Location = new System.Drawing.Point(66, 26);
            this.NameMC.Name = "NameMC";
            this.NameMC.Size = new System.Drawing.Size(54, 21);
            this.NameMC.TabIndex = 2;
            this.NameMC.Text = "Name";
            // 
            // Head
            // 
            this.Head.Location = new System.Drawing.Point(12, 12);
            this.Head.Name = "Head";
            this.Head.Size = new System.Drawing.Size(48, 48);
            this.Head.TabIndex = 0;
            this.Head.TabStop = false;
            // 
            // InfoMC
            // 
            this.InfoMC.AutoSize = true;
            this.InfoMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoMC.Location = new System.Drawing.Point(632, 576);
            this.InfoMC.Name = "InfoMC";
            this.InfoMC.Size = new System.Drawing.Size(0, 25);
            this.InfoMC.TabIndex = 1;
            // 
            // SettingsBox
            // 
            this.SettingsBox.BackColor = System.Drawing.Color.Transparent;
            this.SettingsBox.BorderRadius = 10;
            this.SettingsBox.Controls.Add(this.ScreenResolution);
            this.SettingsBox.Controls.Add(this.Java);
            this.SettingsBox.Controls.Add(this.OtherSettings);
            this.SettingsBox.FillColor = System.Drawing.Color.Transparent;
            this.SettingsBox.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.SettingsBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.SettingsBox.Location = new System.Drawing.Point(862, 12);
            this.SettingsBox.Name = "SettingsBox";
            this.SettingsBox.Size = new System.Drawing.Size(390, 561);
            this.SettingsBox.TabIndex = 3;
            this.SettingsBox.Text = "Settings";
            // 
            // ScreenResolution
            // 
            this.ScreenResolution.BorderRadius = 10;
            this.ScreenResolution.Controls.Add(this.ResCombo);
            this.ScreenResolution.Controls.Add(this.RamCombo);
            this.ScreenResolution.Controls.Add(this.label3);
            this.ScreenResolution.Controls.Add(this.label2);
            this.ScreenResolution.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreenResolution.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ScreenResolution.Location = new System.Drawing.Point(3, 43);
            this.ScreenResolution.Name = "ScreenResolution";
            this.ScreenResolution.Size = new System.Drawing.Size(384, 186);
            this.ScreenResolution.TabIndex = 1;
            this.ScreenResolution.Text = "General";
            // 
            // ResCombo
            // 
            this.ResCombo.BackColor = System.Drawing.Color.Transparent;
            this.ResCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ResCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ResCombo.FillColor = System.Drawing.Color.Silver;
            this.ResCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ResCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ResCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ResCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ResCombo.ItemHeight = 30;
            this.ResCombo.Items.AddRange(new object[] {
            "800x600",
            "1280x720",
            "1600x900",
            "1080x1920"});
            this.ResCombo.Location = new System.Drawing.Point(59, 47);
            this.ResCombo.Name = "ResCombo";
            this.ResCombo.Size = new System.Drawing.Size(247, 36);
            this.ResCombo.StartIndex = 1;
            this.ResCombo.TabIndex = 5;
            this.ResCombo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ResCombo.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // RamCombo
            // 
            this.RamCombo.BackColor = System.Drawing.Color.Transparent;
            this.RamCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.RamCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RamCombo.FillColor = System.Drawing.Color.Silver;
            this.RamCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RamCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RamCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.RamCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.RamCombo.ItemHeight = 30;
            this.RamCombo.Items.AddRange(new object[] {
            "1024",
            "2048",
            "3072",
            "4096",
            "5120",
            "6144"});
            this.RamCombo.Location = new System.Drawing.Point(59, 110);
            this.RamCombo.Name = "RamCombo";
            this.RamCombo.Size = new System.Drawing.Size(247, 36);
            this.RamCombo.StartIndex = 1;
            this.RamCombo.TabIndex = 4;
            this.RamCombo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RamCombo.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Set the amount of ram  (mb)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Set your resolution";
            // 
            // Java
            // 
            this.Java.BorderRadius = 10;
            this.Java.Controls.Add(this.label1);
            this.Java.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Java.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Java.Location = new System.Drawing.Point(3, 235);
            this.Java.Name = "Java";
            this.Java.Size = new System.Drawing.Size(384, 190);
            this.Java.TabIndex = 2;
            this.Java.Text = "Java";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose java path";
            // 
            // OtherSettings
            // 
            this.OtherSettings.BorderRadius = 10;
            this.OtherSettings.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OtherSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.OtherSettings.Location = new System.Drawing.Point(3, 431);
            this.OtherSettings.Name = "OtherSettings";
            this.OtherSettings.Size = new System.Drawing.Size(384, 127);
            this.OtherSettings.TabIndex = 3;
            this.OtherSettings.Text = "Others";
            // 
            // NewsScreen
            // 
            this.NewsScreen.AllowNavigation = false;
            this.NewsScreen.AllowWebBrowserDrop = false;
            this.NewsScreen.Location = new System.Drawing.Point(12, 12);
            this.NewsScreen.MinimumSize = new System.Drawing.Size(20, 20);
            this.NewsScreen.Name = "NewsScreen";
            this.NewsScreen.Size = new System.Drawing.Size(828, 561);
            this.NewsScreen.TabIndex = 4;
            this.NewsScreen.WebBrowserShortcutsEnabled = false;
            // 
            // pourcentage
            // 
            this.pourcentage.BorderRadius = 10;
            this.pourcentage.Location = new System.Drawing.Point(0, 598);
            this.pourcentage.Name = "pourcentage";
            this.pourcentage.Size = new System.Drawing.Size(1270, 24);
            this.pourcentage.TabIndex = 5;
            this.pourcentage.Text = "guna2ProgressBar1";
            this.pourcentage.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(626, 605);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1201, 605);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // versions
            // 
            this.versions.BackColor = System.Drawing.Color.Transparent;
            this.versions.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.versions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.versions.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.versions.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.versions.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.versions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.versions.ItemHeight = 30;
            this.versions.Items.AddRange(new object[] {
            "1.8.9",
            "1.12.2",
            "1.16.5",
            "1.18.2",
            "1.19.4",
            "1.20.1"});
            this.versions.Location = new System.Drawing.Point(754, 19);
            this.versions.Name = "versions";
            this.versions.Size = new System.Drawing.Size(140, 36);
            this.versions.TabIndex = 5;
            // 
            // Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::MikraftProjet.Properties.Resources._2023_08_03_13_21_50;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pourcentage);
            this.Controls.Add(this.NewsScreen);
            this.Controls.Add(this.InfoMC);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SettingsBox);
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Head)).EndInit();
            this.SettingsBox.ResumeLayout(false);
            this.ScreenResolution.ResumeLayout(false);
            this.ScreenResolution.PerformLayout();
            this.Java.ResumeLayout(false);
            this.Java.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox Head;
        private System.Windows.Forms.Label NameMC;
        private Guna.UI2.WinForms.Guna2Button Game;
        private System.Windows.Forms.Label InfoMC;
        private Guna.UI2.WinForms.Guna2Button Logout;
        private Guna.UI2.WinForms.Guna2GroupBox SettingsBox;
        private Guna.UI2.WinForms.Guna2GroupBox OtherSettings;
        private Guna.UI2.WinForms.Guna2GroupBox Java;
        private Guna.UI2.WinForms.Guna2GroupBox ScreenResolution;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.WebBrowser NewsScreen;
        private Guna.UI2.WinForms.Guna2ComboBox RamCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox ResCombo;
        private Guna.UI2.WinForms.Guna2ProgressBar pourcentage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private EventHandler button2_Click;
        private Guna.UI2.WinForms.Guna2ComboBox versions;
    }
}