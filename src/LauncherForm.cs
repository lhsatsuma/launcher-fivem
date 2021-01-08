/* LAUNCHER PARA FIVEM GTA RP
 * DESENVOLVIDO POR: BigBangDBIKE#7340
 * OPEN SOURCED?
 * A vida é uma caixinha de surpresas...
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Threading;
using System.IO;
using System.Collections;
using System.Net.Http;
namespace Launcher_FiveM_CS
{
    public partial class LauncherForm : Form
    {
        public ServerList ServerList { get; set;}
        public string local_app;
        public LauncherForm()
        {
            InitializeComponent();
            this.local_app = Environment.GetEnvironmentVariable("LocalAppData") + "/FiveM/";
            this.LoadingBar.Maximum = 100;
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
                    ResetLoadingBar();
                }
                else if (ServerData.Use_TS3 == true && ServerData.IP_TS3 == "")
                {
                    this.SetLog("O IP do servidor do TeamSpeak 3 não é valido! Vá em Configurações para alterar o IP.");
                    ResetLoadingBar();
                }
                else
                {
                    SetLoadingBar(49);
                    await this.clearCacheApp(true);

                    SetLoadingBar(70);
                    this.SetLog("Abrindo a Steam...");
                    System.Diagnostics.Process.Start("steam://open");
                    await Task.Delay(2000);


                    SetLoadingBar(80);
                    this.SetLog("Abrindo o FiveM (" + ServerData.IP+")...");
                    await Task.Delay(800);

                    //Start CMD.exe and pass arguments to execute Fivem.exe with connect param
                    var cmd = new System.Diagnostics.Process();
                    cmd.StartInfo.FileName = "cmd.exe";
                    cmd.StartInfo.RedirectStandardInput = true;
                    cmd.StartInfo.RedirectStandardOutput = true;
                    cmd.StartInfo.CreateNoWindow = false;
                    cmd.StartInfo.UseShellExecute = false;
                    cmd.Start();
                    if (this.local_app.Substring(0, 3) != @"E:\")
                    {
                        cmd.StandardInput.WriteLine(this.local_app.Substring(0, 2));
                    }
                    cmd.StandardInput.WriteLine("cd " + this.local_app);
                    cmd.StandardInput.WriteLine(@".\FiveM.exe +connect " + ServerData.IP);
                    cmd.StandardInput.Flush();
                    cmd.StandardInput.Close();
                    cmd.WaitForExit();

                    if (ServerData.Use_TS3 == true)
                    {
                        SetLoadingBar(90);
                        this.SetLog("Abrindo o TS3 (" + ServerData.IP_TS3 + ")...");
                        await Task.Delay(800);
                        System.Diagnostics.Process.Start("ts3server://" + ServerData.IP_TS3+"/?nickname=LauncherDBIKE&password="+ServerData.Pass_TS3);
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
                this.PlayersOnline.Text = "Players Online: Carregando...";
                this.PlayersOnline.Refresh();

                var DataServer = this.ServerList.ServerCfgs[idx_combo];
                var intPlayersOn = await Utils.CheckIP_FiveM(DataServer.IP);
                if (intPlayersOn == -1)
                {
                    this.PlayersOnline.Text = "Players Online: 0 (Erro)";
                }
                else
                {
                    this.PlayersOnline.Text = "Players Online: "+intPlayersOn;

                }
                this.PlayersOnline.Refresh();
            }
        }
    }
    public class PlayerOnline
    {
        public string endpoint { get; set; }
        public string name { get; set; }
        public string id { get; set; }
        public string ping { get; set; }
    }
    public class PlayersOnline
    {
        public List<PlayerOnline> Players { get; set; }
    }
}
