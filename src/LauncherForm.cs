/* LAUNCHER PARA FIVEM GTA RP
 * DESENVOLVIDO POR: BigBangDBIKE#7340
 * OPEN SOURCED?
 * A vida é uma caixinha de surpresas...
 */
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Launcher_FiveM_CS
{
    public partial class LauncherForm : Form
    {
        public ServerList ServerList { get; set;}
        public string local_app;
        public ServerCfg srvSelected { get; set; }
        public LauncherForm()
        {
            InitializeComponent();
            this.local_app = Environment.GetEnvironmentVariable("LocalAppData") + "/FiveM/";
            this.LoadingBar.Maximum = 100;

            this.Btn_FiveM.FlatAppearance.MouseOverBackColor = this.Btn_FiveM.BackColor;
            this.Btn_FiveM.BackColorChanged += (s, e) => {
                this.Btn_FiveM.FlatAppearance.MouseOverBackColor = this.Btn_FiveM.BackColor;
            };
            this.Btn_TS3.FlatAppearance.MouseOverBackColor = this.Btn_TS3.BackColor;
            this.Btn_TS3.BackColorChanged += (s, e) => {
                this.Btn_TS3.FlatAppearance.MouseOverBackColor = this.Btn_TS3.BackColor;
            };
        }

        private void LauncherForm_Load(object sender, EventArgs e)
        {
            //Resetting vars
            this.LoadingBar.Value = 0;
            this.Text_Log.Text = "";
            this.Text_Log.Refresh();
            this.Combo_ListServers.Items.Clear();

            //Get config settings file and set to class var
            var ConfigHelper = new ConfigHelper();
            ConfigHelper.GetContent();
            this.ServerList = ConfigHelper.GetContent();

            //Get AboutApp class
            var AboutApp = new AboutApp();
            var version_cfg = (this.ServerList.version_saved != "") ? "v" + this.ServerList.version_saved : "v0";
            this.SetLog("Launcher v"+ AboutApp.version+ " | Config "+ version_cfg);
            if (AboutApp.version != this.ServerList.version_saved)
            { //Config Version it's different of app
                this.SetLog("A versão do arquivo de configuração está desatualizada! Salve uma nova configuração para evitar problemas.");
            }
            else
            { //Add servers to the list
                if (this.ServerList.ServerCfgs.Count > 0)
                {
                    int fav_index = 0;
                    for (int i = 0; i < this.ServerList.ServerCfgs.Count; i++)
                    {
                        this.Combo_ListServers.Items.Add(this.ServerList.ServerCfgs[i].Name);
                        if (this.ServerList.ServerCfgs[i].Fav)
                        {
                            fav_index = i;
                        }
                    }
                    this.Combo_ListServers.SelectedIndex = fav_index;
                    this.SetLog("Tudo pronto!");

                }
                else
                {//No servers saved
                    this.SetLog("Nenhum servidor foi configurado! Clique em Configurações para adicionar");
                }
            }
        }

        public async void SetLoadingBarVal(int val)
        {

            this.LoadingBar.Value = val;
            await Task.Delay(200);
        }

        public void ChangeLoadingBarLbl(string str)
        {
            Lbl_LoadingBar.Text = str;
            Lbl_LoadingBar.Refresh();
        }
        public async void SetLoadingBar(int add_val)
        {
            SetLoadingBarVal(add_val);
            this.LoadingBar.Value = add_val;
            ChangeLoadingBarLbl("Carregando... " + add_val + "%");
            await Task.Delay(200);
        }
        public async void ResetLoadingBar()
        {
            SetLoadingBarVal(0);
            this.LoadingBar.Value = 0;
            ChangeLoadingBarLbl("...");
            await Task.Delay(200);
        }
        private async void Btn_Play_Click(object sender, EventArgs e)
        {
            this.TopMost = true;
            SetLoadingBar(1);
            await Task.Delay(500);
            int idx_combo = this.Combo_ListServers.SelectedIndex;
            if (idx_combo != -1)
            {
                SetLoadingBar(20);
                this.SetLog("Iniciando o jogo...");
                await Task.Delay(800);
                var ServerData = this.ServerList.ServerCfgs[idx_combo];
                if (ServerData.IP == "")
                {
                    this.SetLog("O IP do servidor não é válido! Vá em Configurações para alterar o IP.");
                    this.TopMost = false;
                    ResetLoadingBar();
                }
                else if (ServerData.Use_TS3 == true && ServerData.IP_TS3 == "")
                {
                    this.SetLog("O IP do servidor do TeamSpeak 3 não é valido! Vá em Configurações para alterar o IP.");
                    this.TopMost = false;
                    ResetLoadingBar();
                }
                else
                {
                    SetLoadingBar(49);
                    await this.clearCacheApp(true);

                    SetLoadingBar(80);

                    await this.OpenFiveM(sender, e);
                    await Task.Delay(2000);

                    if (ServerData.Use_TS3 == true)
                    {
                        SetLoadingBar(90);
                        this.OpenTS3(sender, e);
                    }
                    SetLoadingBar(100);
                    await Task.Delay(1000);

                    this.SetLog("Bom jogo!");
                    ChangeLoadingBarLbl("Concluído!");

                    await Task.Delay(3000);
                    Application.Exit();
                }
            }
            else
            {
                if (this.Combo_ListServers.Items.Count > 0)
                {
                    this.SetLog("Selecione um servidor para iniciar o jogo!");
                }
                else
                {
                    this.SetLog("Nenhum servidor foi configurado! Clique em Configurações para adicionar");
                }
            }
        }
        private void OpenSteam(object sender, EventArgs e)
        {
            this.SetLog("Abrindo a Steam...");
            System.Diagnostics.Process.Start("steam://open");
        }
        private async void OpenFiveMSingle(object sender, EventArgs e)
        {
            await this.OpenFiveM(sender, e);
        }
        private async Task<int> OpenFiveM(object sender, EventArgs e)
        {
            int return_val = 0;
            if (this.srvSelected != null)
            {
                this.OpenSteam(sender, e);
                await Task.Delay(2000);
                this.SetLog("Abrindo o FiveM (" + this.srvSelected.IP + ")...");
                //Start CMD.exe and pass arguments to execute Fivem.exe with connect param
                //var cmd = new System.Diagnostics.Process();
                //cmd.StartInfo.FileName = "cmd.exe";
                //cmd.StartInfo.RedirectStandardInput = true;
                //cmd.StartInfo.RedirectStandardOutput = true;
                //cmd.StartInfo.CreateNoWindow = false;
                //cmd.StartInfo.UseShellExecute = false;
                //cmd.Start();
                //if (this.local_app.Substring(0, 3) != @"E:\")
                //{
                //    cmd.StandardInput.WriteLine(this.local_app.Substring(0, 2));
                //}
                //cmd.StandardInput.WriteLine("cd " + this.local_app);
                //cmd.StandardInput.WriteLine(@".\FiveM.exe +connect " + this.srvSelected.IP);
                //cmd.StandardInput.Flush();
                //cmd.StandardInput.Close();
                //cmd.WaitForExit();


                System.Diagnostics.Process.Start("fivem://connect/" + this.srvSelected.IP);
                return_val = 1;
            }
            return return_val;
        }
        private void OpenTS3(object sender, EventArgs e)
        {
            if (this.srvSelected != null
                && this.srvSelected.Use_TS3 == true)
            {
                this.SetLog("Abrindo o TS3 (" + this.srvSelected.IP_TS3 + ")...");
                System.Diagnostics.Process.Start("ts3server://" + this.srvSelected.IP_TS3 + "/?nickname=LauncherDBIKE&password=" +this.srvSelected.Pass_TS3);
            }
        }

        private void Btn_ExitApp_Click(object sender, EventArgs e)
        {
            this.SetLog("Fechando o Launcher...");
            Application.Exit();
        }

        private void Btn_Cfg_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConfigForm ConfigForm = new ConfigForm();
            ConfigForm.Show();
        }
        public void SetLog(string content)
        {
            string new_content = "";
            if(this.Text_Log.Text != "")
            {
                new_content += "\r\n";
            }
            var dateNow = DateTime.Now.ToString("HH:mm:ss");
            new_content += "[" + dateNow + "] " + content;
            this.Text_Log.AppendText(new_content);
            this.Text_Log.Refresh();
        }

        private async void Btn_ClrCache_Click(object sender, EventArgs e)
        {
            await clearCacheApp();
        }

        private async Task clearCacheApp(bool load_bar = false)
        {
            this.SetLog("Limpando o cache...");
            await Task.Delay(500);

            string cache_dir = this.local_app + "FiveM.app/cache/";
            var dirs_cache = Directory.GetDirectories(cache_dir);
            var files_cache = Directory.GetFiles(cache_dir);

            int total_files = dirs_cache.Length + files_cache.Length;
            var per_progress = 21 / total_files;


            foreach (string path in dirs_cache)
            {
                if (!path.Contains("cache/game"))
                {
                    this.SetLog("Limpando cache: " + path.Replace(this.local_app + "FiveM.app/", ""));
                    if (load_bar == true)
                    {
                        var new_val = LoadingBar.Value + per_progress;
                        SetLoadingBar(new_val);
                    }
                    await Task.Delay(100);
                    Directory.Delete(path, true);
                }
            }

            foreach (string path in files_cache)
            {
                if (!path.Contains("cache/game"))
                {
                    this.SetLog("Limpando cache: " + path.Replace(this.local_app + "FiveM.app/", ""));
                    if (load_bar == true)
                    {
                        var new_val = LoadingBar.Value + per_progress;
                        SetLoadingBar(new_val);
                    }
                    await Task.Delay(100);
                    File.Delete(path);
                }
            }
            this.SetLog("Cache limpo com sucesso!");
            await Task.Delay(500);
        }

        private void Btn_About_Click(object sender, EventArgs e)
        {
            var msg = "";
            msg += "Versão: " + AboutApp.version;
            msg += "\nAuthor: " + AboutApp.authors;
            msg += "\nRelease Date: " + AboutApp.release_date;
            msg += "\n\nWindows 10 Support only!";

            MessageBox.Show(msg, "Sobre", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void Combo_ListServers_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idx_combo = this.Combo_ListServers.SelectedIndex;
            if (idx_combo != -1)
            {
                this.srvSelected = this.ServerList.ServerCfgs[idx_combo];
                this.PlayersOnline.Text = "Players Online: Carregando...";
                this.PlayersOnline.Refresh();

                var intPlayersOn = await Utils.CheckIP_FiveM(this.srvSelected.IP);
                if (intPlayersOn[0].ToString() == "-1")
                {
                    this.PlayersOnline.Text = "Players Online: 0 (Erro)";
                }
                else
                {
                    this.PlayersOnline.Text = "Players Online: "+intPlayersOn[0]+"\nAV. Ping: "+intPlayersOn[1];

                }
                this.PlayersOnline.Refresh();
            }
            else
            {
                this.srvSelected = null;
            }
        }
    }
}
