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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.loader = new Guna.UI2.WinForms.Guna2ComboBox();
            this.versions = new Guna.UI2.WinForms.Guna2ComboBox();
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
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.language = new Guna.UI2.WinForms.Guna2ComboBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.NewsScreen = new System.Windows.Forms.WebBrowser();
            this.pourcentage = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Head)).BeginInit();
            this.SettingsBox.SuspendLayout();
            this.ScreenResolution.SuspendLayout();
            this.Java.SuspendLayout();
            this.OtherSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.loader);
            this.groupBox1.Controls.Add(this.versions);
            this.groupBox1.Controls.Add(this.Logout);
            this.groupBox1.Controls.Add(this.Game);
            this.groupBox1.Controls.Add(this.NameMC);
            this.groupBox1.Controls.Add(this.Head);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // loader
            // 
            this.loader.AutoRoundedCorners = true;
            this.loader.BackColor = System.Drawing.Color.Transparent;
            this.loader.BorderRadius = 17;
            this.loader.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.loader.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.loader.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.loader.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.loader.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.loader, "loader");
            this.loader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.loader.Items.AddRange(new object[] {
            resources.GetString("loader.Items"),
            resources.GetString("loader.Items1"),
            resources.GetString("loader.Items2")});
            this.loader.Name = "loader";
            this.loader.StartIndex = 0;
            // 
            // versions
            // 
            this.versions.AutoRoundedCorners = true;
            this.versions.BackColor = System.Drawing.Color.Transparent;
            this.versions.BorderRadius = 17;
            this.versions.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.versions.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.versions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.versions.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.versions.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.versions, "versions");
            this.versions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.versions.Items.AddRange(new object[] {
            resources.GetString("versions.Items"),
            resources.GetString("versions.Items1"),
            resources.GetString("versions.Items2"),
            resources.GetString("versions.Items3"),
            resources.GetString("versions.Items4"),
            resources.GetString("versions.Items5"),
            resources.GetString("versions.Items6")});
            this.versions.Name = "versions";
            this.versions.StartIndex = 6;
            // 
            // Logout
            // 
            this.Logout.BorderRadius = 10;
            this.Logout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Logout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Logout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Logout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Logout.FillColor = System.Drawing.Color.White;
            resources.ApplyResources(this.Logout, "Logout");
            this.Logout.ForeColor = System.Drawing.Color.Black;
            this.Logout.Name = "Logout";
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
            resources.ApplyResources(this.Game, "Game");
            this.Game.ForeColor = System.Drawing.Color.Black;
            this.Game.Name = "Game";
            this.Game.Click += new System.EventHandler(this.Game_Click);
            // 
            // NameMC
            // 
            resources.ApplyResources(this.NameMC, "NameMC");
            this.NameMC.Name = "NameMC";
            // 
            // Head
            // 
            resources.ApplyResources(this.Head, "Head");
            this.Head.Name = "Head";
            this.Head.TabStop = false;
            // 
            // InfoMC
            // 
            resources.ApplyResources(this.InfoMC, "InfoMC");
            this.InfoMC.Name = "InfoMC";
            // 
            // SettingsBox
            // 
            this.SettingsBox.BackColor = System.Drawing.Color.Transparent;
            this.SettingsBox.BorderRadius = 10;
            this.SettingsBox.Controls.Add(this.ScreenResolution);
            this.SettingsBox.Controls.Add(this.Java);
            this.SettingsBox.Controls.Add(this.OtherSettings);
            this.SettingsBox.FillColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.SettingsBox, "SettingsBox");
            this.SettingsBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.SettingsBox.Name = "SettingsBox";
            // 
            // ScreenResolution
            // 
            this.ScreenResolution.BorderRadius = 10;
            this.ScreenResolution.Controls.Add(this.ResCombo);
            this.ScreenResolution.Controls.Add(this.RamCombo);
            this.ScreenResolution.Controls.Add(this.label3);
            this.ScreenResolution.Controls.Add(this.label2);
            resources.ApplyResources(this.ScreenResolution, "ScreenResolution");
            this.ScreenResolution.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ScreenResolution.Name = "ScreenResolution";
            // 
            // ResCombo
            // 
            this.ResCombo.BackColor = System.Drawing.Color.Transparent;
            this.ResCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ResCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ResCombo.FillColor = System.Drawing.Color.Silver;
            this.ResCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ResCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.ResCombo, "ResCombo");
            this.ResCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ResCombo.Items.AddRange(new object[] {
            resources.GetString("ResCombo.Items"),
            resources.GetString("ResCombo.Items1"),
            resources.GetString("ResCombo.Items2"),
            resources.GetString("ResCombo.Items3")});
            this.ResCombo.Name = "ResCombo";
            this.ResCombo.StartIndex = 1;
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
            resources.ApplyResources(this.RamCombo, "RamCombo");
            this.RamCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.RamCombo.Items.AddRange(new object[] {
            resources.GetString("RamCombo.Items"),
            resources.GetString("RamCombo.Items1"),
            resources.GetString("RamCombo.Items2"),
            resources.GetString("RamCombo.Items3"),
            resources.GetString("RamCombo.Items4"),
            resources.GetString("RamCombo.Items5")});
            this.RamCombo.Name = "RamCombo";
            this.RamCombo.StartIndex = 1;
            this.RamCombo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RamCombo.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // Java
            // 
            this.Java.BorderRadius = 10;
            this.Java.Controls.Add(this.guna2Button1);
            this.Java.Controls.Add(this.label5);
            this.Java.Controls.Add(this.label1);
            resources.ApplyResources(this.Java, "Java");
            this.Java.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Java.Name = "Java";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // OtherSettings
            // 
            this.OtherSettings.BorderRadius = 10;
            this.OtherSettings.Controls.Add(this.checkBox3);
            this.OtherSettings.Controls.Add(this.language);
            this.OtherSettings.Controls.Add(this.checkBox2);
            this.OtherSettings.Controls.Add(this.checkBox1);
            resources.ApplyResources(this.OtherSettings, "OtherSettings");
            this.OtherSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.OtherSettings.Name = "OtherSettings";
            // 
            // checkBox3
            // 
            resources.ApplyResources(this.checkBox3, "checkBox3");
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // language
            // 
            this.language.AutoRoundedCorners = true;
            this.language.BackColor = System.Drawing.Color.Transparent;
            this.language.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.language.BorderRadius = 17;
            this.language.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.language.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.language.FillColor = System.Drawing.Color.Silver;
            this.language.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.language.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.language, "language");
            this.language.ForeColor = System.Drawing.Color.Black;
            this.language.Items.AddRange(new object[] {
            resources.GetString("language.Items"),
            resources.GetString("language.Items1")});
            this.language.Name = "language";
            this.language.StartIndex = 0;
            this.language.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // checkBox2
            // 
            resources.ApplyResources(this.checkBox2, "checkBox2");
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // NewsScreen
            // 
            this.NewsScreen.AllowNavigation = false;
            this.NewsScreen.AllowWebBrowserDrop = false;
            resources.ApplyResources(this.NewsScreen, "NewsScreen");
            this.NewsScreen.Name = "NewsScreen";
            this.NewsScreen.ScriptErrorsSuppressed = true;
            this.NewsScreen.Url = new System.Uri("http://swagshitmoney.rf.gd/", System.UriKind.Absolute);
            this.NewsScreen.WebBrowserShortcutsEnabled = false;
            // 
            // pourcentage
            // 
            this.pourcentage.BorderRadius = 10;
            resources.ApplyResources(this.pourcentage, "pourcentage");
            this.pourcentage.Name = "pourcentage";
            this.pourcentage.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Java";
            resources.ApplyResources(this.openFileDialog1, "openFileDialog1");
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.guna2Button1, "guna2Button1");
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::MikraftProjet.Properties.Resources._2023_08_03_13_21_50;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pourcentage);
            this.Controls.Add(this.NewsScreen);
            this.Controls.Add(this.InfoMC);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SettingsBox);
            this.MaximizeBox = false;
            this.Name = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Head)).EndInit();
            this.SettingsBox.ResumeLayout(false);
            this.ScreenResolution.ResumeLayout(false);
            this.ScreenResolution.PerformLayout();
            this.Java.ResumeLayout(false);
            this.Java.PerformLayout();
            this.OtherSettings.ResumeLayout(false);
            this.OtherSettings.PerformLayout();
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
        private EventHandler button2_Click;
        private Guna.UI2.WinForms.Guna2ComboBox versions;
        private Guna.UI2.WinForms.Guna2ComboBox loader;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private Guna.UI2.WinForms.Guna2ComboBox language;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label5;
    }
}