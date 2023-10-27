using CmlLib.Core;
using CmlLib.Core.Auth;
using CmlLib.Core.Auth.Microsoft;
using CmlLib.Core.Mojang;
using System;
using System.Windows.Forms;

namespace MikraftProjet
{
    public partial class Login : Form
    {

        public static string Username { get; set; }
        public static string UUID { get; set; }
        public static string Token{ get; set; }
        public static bool Ispremium;
        public Login()
        {
            InitializeComponent();
        }
        private async void XBOXLIVE_Click(object sender, System.EventArgs e)
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

        private void Offline_Click(object sender, System.EventArgs e)
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
