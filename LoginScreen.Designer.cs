namespace MikraftProjet
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.XBOXLIVE = new System.Windows.Forms.Button();
            this.Offline = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.guna2ProgressBar1 = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // XBOXLIVE
            // 
            this.XBOXLIVE.BackColor = System.Drawing.Color.Transparent;
            this.XBOXLIVE.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.XBOXLIVE.FlatAppearance.BorderSize = 10;
            this.XBOXLIVE.ForeColor = System.Drawing.Color.Black;
            this.XBOXLIVE.Location = new System.Drawing.Point(257, 359);
            this.XBOXLIVE.Name = "XBOXLIVE";
            this.XBOXLIVE.Size = new System.Drawing.Size(228, 40);
            this.XBOXLIVE.TabIndex = 1;
            this.XBOXLIVE.Text = "Microsoft Login";
            this.XBOXLIVE.UseVisualStyleBackColor = false;
            this.XBOXLIVE.Click += new System.EventHandler(this.XBOXLIVE_Click);
            // 
            // Offline
            // 
            this.Offline.BackColor = System.Drawing.Color.Transparent;
            this.Offline.ForeColor = System.Drawing.Color.Black;
            this.Offline.Location = new System.Drawing.Point(4, 359);
            this.Offline.Name = "Offline";
            this.Offline.Size = new System.Drawing.Size(247, 40);
            this.Offline.TabIndex = 1;
            this.Offline.Text = "Offline Login";
            this.Offline.UseVisualStyleBackColor = false;
            this.Offline.Click += new System.EventHandler(this.Offline_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(238, 203);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(247, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(238, 229);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(247, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(491, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Custom (later)";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // guna2ProgressBar1
            // 
            this.guna2ProgressBar1.Location = new System.Drawing.Point(4, 323);
            this.guna2ProgressBar1.Name = "guna2ProgressBar1";
            this.guna2ProgressBar1.Size = new System.Drawing.Size(713, 30);
            this.guna2ProgressBar1.TabIndex = 5;
            this.guna2ProgressBar1.Text = "guna2ProgressBar1";
            this.guna2ProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ProgressBar1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(720, 404);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2ProgressBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Offline);
            this.Controls.Add(this.XBOXLIVE);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button XBOXLIVE;
        private System.Windows.Forms.Button Offline;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private Guna.UI2.WinForms.Guna2ProgressBar guna2ProgressBar1;
        private System.Windows.Forms.Label label1;
    }
}