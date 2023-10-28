using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using CmlLib.Core;
using CmlLib.Core.Auth;
using CmlLib.Core.Auth.Microsoft;
using Newtonsoft.Json;
using CmlLib.Core.Installer.FabricMC;
using System.Threading;

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
            HomeClose();
            NewsRefresh();
        }

        private void HomeClose()
        {
           FormClosed += Home_FormClosed;
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        { 
            Login login = new Login();
                
            if (login != null && !login.IsDisposed)
            {
                login.Close();
            }
            Application.Exit();

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
            string selectedloader = loader.SelectedItem.ToString();
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
            launcher.ProgressChanged += launcher_ProgressChanged;

            var forge = new CmlLib.Core.Installer.Forge.MForge(launcher);

            var fabricVersionLoader = new FabricVersionLoader();
            var fabricVersions = await fabricVersionLoader.GetVersionMetadatasAsync();


            var launchOption = new MLaunchOption
            {
                MaximumRamMb = ram,
                ScreenWidth = width,
                ScreenHeight = height,
                Session = new MSession(Login.Username, Login.Token, Login.UUID),
                GameLauncherName = "wega",
            };

            if(selectedloader== "Forge")
            {
                
                Logout.Enabled = false;
                Game.Enabled = false;

                var forgev = await forge.Install(selectedVersion);
                var process =  await launcher.CreateProcessAsync(forgev, launchOption);
                if (checkBox1.Checked) 
                {
                    Hide();
                }
                process.EnableRaisingEvents = true;
                process.Exited += new EventHandler(GameProcess_Exited);
                process.Start();

                
            };

            if (selectedloader == "Fabric")
            {

                var fabricVersionName = "fabric-loader-0.14.24-"+selectedVersion;

                Logout.Enabled = false;
                Game.Enabled = false;

                var process = await launcher.CreateProcessAsync(fabricVersionName, launchOption);
                if (checkBox1.Checked)
                {
                    Hide();
                }
                process.EnableRaisingEvents = true;
                process.Exited += new EventHandler(GameProcess_Exited);
                process.Start();
            };

            if(selectedloader == "Vanilla")
            {
                Logout.Enabled = false;
                Game.Enabled = false;
                var process = await launcher.CreateProcessAsync(selectedVersion, launchOption);
                if (checkBox1.Checked)
                {
                    Hide();
                }
                process.EnableRaisingEvents = true;
                process.Exited += new EventHandler(GameProcess_Exited);
                process.Start();
            };

        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void GameProcess_Exited(object sender, EventArgs e)
        {

            Invoke((MethodInvoker)delegate
            {
                Game.Enabled = true;
                Logout.Enabled = true;
                if (checkBox1.Checked)
                {
                    Show();
                }

                if (checkBox3.Checked)
                {
                    Application.Exit();
                };
            });
        }
        private void Launcher_FileChanged(CmlLib.Core.Downloader.DownloadFileChangedEventArgs e)
        {
            label4.Visible = true;
            label4.Text = string.Format("file : "+ e.FileName+"   "+e.ProgressedFileCount+"/"+e.TotalFileCount);
           
        }
        private void launcher_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            pourcentage.Value = e.ProgressPercentage;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        private async void LaunchDaGameCrack()
        {
            string selectedVersion = versions.SelectedItem.ToString();
            string selectedloader = loader.SelectedItem.ToString();
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
                pourcentage.Value = e.ProgressPercentage;
            };

            var forge = new CmlLib.Core.Installer.Forge.MForge(launcher);
            var fabricVersionLoader = new FabricVersionLoader();
            var fabricVersions = await fabricVersionLoader.GetVersionMetadatasAsync();


            var launchOption = new MLaunchOption
            {
                MaximumRamMb = ram,
                ScreenWidth = width,
                ScreenHeight = height,
                Session = MSession.CreateOfflineSession(username),
                GameLauncherName = "launcher",
            };

            if (selectedloader == "Forge")
            {

                Logout.Enabled = false;
                Game.Enabled = false;

                var forgev = await forge.Install(selectedVersion);
                var process = await launcher.CreateProcessAsync(forgev, launchOption);
                if (checkBox1.Checked)
                {
                    Hide();
                }
                process.EnableRaisingEvents = true;
                process.Exited += new EventHandler(GameProcess_Exited);
                process.Start();


            };

            if (selectedloader == "Fabric")
            {

                var fabricVersionName = "fabric-loader-0.14.24-" + selectedVersion;

                Logout.Enabled = false;
                Game.Enabled = false;

                var process = await launcher.CreateProcessAsync(fabricVersionName, launchOption);
                if (checkBox1.Checked)
                {
                    Hide();
                }
                process.EnableRaisingEvents = true;
                process.Exited += new EventHandler(GameProcess_Exited);
                process.Start();
            };

            if (selectedloader == "Vanilla")
            {
                Logout.Enabled = false;
                Game.Enabled = false;
                var process = await launcher.CreateProcessAsync(selectedVersion, launchOption);
                if (checkBox1.Checked)
                {
                    Hide();
                }
                process.EnableRaisingEvents = true;
                process.Exited += new EventHandler(GameProcess_Exited);
                process.Start();
            };
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
            JELoginHandlerBuilder.BuildDefault();
            MessageBox.Show("You have been logout from the account. Redireting to the login panel");

            Hide();
            Login login = new Login();
            login.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            Console.Write("loaded");

        }

        private void NewsRefresh()
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

            timer.Interval = 120000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            NewsScreen.Refresh();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                NewsScreen.Hide();
            };

            if (checkBox2.Checked == false)
            {
                NewsScreen.Show();
            }
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBox.Show("cool");
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (language.SelectedIndex)
            {
                case 0:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
                    break;
                case 1:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("fr");
                    language.SelectedIndex = 1;
                    break;
            }
            Controls.Clear();
            InitializeComponent();
        }
    }
}
