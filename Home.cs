using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using CmlLib.Core;
using CmlLib.Core.Auth;
using CmlLib.Core.Auth.Microsoft;
using Newtonsoft.Json;
using static System.Collections.Specialized.BitVector32;
using System.IO.Compression;
using System.Threading.Tasks;
using System.Security.Policy;
using System.Net.Mail;
using System.Text;
using System.Web.UI.HtmlControls;

namespace MikraftProjet
{
    public partial class Home : Form

    {
        string lsession;


        string ModsDl = "https://firebasestorage.googleapis.com/v0/b/piochyserv.appspot.com/o/yannje.zip?alt=media&token=28d72efb-c3f9-4f41-89a7-f3a910ce4d68";
        private string GetPlayerUUID(string username)
        {
            string apiUrl = $"https://api.mojang.com/users/profiles/minecraft/{username}";
            using (WebClient wc = new WebClient())
            {
                string json = wc.DownloadString(apiUrl);
                dynamic data = JsonConvert.DeserializeObject(json);
                return data?.id;
            }
        }


        public static string MojangId { get; set; }
        public object User { get; set; }
        public bool Isclose { get; set; }

        private string username = Login.Username;
        private string uuid = Login.UUID;
        private bool Ispremium = Login.Ispremium;

        public Home()
        {
            InitializeComponent();
            displayInfo();
            label4.Visible = false;
        }

        private void HomeClose()
        {
            Home home = new Home();
            home.FormClosed += Home_FormClosed;
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Isclose = true;
        }

        private void displayInfo()
        {
            NameMC.Text = username;

            if (!string.IsNullOrEmpty(uuid))
            {
                DisplayPlayerHead(uuid);
            }
            else
            {
                displayDefaultHead();
            }
        }

        private void displayDefaultHead()
        {
            Head.ImageLocation = @"Resources\steve.png"; 
        }

        private void DisplayPlayerHead(object uuid)
        {
           
            if (File.Exists(@"Resources\head2.png"))
            {
                Head.ImageLocation = @"Resources\head2.png";
            }
            else
            {
                WebClient webClient = new WebClient();
                string avatarUrl = $"https://crafatar.com/avatars/{uuid}";

                webClient.DownloadFile(avatarUrl, @"Resources\head.png");

                using (var originalImage = Image.FromFile(@"Resources\head.png"))
                {
                    using (var resizedImage = new Bitmap(48, 48))
                    using (var graphics = Graphics.FromImage(resizedImage))
                    {
                        graphics.DrawImage(originalImage, 0, 0, 48, 48);
                        resizedImage.Save(@"Resources\head2.png");
                    }
                }
                File.Delete(@"Resources\head.png");
                Head.ImageLocation = @"Resources\head2.png";
            }
        }

        private void Game_Click(object sender, EventArgs eventArgs)
        { 
            if(Ispremium == true)
            {
                LaunchDaGame();
            }
            else
            {
                LaunchDaGameCrack();
            }    
        }

        /// <summary>
        /// Game
        /// </summary>
        
        private async void LaunchDaGame()
        {

            string selectedVersion = versions.SelectedItem.ToString();
            WebClient webClient = new WebClient();

            
            var path = new MinecraftPath("multimc");
            var launcher = new CMLauncher(path);

            string selectedresolution = ResCombo.SelectedItem.ToString();
            string selectedram = RamCombo.SelectedItem.ToString();

            string[] resolutionParts = selectedresolution.Split('x');
            int width = int.Parse(resolutionParts[0]);
            int height = int.Parse(resolutionParts[1]);
            int ram = int.Parse(selectedram);

            launcher.FileChanged += Launcher_FileChanged;



            launcher.ProgressChanged += (s, e) =>
            {
                label5.Visible = true;
                pourcentage.Value = e.ProgressPercentage;
                label5.Text = string.Format("{0}", e.ProgressPercentage / 1024d / 1024).ToString();
            };


            var launchOption = new MLaunchOption
            {
                MaximumRamMb = ram,
                ScreenWidth = width,
                ScreenHeight = height,
                Session = new MSession(Login.Username, Login.Token, Login.UUID),
                GameLauncherName = "launcher",
            };

            Logout.Enabled = false;
            Game.Enabled = false;
            var process = await launcher.CreateProcessAsync(selectedVersion, launchOption);
            process.EnableRaisingEvents = true;
            process.Exited += new EventHandler(GameProcess_Exited);
            process.Start();
           
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void GameProcess_Exited(object sender, EventArgs e)
        {

            this.Invoke((MethodInvoker)delegate
            {
                Game.Enabled = true;
                Logout.Enabled = true;
            });
        }
        private void Launcher_FileChanged(CmlLib.Core.Downloader.DownloadFileChangedEventArgs e)
        {
            label4.Visible = true;
            label4.Text = string.Format("file : "+ e.FileName+"   "+e.ProgressedFileCount+"/"+e.TotalFileCount);
           
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        private async void LaunchDaGameCrack()
        {
            string selectedVersion = versions.SelectedItem.ToString();
            WebClient webClient = new WebClient();


            var path = new MinecraftPath("multimc");
            var launcher = new CMLauncher(path);

            string selectedresolution = ResCombo.SelectedItem.ToString();
            string selectedram = RamCombo.SelectedItem.ToString();

            string[] resolutionParts = selectedresolution.Split('x');
            int width = int.Parse(resolutionParts[0]);
            int height = int.Parse(resolutionParts[1]);
            int ram = int.Parse(selectedram);

            launcher.FileChanged += Launcher_FileChanged;



            launcher.ProgressChanged += (s, e) =>
            {
                label5.Visible = true;
                pourcentage.Value = e.ProgressPercentage;
                label5.Text = string.Format("0.00", e.UserState).ToString();
            };


            var launchOption = new MLaunchOption
            {
                MaximumRamMb = ram,
                ScreenWidth = width,
                ScreenHeight = height,
                Session = MSession.GetOfflineSession(username),
                GameLauncherName = "launcher",
            };

            Logout.Enabled = false;
            Game.Enabled = false;
            var process = await launcher.CreateProcessAsync(selectedVersion, launchOption);
            process.EnableRaisingEvents = true;
            process.Exited += new EventHandler(GameProcess_Exited);
            process.Start();

        }

        /// <summary>
        /// Other
        /// </summary

        private void WebClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            pourcentage.Value = e.ProgressPercentage;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var loginHandler = JELoginHandlerBuilder.BuildDefault();
            var session = loginHandler.Signout();
            MessageBox.Show("You have been logout from the account. Redireting to the login panel");

            Hide();
            Login login = new Login();
            login.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            Console.Write("loaded");
        }


        //settings will be go brrr with this fire code


    }
}
