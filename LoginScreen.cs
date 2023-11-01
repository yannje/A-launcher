using CmlLib.Core.Auth.Microsoft;
using System;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Diagnostics;
using AutoUpdaterDotNET;

namespace MikraftProjet
{
    public partial class Login : Form
    {
#pragma warning disable CS0414 // Le champ 'Login.versionA' est assigné, mais sa valeur n'est jamais utilisée
        string versionA = "0.0.4";
#pragma warning restore CS0414 // Le champ 'Login.versionA' est assigné, mais sa valeur n'est jamais utilisée
        string VersionFile = "https://github.com/yannje/A-launcher/raw/main/update.xml";

        public static string Username { get; set; }
        public static string UUID { get; set; }
        public static string Token{ get; set; }
        public static bool Ispremium;
        WebClient webClient = new WebClient();

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
