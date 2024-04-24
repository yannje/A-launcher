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
using static System.Windows.Forms.Design.AxImporter;
using System.Collections.Generic;
using System.Linq;
using ZipFile = System.IO.Compression.ZipFile;
using Timer = System.Windows.Forms.Timer;
using Control = System.Web.UI.Control;
using System.Net.Http;
using System.Threading.Tasks;

namespace MikraftProjet
{
    public partial class Home : Form

    {
#pragma warning disable CS0169 // Le champ 'Home.lsession' n'est jamais utilisé
        string lsession;
#pragma warning restore CS0169 // Le champ 'Home.lsession' n'est jamais utilisé

        
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

        string yannjefolder = @"multimc\versions\yannje";
        string yannjever = "https://firebasestorage.googleapis.com/v0/b/piochyserv.appspot.com/o/versions%2Fyannje%2Fyannje.zip?alt=media&token=8f03e7ed-1790-4d60-b37d-f9b1ab614c27";
        public static string MojangId { get; set; }
        public object User { get; set; }
        public bool Isclose { get; set; }

        private string username = Login.Username;
        private string uuid = Login.UUID;
        private bool Ispremium = Login.Ispremium;


        //nowel string or smh
        private Timer timerBoulesDeNeige;
        private Random random = new Random();

        // uhhh save thing (doesn't work)
        Dictionary<string, bool> options = new Dictionary<string, bool>();

        public Home()
        {
            InitializeComponent();
            displayInfo();
            label4.Visible = false;
            HomeClose();
            NewsRefresh();
            MessageBox.Show("Optifine 1.20.2, 1.19.4, 1.18.2, 1.16.5, 1.12.2 can't be downlaoded. Iris is the solution");
            Directory.CreateDirectory("Download");
            //nowel code

            ///  timerBoulesDeNeige = new Timer();
            ///timerBoulesDeNeige.Interval = 5000; // Réglage de l'intervalle du Timer (en millisecondes)
            //timerBoulesDeNeige.Tick += TimerBoulesDeNeige_Tick;

            //if (DisableNowel.Checked == true)
            {
               // timerBoulesDeNeige.Stop();
               // Controls.Clear();
            }
            //else
            {
                //timerBoulesDeNeige.Start();
            }
         


        }
        /// <summary>
        /// 
        /// Nowel Time !!!
        /// 
        /// </summary>
        private void TimerBoulesDeNeige_Tick(object sender, EventArgs e)
        {
            //AddBolasDeNowel(boule);
        }

        private bool December()
        {
            return DateTime.Now.Month == 12;
        }

        private void AddBolasDeNowel(BouleDeNeige boule)
        { Home home = new Home();
            int TailleBoule = 20;
            int x = random.Next(home.Width - TailleBoule);
            int y = random.Next(home.Height - TailleBoule);
           // BouleDeNeige boule = new BouleDeNeige(new Point(x, y));
          //  Controls.Add(boule);
        }

        /// <summary>
        /// 
        /// Other things
        /// 
        /// </summary>
        /// 

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
            Head.ImageLocation = @"Resources\head.png"; 
        }

        private void DisplayPlayerHead(object uuid)
        {
           if (Ispremium == true)
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
                   Head.ImageLocation = @"Resources\head2.png";
               }
           }
           
        }
        private void Game_Click(object sender, EventArgs eventArgs)
        {
            LaunchDaGame();
        }

        private void button1_ClickAsync(object sender, EventArgs e)
        {
            Console.Write(@"multimc\versions\OptiFine-" + @"\OptiFine-" + ".json");
            WebClient webClient = new WebClient();

            if (File.Exists(@"multimc\versions\yannje\yannje.zip"))
            {
                MessageBox.Show("You already have it");
            }
            else 
            {
                Directory.CreateDirectory(yannjefolder);
                webClient.DownloadFileAsync(new Uri(yannjever), @"multimc\versions\yannje\yannje.zip");
                webClient.DownloadProgressChanged += WebClient_DownloadProgressChanged;
                webClient.DownloadFileCompleted += WebClient_DownloadFileCompleted;
            } 
        }

        private void WebClient_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Downloaded !, now extracting time !, migth be a litte laggy");
            ZipFile.ExtractToDirectory(@"multimc\versions\yannje\yannje.zip", yannjefolder);
        }

        private void WebClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            pourcentagebar.Value = e.ProgressPercentage;
        }

        static bool EmptyFolder(string yannjefolder)
        {
            return !Directory.EnumerateFileSystemEntries(yannjefolder).Any();
        }


        /// <summary>
        /// Game
        /// </summary>

        private async void LaunchDaGame()
        {

            var session = Ispremium ? new MSession(Login.Username, Login.Token, Login.UUID) : MSession.CreateOfflineSession(Login.Username);

            string selectedVersion = versions.SelectedItem.ToString();
            string selectedloader = loader.SelectedItem.ToString();
            WebClient webClient = new WebClient();

            
            var path = new MinecraftPath("multimc");
            var launcher = new CMLauncher(path);

            string selectedresolution = ResCombo.SelectedItem.ToString();
            string selectedram = RamCombo.SelectedItem.ToString();
            string[] resolutionParts = selectedresolution.Split('x');

            label4.Visible = true;

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
                Session = session,
                GameLauncherName = "wega",
            };

            if (selectedloader== "Forge")
            {
              
                disable();

                var forgev = await forge.Install(selectedVersion);
                var process =  await launcher.CreateProcessAsync(forgev, launchOption);
                if (checkBox1.Checked) 
                {
                    Hide();
                }
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;
                process.EnableRaisingEvents = true;
                process.Exited += new EventHandler(GameProcess_Exited);
                process.Start();
                
            };

            if(selectedloader == "Vanilla")
            {
              
                disable();
                var process = await launcher.CreateProcessAsync(selectedVersion, launchOption);
                if (checkBox1.Checked)
                {
                    Hide();

                }
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.UseShellExecute = false;
                process.EnableRaisingEvents = true;
                process.Exited += new EventHandler(GameProcess_Exited);
                process.Start();
            };

            if(selectedloader == "Optifine")
            {
                disable();

                string[] Zips =
                {
                    "https://github.com/yannje/A-Launcher-File/raw/main/Optifine-Loader/"+selectedVersion+"/OptiFine-"+selectedVersion+".zip"
                };

                string Download = @"Download";

                Task[] telechargements = new Task[Zips.Length];
                using (HttpClient client = new HttpClient())
                {
                    for (int i = 0; i < Zips.Length; i++)
                    {
                        int index = i; // Évite la capture incorrecte de la variable dans la boucle
                        telechargements[i] = TelechargerFichierAsync(client, Zips[index], Download);
                    }

                    // Attendre que tous les téléchargements soient terminés
                    await Task.WhenAll(telechargements);
                };

                if (File.Exists(@"multimc\versions\OptiFine-" + selectedVersion + @"\OptiFine-" + selectedVersion + ".json") == false)
                { 
                    Directory.CreateDirectory(@"multimc\versions\OptiFine-" + selectedVersion);
                    Thread.Sleep(500); // wait 
                    ZipFile.ExtractToDirectory(@"Download\OptiFine-"+selectedVersion+".zip", @"multimc\versions\OptiFine-" + selectedVersion);
                    File.Delete(@"Download\OptiFine-" + selectedVersion + ".zip");
                };
                 
                var process = await launcher.CreateProcessAsync("OptiFine-" + selectedVersion, launchOption);

                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.UseShellExecute = false;
                process.EnableRaisingEvents = true;
                process.Exited += new EventHandler(GameProcess_Exited);
                process.Start();
            };

            if(selectedloader == "Iris")
            {
                disable();

                

                if (File.Exists(@"multimc\versions\Iris-" + selectedVersion + @"\Iris-" + selectedVersion + ".json") == false)
                {
                    string[] Zips =
                    {
                    "https://github.com/yannje/A-Launcher-File/raw/main/Iris-Loader/"+selectedVersion+"/Iris-"+selectedVersion+".zip",
                    "https://github.com/yannje/A-Launcher-File/raw/main/Iris-Loader/"+selectedVersion+"/Iris-Mods-"+selectedVersion+".zip"
                    };

                    string Download = @"Download";

                    Task[] telechargements = new Task[Zips.Length];
                    using (HttpClient client = new HttpClient())
                    {
                        for (int i = 0; i < Zips.Length; i++)
                        {
                            int index = i; // Évite la capture incorrecte de la variable dans la boucle
                            telechargements[i] = TelechargerFichierAsync(client, Zips[index], Download);
                        }

                        // Attendre que tous les téléchargements soient terminés
                        await Task.WhenAll(telechargements);
                    };

                    ZipFile.ExtractToDirectory(@"Download\Iris-"+selectedVersion+".zip", @"multimc\versions\Iris-" + selectedVersion);
                    ZipFile.ExtractToDirectory(@"Download\Iris-Mods-" + selectedVersion + ".zip", @"multimc\iris-reserved\"+selectedVersion);

                    File.Delete(@"Download\Iris-" + selectedVersion + ".zip");
                    File.Delete(@"Download\Iris-Mods-" + selectedVersion + ".zip");
                };
                    
                var process = await launcher.CreateProcessAsync("Iris-" + selectedVersion, launchOption);

                    process.StartInfo.CreateNoWindow = true;
                    process.StartInfo.UseShellExecute = false;
                    process.EnableRaisingEvents = true;
                    process.Exited += new EventHandler(GameProcess_Exited);
                    process.Start();
                
                    
            };
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        private void disable()
        {
            Logout.Enabled = false;
            Game.Enabled = false;
        }
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
            pourcentagebar.Value = e.ProgressPercentage;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////


        /// <summary>
        /// Other
        /// </summary

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            JELoginHandlerBuilder.BuildDefault();
            MessageBox.Show("You have been logout from the account. Redireting to the login panel");

            Hide();
            Login login = new Login();
            login.Show();
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
            };

            if (checkBox2.Checked == true)
            {
                options["HideNews"] = true; // Mettez à jour l'option

            };
            if (checkBox2.Checked == false)
            {
                options["HideNews"] = false; // Mettez à jour l'option

            };

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBox.Show("cool");
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

        private async Task TelechargerFichierAsync(HttpClient client, string url, string dossierDestination)
        {
            
            label4.Visible = true;
            string nomFichier = Path.GetFileName(url);
            string cheminDestination = Path.Combine(dossierDestination, nomFichier);

            label4.Text = $"Téléchargement de {nomFichier}...";

            try
            {
                using (var response = await client.GetAsync(url, HttpCompletionOption.ResponseHeadersRead))
                {
                    response.EnsureSuccessStatusCode();

                    // Taille totale du fichier (en octets)
                    long tailleTotale = response.Content.Headers.ContentLength ?? -1;
                    long octetsTelecharges = 0;

                    using (var stream = await response.Content.ReadAsStreamAsync())
                    using (var fichier = File.Create(cheminDestination))
                    {
                        byte[] tampon = new byte[8192];
                        int octetsLus;
                        while ((octetsLus = await stream.ReadAsync(tampon, 0, tampon.Length)) > 0)
                        {
                            await fichier.WriteAsync(tampon, 0, octetsLus);
                            octetsTelecharges += octetsLus;

                            // Calculer le pourcentage et l'afficher
                            int pourcentage = (int)((double)octetsTelecharges / tailleTotale * 100);
                            pourcentagebar.Value = pourcentage;
                            label4.Text =$"Téléchargement de {nomFichier} : {pourcentage}%";
                            Application.DoEvents();
                        }
                    }
                }
                label4.Text = $"Téléchargement de {nomFichier} terminé.";

                Console.WriteLine($"Téléchargement de {url} : {nomFichier} terminé.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors du téléchargement de {nomFichier} : {ex.Message}");
            }
        }
    }



    // class thing 
    public class BouleDeNeige : Control
    {
        public Point Position { get; set; }

        public BouleDeNeige(Point position)
        {
            Position = position;
        }

        public void Deplacer()
        {
            Position = new Point(Position.X, Position.Y + 5); // Ajustez la vitesse de déplacement ici
        }
    }
}


// woah 574