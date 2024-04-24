using CmlLib.Core.Auth.Microsoft;
using System;
using System.Windows.Forms;
using AutoUpdaterDotNET;

namespace MikraftProjet
{
    public partial class Login : Form
    {
        string VersionFile = "https://raw.githubusercontent.com/yannje/A-Launcher-File/main/version.xml";

        public static string Username { get; set; }
        public static string UUID { get; set; }
        public static string Token{ get; set; }
        public static bool Ispremium;

        public Login()
        {
            InitializeComponent();
            AutoUpdater.Start(VersionFile);
        }
        private async void XBOXLIVE_Click(object sender, EventArgs e)
        {
            var loginHandler = JELoginHandlerBuilder.BuildDefault();
            var session = await loginHandler.Authenticate();

            Username = session.Username;
            UUID = session.UUID;
            Token = session.AccessToken;

            Ispremium = true;
            Home home = new Home();
            home.Show();
            Hide();

        }

        private void Offline_Click(object sender, EventArgs e)
        {
            textBox1.Show();
            string username = textBox1.Text;


            if (!string.IsNullOrEmpty(username))
            {
                Username = username;

                Home home = new Home();
                home.Show();
                Hide();
            }
        }
        
    }
}
