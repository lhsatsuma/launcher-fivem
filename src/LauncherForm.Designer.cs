
namespace Launcher_FiveM_CS
{
    partial class LauncherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LauncherForm));
            this.Text_Log = new System.Windows.Forms.TextBox();
            this.Btn_ClrCache = new System.Windows.Forms.Button();
            this.Btn_Cfg = new System.Windows.Forms.Button();
            this.Btn_Play = new System.Windows.Forms.Button();
            this.Combo_ListServers = new System.Windows.Forms.ComboBox();
            this.LoadingBar = new System.Windows.Forms.ProgressBar();
            this.Lbl_LoadingBar = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.PlayersOnline = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_FiveM = new System.Windows.Forms.Button();
            this.Btn_TS3 = new System.Windows.Forms.Button();
            this.Btn_ExitApp = new System.Windows.Forms.Button();
            this.Btn_About = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Text_Log
            // 
            this.Text_Log.Location = new System.Drawing.Point(38, 123);
            this.Text_Log.Multiline = true;
            this.Text_Log.Name = "Text_Log";
            this.Text_Log.ReadOnly = true;
            this.Text_Log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Text_Log.Size = new System.Drawing.Size(334, 200);
            this.Text_Log.TabIndex = 0;
            // 
            // Btn_ClrCache
            // 
            this.Btn_ClrCache.BackColor = System.Drawing.Color.DarkOrange;
            this.Btn_ClrCache.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ClrCache.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ClrCache.ForeColor = System.Drawing.Color.White;
            this.Btn_ClrCache.Location = new System.Drawing.Point(378, 123);
            this.Btn_ClrCache.Name = "Btn_ClrCache";
            this.Btn_ClrCache.Size = new System.Drawing.Size(114, 34);
            this.Btn_ClrCache.TabIndex = 1;
            this.Btn_ClrCache.Text = "Limpar Cache";
            this.Btn_ClrCache.UseVisualStyleBackColor = false;
            this.Btn_ClrCache.Click += new System.EventHandler(this.Btn_ClrCache_Click);
            // 
            // Btn_Cfg
            // 
            this.Btn_Cfg.BackColor = System.Drawing.Color.ForestGreen;
            this.Btn_Cfg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Cfg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cfg.ForeColor = System.Drawing.Color.White;
            this.Btn_Cfg.Location = new System.Drawing.Point(498, 123);
            this.Btn_Cfg.Name = "Btn_Cfg";
            this.Btn_Cfg.Size = new System.Drawing.Size(114, 34);
            this.Btn_Cfg.TabIndex = 2;
            this.Btn_Cfg.Text = "Configurações";
            this.Btn_Cfg.UseVisualStyleBackColor = false;
            this.Btn_Cfg.Click += new System.EventHandler(this.Btn_Cfg_Click);
            // 
            // Btn_Play
            // 
            this.Btn_Play.AutoSize = true;
            this.Btn_Play.BackColor = System.Drawing.Color.ForestGreen;
            this.Btn_Play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Play.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Play.ForeColor = System.Drawing.Color.White;
            this.Btn_Play.Location = new System.Drawing.Point(378, 267);
            this.Btn_Play.Name = "Btn_Play";
            this.Btn_Play.Size = new System.Drawing.Size(114, 55);
            this.Btn_Play.TabIndex = 5;
            this.Btn_Play.Text = "Jogar";
            this.Btn_Play.UseVisualStyleBackColor = false;
            this.Btn_Play.Click += new System.EventHandler(this.Btn_Play_Click);
            // 
            // Combo_ListServers
            // 
            this.Combo_ListServers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Combo_ListServers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_ListServers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combo_ListServers.FormattingEnabled = true;
            this.Combo_ListServers.Location = new System.Drawing.Point(380, 202);
            this.Combo_ListServers.Name = "Combo_ListServers";
            this.Combo_ListServers.Size = new System.Drawing.Size(232, 24);
            this.Combo_ListServers.TabIndex = 6;
            this.Combo_ListServers.SelectedIndexChanged += new System.EventHandler(this.Combo_ListServers_SelectedIndexChanged);
            // 
            // LoadingBar
            // 
            this.LoadingBar.Location = new System.Drawing.Point(89, 349);
            this.LoadingBar.Name = "LoadingBar";
            this.LoadingBar.Size = new System.Drawing.Size(477, 17);
            this.LoadingBar.TabIndex = 7;
            // 
            // Lbl_LoadingBar
            // 
            this.Lbl_LoadingBar.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_LoadingBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_LoadingBar.ForeColor = System.Drawing.Color.White;
            this.Lbl_LoadingBar.Location = new System.Drawing.Point(89, 333);
            this.Lbl_LoadingBar.Name = "Lbl_LoadingBar";
            this.Lbl_LoadingBar.Size = new System.Drawing.Size(477, 13);
            this.Lbl_LoadingBar.TabIndex = 8;
            this.Lbl_LoadingBar.Text = "...";
            this.Lbl_LoadingBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayersOnline
            // 
            this.PlayersOnline.BackColor = System.Drawing.Color.Silver;
            this.PlayersOnline.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayersOnline.ForeColor = System.Drawing.Color.Black;
            this.PlayersOnline.Location = new System.Drawing.Point(381, 229);
            this.PlayersOnline.Name = "PlayersOnline";
            this.PlayersOnline.Size = new System.Drawing.Size(231, 35);
            this.PlayersOnline.TabIndex = 9;
            this.PlayersOnline.Text = "Players Online: 0\r\nAV. Ping: 0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Launcher_FiveM_CS.Properties.Resources.circle_cropped;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.Btn_About_Click);
            // 
            // Btn_FiveM
            // 
            this.Btn_FiveM.AutoEllipsis = true;
            this.Btn_FiveM.BackColor = System.Drawing.Color.Transparent;
            this.Btn_FiveM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_FiveM.FlatAppearance.BorderSize = 0;
            this.Btn_FiveM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_FiveM.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_FiveM.Image = global::Launcher_FiveM_CS.Properties.Resources.fivem;
            this.Btn_FiveM.Location = new System.Drawing.Point(498, 273);
            this.Btn_FiveM.Name = "Btn_FiveM";
            this.Btn_FiveM.Size = new System.Drawing.Size(49, 49);
            this.Btn_FiveM.TabIndex = 11;
            this.Btn_FiveM.TabStop = false;
            this.Btn_FiveM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_FiveM.UseVisualStyleBackColor = false;
            this.Btn_FiveM.Click += new System.EventHandler(this.OpenFiveM);
            // 
            // Btn_TS3
            // 
            this.Btn_TS3.BackColor = System.Drawing.Color.Transparent;
            this.Btn_TS3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_TS3.FlatAppearance.BorderSize = 0;
            this.Btn_TS3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_TS3.Image = global::Launcher_FiveM_CS.Properties.Resources.ts3_logo;
            this.Btn_TS3.Location = new System.Drawing.Point(560, 274);
            this.Btn_TS3.Name = "Btn_TS3";
            this.Btn_TS3.Size = new System.Drawing.Size(49, 49);
            this.Btn_TS3.TabIndex = 12;
            this.Btn_TS3.UseVisualStyleBackColor = false;
            this.Btn_TS3.Click += new System.EventHandler(this.OpenTS3);
            // 
            // Btn_ExitApp
            // 
            this.Btn_ExitApp.BackColor = System.Drawing.Color.Maroon;
            this.Btn_ExitApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ExitApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ExitApp.ForeColor = System.Drawing.Color.White;
            this.Btn_ExitApp.Location = new System.Drawing.Point(498, 162);
            this.Btn_ExitApp.Name = "Btn_ExitApp";
            this.Btn_ExitApp.Size = new System.Drawing.Size(114, 34);
            this.Btn_ExitApp.TabIndex = 13;
            this.Btn_ExitApp.Text = "Sair";
            this.Btn_ExitApp.UseVisualStyleBackColor = false;
            this.Btn_ExitApp.Click += new System.EventHandler(this.Btn_ExitApp_Click);
            // 
            // Btn_About
            // 
            this.Btn_About.BackColor = System.Drawing.Color.DarkBlue;
            this.Btn_About.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_About.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_About.ForeColor = System.Drawing.Color.White;
            this.Btn_About.Location = new System.Drawing.Point(378, 163);
            this.Btn_About.Name = "Btn_About";
            this.Btn_About.Size = new System.Drawing.Size(114, 34);
            this.Btn_About.TabIndex = 14;
            this.Btn_About.Text = "Sobre";
            this.Btn_About.UseVisualStyleBackColor = false;
            this.Btn_About.Click += new System.EventHandler(this.Btn_About_Click);
            // 
            // LauncherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Launcher_FiveM_CS.Properties.Resources.bg3;
            this.ClientSize = new System.Drawing.Size(638, 408);
            this.ControlBox = false;
            this.Controls.Add(this.Btn_About);
            this.Controls.Add(this.Btn_ExitApp);
            this.Controls.Add(this.Btn_TS3);
            this.Controls.Add(this.Btn_FiveM);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PlayersOnline);
            this.Controls.Add(this.Lbl_LoadingBar);
            this.Controls.Add(this.LoadingBar);
            this.Controls.Add(this.Combo_ListServers);
            this.Controls.Add(this.Btn_Play);
            this.Controls.Add(this.Btn_Cfg);
            this.Controls.Add(this.Btn_ClrCache);
            this.Controls.Add(this.Text_Log);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LauncherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Launcher FiveM";
            this.Load += new System.EventHandler(this.LauncherForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Text_Log;
        private System.Windows.Forms.Button Btn_ClrCache;
        private System.Windows.Forms.Button Btn_Cfg;
        private System.Windows.Forms.Button Btn_Play;
        private System.Windows.Forms.ComboBox Combo_ListServers;
        private System.Windows.Forms.ProgressBar LoadingBar;
        private System.Windows.Forms.Label Lbl_LoadingBar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label PlayersOnline;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_FiveM;
        private System.Windows.Forms.Button Btn_TS3;
        private System.Windows.Forms.Button Btn_ExitApp;
        private System.Windows.Forms.Button Btn_About;
    }
}

