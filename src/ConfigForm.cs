using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Launcher_FiveM_CS
{
    public partial class ConfigForm : Form
    {
        public ServerList ServerListTemp { get; set; }
        public bool ignoreErrors = false;
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
                    this.List_ServerList.Items.Add(this.ServerListTemp.ServerCfgs[i].Name);
                    if (this.ServerListTemp.ServerCfgs[i].Fav)
                    {
                        fav_index = i;
                    }
                }
                this.List_ServerList.SelectedIndex = fav_index;
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
            } else if (this.List_ServerList.Items.Contains(this.Input_AddServer.Text))
            {
                MessageBox.Show("Já possui um servidor com este nome na lista!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.List_ServerList.Items.Add(this.Input_AddServer.Text);
                var ServerCfg = new ServerCfg();
                ServerCfg.Name = this.Input_AddServer.Text;
                this.ServerListTemp.ServerCfgs.Add(ServerCfg);
                
                this.Input_AddServer.Text = "";
                this.Input_AddServer.Refresh();
                this.List_ServerList.SelectedIndex = this.List_ServerList.Items.Count - 1;
            }
        }

        private void List_ServerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string LabelServer = "...";
            this.Input_IP.Text = "";
            this.Input_IPTS3.Text = "";
            this.Input_PassTS3.Text = "";
            this.Check_UseTS3.Checked = false;
            this.Check_Fav.Checked = false;
            if (this.List_ServerList.SelectedItem != null)
            {
                LabelServer = this.List_ServerList.SelectedItem.ToString();
                var key_found = this.ServerListTemp.getIndexOf(LabelServer);
                if (key_found != -1)
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
            CheckUseTS_IP();
        }
        private void SaveJson()
        {
            this.ServerListTemp.version_saved = AboutApp.version;
            var ConfigHelper = new ConfigHelper();
            ConfigHelper.SetContent(this.ServerListTemp);
        }

        private async void Btn_SaveConfig_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            this.Cursor = Cursors.WaitCursor;
            if(this.ServerListTemp.ServerCfgs.Count > 0)
            {
                for (int i = 0; i < this.ServerListTemp.ServerCfgs.Count; i++)
                {
                    this.List_ServerList.SelectedIndex = i;
                    var data = this.ServerListTemp.ServerCfgs[i];

                    if (this.ignoreErrors)
                    {
                        continue;
                    }

                    var isValid = true;
                    var response = Utils.newCheckIPReach(data.IP);
                    if (!response)
                    {
                        isValid = false;
                    }
                    else
                    {
                        var responseFiveM = await Utils.CheckIP_FiveM(data.IP);
                        if(responseFiveM == -1)
                        {
                            isValid = false;
                        }
                    }
                    if(!isValid)
                    {
                        var resultConfirm = MessageBox.Show("O IP do FiveM digitado para " + data.Name + " parece ser inválido.\nDeseja continuar mesmo assim?", "Aviso", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);
                        if(resultConfirm == DialogResult.Abort)
                        {
                            this.Enabled = true;
                            this.Cursor = Cursors.Default;
                            this.ActiveControl = this.Input_IP;
                            return;
                        }else if(resultConfirm == DialogResult.Ignore)
                        {
                            this.ignoreErrors = true;
                        }
                    }
                    if (this.ignoreErrors)
                    {
                        continue;
                    }
                    //Validating IP for TS3 if necessary
                     if (data.Use_TS3)
                    {
                        var responseTS = Utils.newCheckIPReach(data.IP_TS3);
                        if (!responseTS)
                        {
                            var resultConfirm = MessageBox.Show("O IP do TS3 digitado para " + data.Name + " parece ser inválido.\nDeseja continuar mesmo assim?", "Aviso", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);
                            if (resultConfirm.ToString() == "No")
                            {
                                this.Enabled = true;
                                this.Cursor = Cursors.Default;
                                this.ActiveControl = this.Input_IPTS3;
                                return;
                            }else if (resultConfirm == DialogResult.Ignore)
                            {
                                this.ignoreErrors = true;
                            }
                        }
                    }
                }
            }
            this.SaveJson();
            MessageBox.Show("Salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Enabled = true;
            this.Cursor = Cursors.Default;
        }
        private void Btn_NextStep_Click(object sender, EventArgs e)
        {
            this.Hide();

            LauncherForm LauncherForm = new LauncherForm();
            LauncherForm.Show();
        }

        private void Check_Fav_Click(object sender, EventArgs e)
        {
            var newFav = (this.Check_Fav.Checked) ? true : false;
            if (newFav)
            {
                this.RemoveFavServers();
            }
            var key_found = this.ServerListTemp.getIndexOf(this.List_ServerList.SelectedItem.ToString());
            if (key_found != -1)
            {
                this.ServerListTemp.ServerCfgs[key_found].Fav = newFav;
            }
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

        private void SaveTemp(object sender, EventArgs e)
        {
            if (this.List_ServerList.SelectedItem != null)
            {
                var ServerCfg = new ServerCfg();
                ServerCfg.Name = this.List_ServerList.SelectedItem.ToString();
                ServerCfg.IP = this.Input_IP.Text;
                ServerCfg.Use_TS3 = (this.Check_UseTS3.Checked) ? true : false;
                ServerCfg.IP_TS3 = this.Input_IPTS3.Text;
                ServerCfg.Pass_TS3 = this.Input_PassTS3.Text;
                ServerCfg.Fav = (this.Check_Fav.Checked) ? true : false;

                if (ServerCfg.Fav)
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
            }
        }

        private void Btn_RemoveServer_Click(object sender, EventArgs e)
        {
            var new_selected = -1;
            if (this.List_ServerList.SelectedItem != null)
            {
                var key_found = this.ServerListTemp.getIndexOf(this.List_ServerList.SelectedItem.ToString());
                if (key_found != -1)
                {
                    this.ServerListTemp.ServerCfgs.RemoveAt(key_found);
                    this.List_ServerList.Items.RemoveAt(this.List_ServerList.SelectedIndex);
                    if (this.List_ServerList.Items.Count > 0)
                    {
                        new_selected = this.List_ServerList.Items.Count - 1;
                    }
                }
            }
            this.List_ServerList.SelectedIndex = new_selected;

            if(new_selected == -1)
            {
                this.List_ServerList_SelectedIndexChanged(sender, e);
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
            this.SaveTemp(sender, e);
        }

        private void Btn_Up_Click(object sender, EventArgs e)
        {
            this.ReorderList("up");
        }

        private void Btn_Down_Click(object sender, EventArgs e)
        {
            this.ReorderList("down");
        }

        private void ReorderList(string direction)
        {
            if (this.List_ServerList.SelectedIndex != -1)
            {
                int oldIndex = this.List_ServerList.SelectedIndex;

                int newIndex = -1;
                if (direction == "up")
                {
                    if (this.List_ServerList.SelectedIndex == 0)
                    {
                        return;
                    }
                    newIndex = oldIndex - 1;
                }
                else
                {
                    if (this.List_ServerList.SelectedIndex == this.ServerListTemp.ServerCfgs.Count - 1)
                    {
                        return;
                    }
                    newIndex = oldIndex + 1;
                }
                this.List_ServerList.Items.Clear();
                var NewServerListTemp = new List<ServerCfg>();
                if (this.ServerListTemp.ServerCfgs.Count > 0)
                {
                    for (int i = 0; i < this.ServerListTemp.ServerCfgs.Count; i++)
                    {
                        var newI = i;
                        if (i == newIndex)
                        {
                            newI = oldIndex;
                        }
                        else if (i == oldIndex)
                        {
                            newI = newIndex;
                        }

                        this.List_ServerList.Items.Add(this.ServerListTemp.ServerCfgs[newI].Name);

                        NewServerListTemp.Add(this.ServerListTemp.ServerCfgs[newI]);
                    }

                    this.List_ServerList.SelectedIndex = newIndex;

                    this.ServerListTemp.ServerCfgs = NewServerListTemp;
                }
            }
        }

        private void Input_IP_KeyUp(object sender, KeyEventArgs e)
        {
            this.SaveTemp(sender, e);
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
