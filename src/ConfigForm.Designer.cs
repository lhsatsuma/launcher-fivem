
namespace Launcher_FiveM_CS
{
    partial class ConfigForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm));
            this.Btn_NextStep = new System.Windows.Forms.Button();
            this.Lbl_Title = new System.Windows.Forms.Label();
            this.Lbl_Spacer = new System.Windows.Forms.Label();
            this.Input_AddServer = new System.Windows.Forms.TextBox();
            this.Btn_AddServer = new System.Windows.Forms.Button();
            this.Lbl_IP = new System.Windows.Forms.Label();
            this.Input_IP = new System.Windows.Forms.TextBox();
            this.Input_IPTS3 = new System.Windows.Forms.TextBox();
            this.Lbl_IPTS3 = new System.Windows.Forms.Label();
            this.Check_UseTS3 = new System.Windows.Forms.CheckBox();
            this.Lbl_AddServer = new System.Windows.Forms.Label();
            this.Check_Fav = new System.Windows.Forms.CheckBox();
            this.Lbl_PassTS3 = new System.Windows.Forms.Label();
            this.Input_PassTS3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.List_ServerList = new System.Windows.Forms.ListBox();
            this.Btn_Up = new System.Windows.Forms.Button();
            this.Btn_Rmv = new System.Windows.Forms.Button();
            this.Btn_Down = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_SaveConfig = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_NextStep
            // 
            this.Btn_NextStep.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.Btn_NextStep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_NextStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_NextStep.ForeColor = System.Drawing.Color.White;
            this.Btn_NextStep.Location = new System.Drawing.Point(12, 3);
            this.Btn_NextStep.Name = "Btn_NextStep";
            this.Btn_NextStep.Size = new System.Drawing.Size(77, 39);
            this.Btn_NextStep.TabIndex = 999;
            this.Btn_NextStep.Text = "Voltar";
            this.Btn_NextStep.UseVisualStyleBackColor = false;
            this.Btn_NextStep.Click += new System.EventHandler(this.Btn_NextStep_Click);
            // 
            // Lbl_Title
            // 
            this.Lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Title.ForeColor = System.Drawing.Color.LawnGreen;
            this.Lbl_Title.Location = new System.Drawing.Point(95, 9);
            this.Lbl_Title.Name = "Lbl_Title";
            this.Lbl_Title.Size = new System.Drawing.Size(514, 31);
            this.Lbl_Title.TabIndex = 2;
            this.Lbl_Title.Text = "Configurações";
            this.Lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_Spacer
            // 
            this.Lbl_Spacer.AccessibleRole = System.Windows.Forms.AccessibleRole.Separator;
            this.Lbl_Spacer.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Spacer.Location = new System.Drawing.Point(9, 45);
            this.Lbl_Spacer.Name = "Lbl_Spacer";
            this.Lbl_Spacer.Size = new System.Drawing.Size(617, 19);
            this.Lbl_Spacer.TabIndex = 3;
            this.Lbl_Spacer.Text = "_________________________________________________________________________________" +
    "__________________";
            // 
            // Input_AddServer
            // 
            this.Input_AddServer.Location = new System.Drawing.Point(72, 83);
            this.Input_AddServer.Name = "Input_AddServer";
            this.Input_AddServer.Size = new System.Drawing.Size(190, 20);
            this.Input_AddServer.TabIndex = 6;
            // 
            // Btn_AddServer
            // 
            this.Btn_AddServer.BackColor = System.Drawing.Color.MidnightBlue;
            this.Btn_AddServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_AddServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AddServer.ForeColor = System.Drawing.Color.White;
            this.Btn_AddServer.Location = new System.Drawing.Point(268, 83);
            this.Btn_AddServer.Name = "Btn_AddServer";
            this.Btn_AddServer.Size = new System.Drawing.Size(115, 22);
            this.Btn_AddServer.TabIndex = 7;
            this.Btn_AddServer.Text = "Adicionar Novo";
            this.Btn_AddServer.UseVisualStyleBackColor = false;
            this.Btn_AddServer.Click += new System.EventHandler(this.Btn_AddServer_Click);
            // 
            // Lbl_IP
            // 
            this.Lbl_IP.AutoSize = true;
            this.Lbl_IP.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_IP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_IP.ForeColor = System.Drawing.Color.White;
            this.Lbl_IP.Location = new System.Drawing.Point(325, 208);
            this.Lbl_IP.Name = "Lbl_IP";
            this.Lbl_IP.Size = new System.Drawing.Size(111, 16);
            this.Lbl_IP.TabIndex = 13;
            this.Lbl_IP.Text = "IP do Servidor:";
            // 
            // Input_IP
            // 
            this.Input_IP.Location = new System.Drawing.Point(328, 228);
            this.Input_IP.Name = "Input_IP";
            this.Input_IP.Size = new System.Drawing.Size(247, 20);
            this.Input_IP.TabIndex = 14;
            this.Input_IP.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Input_IP_KeyUp);
            // 
            // Input_IPTS3
            // 
            this.Input_IPTS3.Location = new System.Drawing.Point(328, 332);
            this.Input_IPTS3.Name = "Input_IPTS3";
            this.Input_IPTS3.Size = new System.Drawing.Size(247, 20);
            this.Input_IPTS3.TabIndex = 16;
            this.Input_IPTS3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Input_IP_KeyUp);
            // 
            // Lbl_IPTS3
            // 
            this.Lbl_IPTS3.AutoSize = true;
            this.Lbl_IPTS3.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_IPTS3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_IPTS3.ForeColor = System.Drawing.Color.White;
            this.Lbl_IPTS3.Location = new System.Drawing.Point(325, 312);
            this.Lbl_IPTS3.Name = "Lbl_IPTS3";
            this.Lbl_IPTS3.Size = new System.Drawing.Size(153, 16);
            this.Lbl_IPTS3.TabIndex = 15;
            this.Lbl_IPTS3.Text = "IP do Team Speak 3:";
            // 
            // Check_UseTS3
            // 
            this.Check_UseTS3.AutoSize = true;
            this.Check_UseTS3.BackColor = System.Drawing.Color.Transparent;
            this.Check_UseTS3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Check_UseTS3.ForeColor = System.Drawing.Color.White;
            this.Check_UseTS3.Location = new System.Drawing.Point(328, 272);
            this.Check_UseTS3.Name = "Check_UseTS3";
            this.Check_UseTS3.Size = new System.Drawing.Size(183, 20);
            this.Check_UseTS3.TabIndex = 17;
            this.Check_UseTS3.Text = "Utiliza Team Speak 3?";
            this.Check_UseTS3.UseVisualStyleBackColor = false;
            this.Check_UseTS3.Click += new System.EventHandler(this.Check_UseTS3_Click);
            // 
            // Lbl_AddServer
            // 
            this.Lbl_AddServer.AutoSize = true;
            this.Lbl_AddServer.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_AddServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_AddServer.ForeColor = System.Drawing.Color.White;
            this.Lbl_AddServer.Location = new System.Drawing.Point(18, 86);
            this.Lbl_AddServer.Name = "Lbl_AddServer";
            this.Lbl_AddServer.Size = new System.Drawing.Size(53, 16);
            this.Lbl_AddServer.TabIndex = 18;
            this.Lbl_AddServer.Text = "Nome:";
            // 
            // Check_Fav
            // 
            this.Check_Fav.AutoSize = true;
            this.Check_Fav.BackColor = System.Drawing.Color.Transparent;
            this.Check_Fav.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Check_Fav.ForeColor = System.Drawing.Color.White;
            this.Check_Fav.Location = new System.Drawing.Point(326, 171);
            this.Check_Fav.Name = "Check_Fav";
            this.Check_Fav.Size = new System.Drawing.Size(147, 20);
            this.Check_Fav.TabIndex = 1000;
            this.Check_Fav.Text = "Servidor Favorito";
            this.Check_Fav.UseVisualStyleBackColor = false;
            this.Check_Fav.Click += new System.EventHandler(this.Check_Fav_Click);
            // 
            // Lbl_PassTS3
            // 
            this.Lbl_PassTS3.AutoSize = true;
            this.Lbl_PassTS3.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_PassTS3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_PassTS3.ForeColor = System.Drawing.Color.White;
            this.Lbl_PassTS3.Location = new System.Drawing.Point(325, 364);
            this.Lbl_PassTS3.Name = "Lbl_PassTS3";
            this.Lbl_PassTS3.Size = new System.Drawing.Size(56, 16);
            this.Lbl_PassTS3.TabIndex = 1001;
            this.Lbl_PassTS3.Text = "Senha:";
            // 
            // Input_PassTS3
            // 
            this.Input_PassTS3.Location = new System.Drawing.Point(387, 364);
            this.Input_PassTS3.Name = "Input_PassTS3";
            this.Input_PassTS3.Size = new System.Drawing.Size(188, 20);
            this.Input_PassTS3.TabIndex = 1002;
            this.Input_PassTS3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Input_IP_KeyUp);
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.Separator;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(18, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(617, 19);
            this.label2.TabIndex = 1003;
            this.label2.Text = "_________________________________________________________________________________" +
    "__________________";
            // 
            // List_ServerList
            // 
            this.List_ServerList.FormattingEnabled = true;
            this.List_ServerList.Location = new System.Drawing.Point(21, 171);
            this.List_ServerList.Name = "List_ServerList";
            this.List_ServerList.Size = new System.Drawing.Size(237, 225);
            this.List_ServerList.TabIndex = 1004;
            this.List_ServerList.SelectedIndexChanged += new System.EventHandler(this.List_ServerList_SelectedIndexChanged);
            // 
            // Btn_Up
            // 
            this.Btn_Up.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Up.Location = new System.Drawing.Point(264, 206);
            this.Btn_Up.Name = "Btn_Up";
            this.Btn_Up.Size = new System.Drawing.Size(40, 40);
            this.Btn_Up.TabIndex = 1005;
            this.Btn_Up.Text = "^";
            this.Btn_Up.UseVisualStyleBackColor = true;
            this.Btn_Up.Click += new System.EventHandler(this.Btn_Up_Click);
            // 
            // Btn_Rmv
            // 
            this.Btn_Rmv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Rmv.Location = new System.Drawing.Point(264, 252);
            this.Btn_Rmv.Name = "Btn_Rmv";
            this.Btn_Rmv.Size = new System.Drawing.Size(40, 40);
            this.Btn_Rmv.TabIndex = 1006;
            this.Btn_Rmv.Text = "X";
            this.Btn_Rmv.UseVisualStyleBackColor = true;
            this.Btn_Rmv.Click += new System.EventHandler(this.Btn_RemoveServer_Click);
            // 
            // Btn_Down
            // 
            this.Btn_Down.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Down.Location = new System.Drawing.Point(264, 298);
            this.Btn_Down.Name = "Btn_Down";
            this.Btn_Down.Size = new System.Drawing.Size(40, 40);
            this.Btn_Down.TabIndex = 1007;
            this.Btn_Down.Text = "v";
            this.Btn_Down.UseVisualStyleBackColor = true;
            this.Btn_Down.Click += new System.EventHandler(this.Btn_Down_Click);
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.Separator;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(310, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 232);
            this.label3.TabIndex = 1008;
            this.label3.Text = "||||||||||||||||||||||||||||||||||||||||||||";
            // 
            // Btn_SaveConfig
            // 
            this.Btn_SaveConfig.BackColor = System.Drawing.Color.Green;
            this.Btn_SaveConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_SaveConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SaveConfig.ForeColor = System.Drawing.Color.White;
            this.Btn_SaveConfig.Location = new System.Drawing.Point(497, 9);
            this.Btn_SaveConfig.Name = "Btn_SaveConfig";
            this.Btn_SaveConfig.Size = new System.Drawing.Size(112, 39);
            this.Btn_SaveConfig.TabIndex = 1009;
            this.Btn_SaveConfig.Text = "Salvar Configurações";
            this.Btn_SaveConfig.UseVisualStyleBackColor = false;
            this.Btn_SaveConfig.Click += new System.EventHandler(this.Btn_SaveConfig_Click);
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.Separator;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(591, 18);
            this.label1.TabIndex = 1010;
            this.label1.Text = "Adicione um novo servidor colocando o nome abaixo e clique no botão de \"Adicionar" +
    " Novo\".";
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.Separator;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(18, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(591, 43);
            this.label4.TabIndex = 1011;
            this.label4.Text = "Selecione o servidor na lista à esquerda para editar as informações à direita.\r\nV" +
    "ocê pode reordenar clicando nos botões de \"^\" e \"v\".\r\nVocê pode excluir o servid" +
    "or clicando no botão de \"X\".";
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Launcher_FiveM_CS.Properties.Resources.bg2;
            this.ClientSize = new System.Drawing.Size(638, 408);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_SaveConfig);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Btn_Down);
            this.Controls.Add(this.Btn_Rmv);
            this.Controls.Add(this.Btn_Up);
            this.Controls.Add(this.List_ServerList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Input_PassTS3);
            this.Controls.Add(this.Lbl_PassTS3);
            this.Controls.Add(this.Check_Fav);
            this.Controls.Add(this.Lbl_AddServer);
            this.Controls.Add(this.Check_UseTS3);
            this.Controls.Add(this.Input_IPTS3);
            this.Controls.Add(this.Lbl_IPTS3);
            this.Controls.Add(this.Input_IP);
            this.Controls.Add(this.Lbl_IP);
            this.Controls.Add(this.Btn_AddServer);
            this.Controls.Add(this.Input_AddServer);
            this.Controls.Add(this.Lbl_Spacer);
            this.Controls.Add(this.Btn_NextStep);
            this.Controls.Add(this.Lbl_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfigForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações Gerais";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_NextStep;
        private System.Windows.Forms.Label Lbl_Title;
        private System.Windows.Forms.Label Lbl_Spacer;
        private System.Windows.Forms.TextBox Input_AddServer;
        private System.Windows.Forms.Button Btn_AddServer;
        private System.Windows.Forms.Label Lbl_IP;
        private System.Windows.Forms.TextBox Input_IP;
        private System.Windows.Forms.TextBox Input_IPTS3;
        private System.Windows.Forms.Label Lbl_IPTS3;
        private System.Windows.Forms.CheckBox Check_UseTS3;
        private System.Windows.Forms.Label Lbl_AddServer;
        private System.Windows.Forms.CheckBox Check_Fav;
        private System.Windows.Forms.Label Lbl_PassTS3;
        private System.Windows.Forms.TextBox Input_PassTS3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox List_ServerList;
        private System.Windows.Forms.Button Btn_Up;
        private System.Windows.Forms.Button Btn_Rmv;
        private System.Windows.Forms.Button Btn_Down;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_SaveConfig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}

