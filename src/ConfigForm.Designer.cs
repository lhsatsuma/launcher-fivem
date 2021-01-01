
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
            this.Combo_ServerList = new System.Windows.Forms.ComboBox();
            this.Btn_SaveServer = new System.Windows.Forms.Button();
            this.Btn_RemoveServer = new System.Windows.Forms.Button();
            this.Lbl_ConfigOf = new System.Windows.Forms.Label();
            this.Lbl_ServerOfName = new System.Windows.Forms.Label();
            this.Lbl_IP = new System.Windows.Forms.Label();
            this.Input_IP = new System.Windows.Forms.TextBox();
            this.Input_IPTS3 = new System.Windows.Forms.TextBox();
            this.Lbl_IPTS3 = new System.Windows.Forms.Label();
            this.Check_UseTS3 = new System.Windows.Forms.CheckBox();
            this.Lbl_AddServer = new System.Windows.Forms.Label();
            this.Check_Fav = new System.Windows.Forms.CheckBox();
            this.Lbl_PassTS3 = new System.Windows.Forms.Label();
            this.Input_PassTS3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_NextStep
            // 
            this.Btn_NextStep.BackColor = System.Drawing.Color.Green;
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
            this.Input_AddServer.Location = new System.Drawing.Point(68, 77);
            this.Input_AddServer.Name = "Input_AddServer";
            this.Input_AddServer.Size = new System.Drawing.Size(190, 20);
            this.Input_AddServer.TabIndex = 6;
            // 
            // Btn_AddServer
            // 
            this.Btn_AddServer.BackColor = System.Drawing.Color.DarkGreen;
            this.Btn_AddServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_AddServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AddServer.ForeColor = System.Drawing.Color.White;
            this.Btn_AddServer.Location = new System.Drawing.Point(264, 77);
            this.Btn_AddServer.Name = "Btn_AddServer";
            this.Btn_AddServer.Size = new System.Drawing.Size(90, 22);
            this.Btn_AddServer.TabIndex = 7;
            this.Btn_AddServer.Text = "Adicionar";
            this.Btn_AddServer.UseVisualStyleBackColor = false;
            this.Btn_AddServer.Click += new System.EventHandler(this.Btn_AddServer_Click);
            // 
            // Combo_ServerList
            // 
            this.Combo_ServerList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_ServerList.FormattingEnabled = true;
            this.Combo_ServerList.Location = new System.Drawing.Point(17, 103);
            this.Combo_ServerList.Name = "Combo_ServerList";
            this.Combo_ServerList.Size = new System.Drawing.Size(190, 21);
            this.Combo_ServerList.TabIndex = 8;
            this.Combo_ServerList.SelectedIndexChanged += new System.EventHandler(this.Combo_ServerList_SelectedIndexChanged);
            // 
            // Btn_SaveServer
            // 
            this.Btn_SaveServer.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.Btn_SaveServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_SaveServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SaveServer.ForeColor = System.Drawing.Color.White;
            this.Btn_SaveServer.Location = new System.Drawing.Point(213, 104);
            this.Btn_SaveServer.Name = "Btn_SaveServer";
            this.Btn_SaveServer.Size = new System.Drawing.Size(90, 22);
            this.Btn_SaveServer.TabIndex = 9;
            this.Btn_SaveServer.Text = "Salvar";
            this.Btn_SaveServer.UseVisualStyleBackColor = false;
            this.Btn_SaveServer.Click += new System.EventHandler(this.Btn_SaveServer_Click);
            // 
            // Btn_RemoveServer
            // 
            this.Btn_RemoveServer.BackColor = System.Drawing.Color.Maroon;
            this.Btn_RemoveServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_RemoveServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_RemoveServer.ForeColor = System.Drawing.Color.White;
            this.Btn_RemoveServer.Location = new System.Drawing.Point(308, 104);
            this.Btn_RemoveServer.Name = "Btn_RemoveServer";
            this.Btn_RemoveServer.Size = new System.Drawing.Size(90, 22);
            this.Btn_RemoveServer.TabIndex = 10;
            this.Btn_RemoveServer.Text = "Remover";
            this.Btn_RemoveServer.UseVisualStyleBackColor = false;
            this.Btn_RemoveServer.Click += new System.EventHandler(this.Btn_RemoveServer_Click);
            // 
            // Lbl_ConfigOf
            // 
            this.Lbl_ConfigOf.AutoSize = true;
            this.Lbl_ConfigOf.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_ConfigOf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ConfigOf.ForeColor = System.Drawing.Color.White;
            this.Lbl_ConfigOf.Location = new System.Drawing.Point(17, 148);
            this.Lbl_ConfigOf.Name = "Lbl_ConfigOf";
            this.Lbl_ConfigOf.Size = new System.Drawing.Size(181, 24);
            this.Lbl_ConfigOf.TabIndex = 11;
            this.Lbl_ConfigOf.Text = "Configurações de:";
            // 
            // Lbl_ServerOfName
            // 
            this.Lbl_ServerOfName.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_ServerOfName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ServerOfName.ForeColor = System.Drawing.Color.White;
            this.Lbl_ServerOfName.Location = new System.Drawing.Point(194, 149);
            this.Lbl_ServerOfName.Name = "Lbl_ServerOfName";
            this.Lbl_ServerOfName.Size = new System.Drawing.Size(319, 23);
            this.Lbl_ServerOfName.TabIndex = 12;
            this.Lbl_ServerOfName.Text = "...";
            // 
            // Lbl_IP
            // 
            this.Lbl_IP.AutoSize = true;
            this.Lbl_IP.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_IP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_IP.ForeColor = System.Drawing.Color.White;
            this.Lbl_IP.Location = new System.Drawing.Point(20, 228);
            this.Lbl_IP.Name = "Lbl_IP";
            this.Lbl_IP.Size = new System.Drawing.Size(111, 16);
            this.Lbl_IP.TabIndex = 13;
            this.Lbl_IP.Text = "IP do Servidor:";
            // 
            // Input_IP
            // 
            this.Input_IP.Location = new System.Drawing.Point(23, 248);
            this.Input_IP.Name = "Input_IP";
            this.Input_IP.Size = new System.Drawing.Size(328, 20);
            this.Input_IP.TabIndex = 14;
            // 
            // Input_IPTS3
            // 
            this.Input_IPTS3.Location = new System.Drawing.Point(23, 341);
            this.Input_IPTS3.Name = "Input_IPTS3";
            this.Input_IPTS3.Size = new System.Drawing.Size(328, 20);
            this.Input_IPTS3.TabIndex = 16;
            // 
            // Lbl_IPTS3
            // 
            this.Lbl_IPTS3.AutoSize = true;
            this.Lbl_IPTS3.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_IPTS3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_IPTS3.ForeColor = System.Drawing.Color.White;
            this.Lbl_IPTS3.Location = new System.Drawing.Point(20, 321);
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
            this.Check_UseTS3.Location = new System.Drawing.Point(23, 292);
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
            this.Lbl_AddServer.Location = new System.Drawing.Point(14, 80);
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
            this.Check_Fav.Location = new System.Drawing.Point(21, 191);
            this.Check_Fav.Name = "Check_Fav";
            this.Check_Fav.Size = new System.Drawing.Size(147, 20);
            this.Check_Fav.TabIndex = 1000;
            this.Check_Fav.Text = "Servidor Favorito";
            this.Check_Fav.UseVisualStyleBackColor = false;
            // 
            // Lbl_PassTS3
            // 
            this.Lbl_PassTS3.AutoSize = true;
            this.Lbl_PassTS3.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_PassTS3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_PassTS3.ForeColor = System.Drawing.Color.White;
            this.Lbl_PassTS3.Location = new System.Drawing.Point(357, 342);
            this.Lbl_PassTS3.Name = "Lbl_PassTS3";
            this.Lbl_PassTS3.Size = new System.Drawing.Size(56, 16);
            this.Lbl_PassTS3.TabIndex = 1001;
            this.Lbl_PassTS3.Text = "Senha:";
            // 
            // Input_PassTS3
            // 
            this.Input_PassTS3.Location = new System.Drawing.Point(419, 342);
            this.Input_PassTS3.Name = "Input_PassTS3";
            this.Input_PassTS3.Size = new System.Drawing.Size(144, 20);
            this.Input_PassTS3.TabIndex = 1002;
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.Separator;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(18, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(617, 19);
            this.label1.TabIndex = 1003;
            this.label1.Text = "_________________________________________________________________________________" +
    "__________________";
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Launcher_FiveM_CS.Properties.Resources.bg2;
            this.ClientSize = new System.Drawing.Size(638, 408);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Input_PassTS3);
            this.Controls.Add(this.Lbl_PassTS3);
            this.Controls.Add(this.Check_Fav);
            this.Controls.Add(this.Lbl_AddServer);
            this.Controls.Add(this.Check_UseTS3);
            this.Controls.Add(this.Input_IPTS3);
            this.Controls.Add(this.Lbl_IPTS3);
            this.Controls.Add(this.Input_IP);
            this.Controls.Add(this.Lbl_IP);
            this.Controls.Add(this.Lbl_ServerOfName);
            this.Controls.Add(this.Lbl_ConfigOf);
            this.Controls.Add(this.Btn_RemoveServer);
            this.Controls.Add(this.Btn_SaveServer);
            this.Controls.Add(this.Combo_ServerList);
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
        private System.Windows.Forms.ComboBox Combo_ServerList;
        private System.Windows.Forms.Button Btn_SaveServer;
        private System.Windows.Forms.Button Btn_RemoveServer;
        private System.Windows.Forms.Label Lbl_ConfigOf;
        private System.Windows.Forms.Label Lbl_ServerOfName;
        private System.Windows.Forms.Label Lbl_IP;
        private System.Windows.Forms.TextBox Input_IP;
        private System.Windows.Forms.TextBox Input_IPTS3;
        private System.Windows.Forms.Label Lbl_IPTS3;
        private System.Windows.Forms.CheckBox Check_UseTS3;
        private System.Windows.Forms.Label Lbl_AddServer;
        private System.Windows.Forms.CheckBox Check_Fav;
        private System.Windows.Forms.Label Lbl_PassTS3;
        private System.Windows.Forms.TextBox Input_PassTS3;
        private System.Windows.Forms.Label label1;
    }
}

