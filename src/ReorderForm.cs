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
    public partial class ReorderForm : Form
    {
        public ServerList ServerListTemp { get; set; }
        public ReorderForm()
        {
            InitializeComponent();
        }

        private void Btn_ExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ReorderForm_Load(object sender, EventArgs e)
        {
            var ConfigHelper = new ConfigHelper();
            this.ServerListTemp = ConfigHelper.GetContent();
            int fav_index = 0;
            this.List_ServerList.Items.Clear();
            if (this.ServerListTemp.ServerCfgs.Count > 0)
            {
                for (int i = 0; i < this.ServerListTemp.ServerCfgs.Count; i++)
                {
                    this.List_ServerList.Items.Add(this.ServerListTemp.ServerCfgs[i].Name);
                }
            }
        }

        private void Btn_BackStep_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConfigForm ConfigForm = new ConfigForm();
            ConfigForm.Show();
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
            if (this.List_ServerList.SelectedIndex != -1 && this.List_ServerList.SelectedIndex != this.ServerListTemp.ServerCfgs.Count - 1)
            {
                int oldIndex = this.List_ServerList.SelectedIndex;

                int newIndex = oldIndex + 1;
                if (direction == "up")
                {
                    newIndex = oldIndex - 1;
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

        private void Btn_SaveOrder_Click(object sender, EventArgs e)
        {
            AboutApp AboutApp = new AboutApp();
            this.ServerListTemp.version_saved = AboutApp.version;
            var ConfigHelper = new ConfigHelper();
            ConfigHelper.SetContent(this.ServerListTemp);
            MessageBox.Show("Salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
