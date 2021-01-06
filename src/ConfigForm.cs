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

namespace Launcher_FiveM_CS
{
    public partial class ConfigForm : Form
    {
        public ServerList ServerListTemp { get; set; }
        public ConfigForm()
        {
            InitializeComponent();
        }

        private void Btn_ExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {
            var ConfigHelper = new ConfigHelper();
            this.ServerListTemp = ConfigHelper.GetContent();
            int fav_index = 0;
            if (this.ServerListTemp.ServerCfgs.Count > 0)
            {
                for (int i = 0; i < this.ServerListTemp.ServerCfgs.Count; i++)
                {
                    this.Combo_ServerList.Items.Add(this.ServerListTemp.ServerCfgs[i].Name);
                    if (this.ServerListTemp.ServerCfgs[i].Fav)
                    {
                        fav_index = i;
                    }
                }
                this.Combo_ServerList.SelectedIndex = fav_index;
            }
        }

        private void Btn_BackStep_Click(object sender, EventArgs e)
        {
            this.Hide();
            LauncherForm LauncherForm = new LauncherForm();
            LauncherForm.Show();
        }

        private void Btn_AddServer_Click(object sender, EventArgs e)
        {
            if (this.Input_AddServer.Text == "")
            {
                MessageBox.Show("Digite um nome para o servidor!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else if (this.Combo_ServerList.Items.Contains(this.Input_AddServer.Text))
            {
                MessageBox.Show("Já possui um servidor com este nome na lista!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.Combo_ServerList.Items.Add(this.Input_AddServer.Text);
                var ServerCfg = new ServerCfg();
                ServerCfg.Name = this.Input_AddServer.Text;
                this.ServerListTemp.ServerCfgs.Add(ServerCfg);
                
                this.Input_AddServer.Text = "";
                this.Input_AddServer.Refresh();
                this.Combo_ServerList.SelectedIndex = this.Combo_ServerList.Items.Count - 1;
            }
        }

        private void Combo_ServerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string LabelServer = "...";
            this.Input_IP.Text = "";
            this.Input_IPTS3.Text = "";
            this.Input_PassTS3.Text = "";
            this.Check_UseTS3.Checked = false;
            this.Check_Fav.Checked = false;
            if (this.Combo_ServerList.SelectedItem != null)
            {
                LabelServer = this.Combo_ServerList.SelectedItem.ToString();

                var key_found = this.ServerListTemp.getIndexOf(LabelServer);

                if(key_found != -1)
                {
                    var data_temp = this.ServerListTemp.ServerCfgs[key_found];
                    this.Input_IP.Text = data_temp.IP;
                    this.Input_IPTS3.Text = data_temp.IP_TS3;
                    this.Input_PassTS3.Text = data_temp.Pass_TS3;
                    this.Check_UseTS3.Checked = data_temp.Use_TS3;
                    this.Check_Fav.Checked = data_temp.Fav;
                }
            }
            this.Input_IP.Refresh();
            this.Input_IPTS3.Refresh();
            this.Input_PassTS3.Refresh();
            this.Check_UseTS3.Refresh();
            this.Check_Fav.Refresh();
            this.Lbl_ServerOfName.Text = LabelServer;
            this.Lbl_ServerOfName.Refresh();
            CheckUseTS_IP();
        }
        private void SaveJson()
        {
            AboutApp AboutApp = new AboutApp();
            this.ServerListTemp.version_saved = AboutApp.version;
            var ConfigHelper = new ConfigHelper();
            ConfigHelper.SetContent(this.ServerListTemp);
        }
        private void Btn_NextStep_Click(object sender, EventArgs e)
        {
            this.Hide();

            LauncherForm LauncherForm = new LauncherForm();
            LauncherForm.Show();
        }

        private void RemoveFavServers()
        {
            if (this.ServerListTemp.ServerCfgs.Count > 0)
            {
                for (int i = 0; i < this.ServerListTemp.ServerCfgs.Count; i++)
                {
                    this.ServerListTemp.ServerCfgs[i].Fav = false;
                }
            }
        }
        private void Btn_SaveServer_Click(object sender, EventArgs e)
        {
            if (this.Combo_ServerList.SelectedItem != null)
            {
                var ServerCfg = new ServerCfg();
                ServerCfg.Name = this.Combo_ServerList.SelectedItem.ToString();
                ServerCfg.IP = this.Input_IP.Text;
                ServerCfg.Use_TS3 = (this.Check_UseTS3.Checked) ? true : false;
                ServerCfg.IP_TS3 = this.Input_IPTS3.Text;
                ServerCfg.Pass_TS3 = this.Input_PassTS3.Text;
                ServerCfg.Fav = (this.Check_Fav.Checked) ? true : false;

                if (ServerCfg.IP == "")
                {
                    MessageBox.Show("Digite o IP do servidor!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (ServerCfg.Use_TS3 == true && ServerCfg.IP_TS3 == "")
                {
                    MessageBox.Show("Digite o IP do Team Speak 3!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (ServerCfg.Fav == true)
                    {
                        this.RemoveFavServers();
                    }
                    var key_found = this.ServerListTemp.getIndexOf(ServerCfg.Name);
                    if (key_found != -1)
                    {
                        this.ServerListTemp.ServerCfgs[key_found] = ServerCfg;
                    }
                    else
                    {
                        this.ServerListTemp.ServerCfgs.Add(ServerCfg);
                    }
                    this.SaveJson();
                    MessageBox.Show("Salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Btn_RemoveServer_Click(object sender, EventArgs e)
        {
            var new_selected = -1;
            if (this.Combo_ServerList.SelectedItem != null)
            {
                var key_found = this.ServerListTemp.getIndexOf(this.Combo_ServerList.SelectedItem.ToString());
                if (key_found != -1)
                {
                    this.ServerListTemp.ServerCfgs.RemoveAt(key_found);
                    this.Combo_ServerList.Items.RemoveAt(this.Combo_ServerList.SelectedIndex);
                    if (this.Combo_ServerList.Items.Count > 0)
                    {
                        new_selected = this.Combo_ServerList.Items.Count - 1;
                    }
                }
            }
            this.Combo_ServerList.SelectedIndex = new_selected;

            if(new_selected == -1)
            {
                this.Combo_ServerList_SelectedIndexChanged(sender, e);
            }
        }

        public void CheckUseTS_IP()
        {
            if (this.Check_UseTS3.Checked)
            {
                this.Lbl_IPTS3.Show();
                this.Input_IPTS3.Show();
                this.Lbl_PassTS3.Show();
                this.Input_PassTS3.Show();
            }
            else
            {
                this.Lbl_IPTS3.Hide();
                this.Input_IPTS3.Hide();
                this.Lbl_PassTS3.Hide();
                this.Input_PassTS3.Hide();
            }
        }

        private void Check_UseTS3_Click(object sender, EventArgs e)
        {
            CheckUseTS_IP();
        }

        private void Btn_Reorder_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReorderForm ReorderForm = new ReorderForm();
            ReorderForm.Show();
        }
    }
    public class ServerList
    {
        public IList<ServerCfg> ServerCfgs = new List<ServerCfg>();

        public string version_saved = "";
        public int getIndexOf(string name)
        {
            
            int return_key = -1;
            for (int i = 0; i < this.ServerCfgs.Count; i++)
            {
                var actual = this.ServerCfgs[i];

                if(actual.Name == name)
                {
                    return_key = i;
                    break;
                }
            }
            return return_key;
        }
    }
    public class ServerCfg
    {
        public string Name { get; set; }
        public string IP { get; set; }
        public bool Use_TS3 { get; set; }
        public string IP_TS3 { get; set; }
        public string Pass_TS3 { get; set; }
        public bool Fav { get; set; }
    }
}
