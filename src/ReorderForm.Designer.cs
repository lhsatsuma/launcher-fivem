
namespace Launcher_FiveM_CS
{
    partial class ReorderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReorderForm));
            this.Btn_NextStep = new System.Windows.Forms.Button();
            this.Lbl_Title = new System.Windows.Forms.Label();
            this.Lbl_Spacer = new System.Windows.Forms.Label();
            this.List_ServerList = new System.Windows.Forms.ListBox();
            this.Lbl_Help = new System.Windows.Forms.Label();
            this.Btn_Down = new System.Windows.Forms.Button();
            this.Btn_Up = new System.Windows.Forms.Button();
            this.Btn_SaveOrder = new System.Windows.Forms.Button();
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
            this.Btn_NextStep.Click += new System.EventHandler(this.Btn_BackStep_Click);
            // 
            // Lbl_Title
            // 
            this.Lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Title.ForeColor = System.Drawing.Color.LawnGreen;
            this.Lbl_Title.Location = new System.Drawing.Point(95, 9);
            this.Lbl_Title.Name = "Lbl_Title";
            this.Lbl_Title.Size = new System.Drawing.Size(431, 31);
            this.Lbl_Title.TabIndex = 2;
            this.Lbl_Title.Text = "Reordenar Servidores";
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
            // List_ServerList
            // 
            this.List_ServerList.FormattingEnabled = true;
            this.List_ServerList.Items.AddRange(new object[] {
            "LIST",
            "OF",
            "SERVERS",
            "SAVED"});
            this.List_ServerList.Location = new System.Drawing.Point(385, 76);
            this.List_ServerList.Name = "List_ServerList";
            this.List_ServerList.Size = new System.Drawing.Size(224, 264);
            this.List_ServerList.TabIndex = 1001;
            // 
            // Lbl_Help
            // 
            this.Lbl_Help.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Help.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Help.ForeColor = System.Drawing.Color.White;
            this.Lbl_Help.Location = new System.Drawing.Point(12, 161);
            this.Lbl_Help.Name = "Lbl_Help";
            this.Lbl_Help.Size = new System.Drawing.Size(295, 57);
            this.Lbl_Help.TabIndex = 1002;
            this.Lbl_Help.Text = "Selecione o servidor e clique nas setas para reordenar. Depois clique em Salvar p" +
    "ara manter as configurações.";
            // 
            // Btn_Down
            // 
            this.Btn_Down.Location = new System.Drawing.Point(339, 195);
            this.Btn_Down.Name = "Btn_Down";
            this.Btn_Down.Size = new System.Drawing.Size(40, 40);
            this.Btn_Down.TabIndex = 1004;
            this.Btn_Down.Text = "v";
            this.Btn_Down.UseVisualStyleBackColor = true;
            this.Btn_Down.Click += new System.EventHandler(this.Btn_Down_Click);
            // 
            // Btn_Up
            // 
            this.Btn_Up.Location = new System.Drawing.Point(339, 149);
            this.Btn_Up.Name = "Btn_Up";
            this.Btn_Up.Size = new System.Drawing.Size(40, 40);
            this.Btn_Up.TabIndex = 1005;
            this.Btn_Up.Text = "^";
            this.Btn_Up.UseVisualStyleBackColor = true;
            this.Btn_Up.Click += new System.EventHandler(this.Btn_Up_Click);
            // 
            // Btn_SaveOrder
            // 
            this.Btn_SaveOrder.BackColor = System.Drawing.Color.Green;
            this.Btn_SaveOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_SaveOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SaveOrder.ForeColor = System.Drawing.Color.White;
            this.Btn_SaveOrder.Location = new System.Drawing.Point(532, 3);
            this.Btn_SaveOrder.Name = "Btn_SaveOrder";
            this.Btn_SaveOrder.Size = new System.Drawing.Size(77, 39);
            this.Btn_SaveOrder.TabIndex = 1006;
            this.Btn_SaveOrder.Text = "Salvar";
            this.Btn_SaveOrder.UseVisualStyleBackColor = false;
            this.Btn_SaveOrder.Click += new System.EventHandler(this.Btn_SaveOrder_Click);
            // 
            // ReorderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Launcher_FiveM_CS.Properties.Resources.bg2;
            this.ClientSize = new System.Drawing.Size(638, 408);
            this.ControlBox = false;
            this.Controls.Add(this.Btn_SaveOrder);
            this.Controls.Add(this.Btn_Up);
            this.Controls.Add(this.Btn_Down);
            this.Controls.Add(this.Lbl_Help);
            this.Controls.Add(this.List_ServerList);
            this.Controls.Add(this.Lbl_Spacer);
            this.Controls.Add(this.Btn_NextStep);
            this.Controls.Add(this.Lbl_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReorderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações Gerais";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ReorderForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Btn_NextStep;
        private System.Windows.Forms.Label Lbl_Title;
        private System.Windows.Forms.Label Lbl_Spacer;
        private System.Windows.Forms.ListBox List_ServerList;
        private System.Windows.Forms.Label Lbl_Help;
        private System.Windows.Forms.Button Btn_Down;
        private System.Windows.Forms.Button Btn_Up;
        private System.Windows.Forms.Button Btn_SaveOrder;
    }
}

