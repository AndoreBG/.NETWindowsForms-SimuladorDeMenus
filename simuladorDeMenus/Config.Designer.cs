namespace simuladorDeMenus
{
    partial class Config
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFundo = new System.Windows.Forms.Label();
            this.listCor = new System.Windows.Forms.ListBox();
            this.listImage = new System.Windows.Forms.ListBox();
            this.lblImagem = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.picBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(335, 55);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Configurações";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(580, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "*As mudanças só serão visiveis nessa aba";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFundo
            // 
            this.lblFundo.AutoSize = true;
            this.lblFundo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFundo.Location = new System.Drawing.Point(34, 97);
            this.lblFundo.Name = "lblFundo";
            this.lblFundo.Size = new System.Drawing.Size(162, 20);
            this.lblFundo.TabIndex = 2;
            this.lblFundo.Text = "Alterar a cor de fundo";
            // 
            // listCor
            // 
            this.listCor.BackColor = System.Drawing.SystemColors.Control;
            this.listCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCor.FormattingEnabled = true;
            this.listCor.ItemHeight = 20;
            this.listCor.Items.AddRange(new object[] {
            "Amarelo",
            "Branco",
            "Laranja",
            "Roxo",
            "Salmão-Doce",
            "Vermelho-Vinho"});
            this.listCor.Location = new System.Drawing.Point(34, 120);
            this.listCor.Name = "listCor";
            this.listCor.Size = new System.Drawing.Size(174, 124);
            this.listCor.Sorted = true;
            this.listCor.TabIndex = 3;
            this.listCor.SelectedIndexChanged += new System.EventHandler(this.listCor_SelectedIndexChanged);
            // 
            // listImage
            // 
            this.listImage.BackColor = System.Drawing.SystemColors.Control;
            this.listImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listImage.FormattingEnabled = true;
            this.listImage.ItemHeight = 20;
            this.listImage.Items.AddRange(new object[] {
            "everynyan",
            "giorno",
            "osaka",
            "quieres",
            "toro2"});
            this.listImage.Location = new System.Drawing.Point(274, 120);
            this.listImage.Name = "listImage";
            this.listImage.Size = new System.Drawing.Size(185, 104);
            this.listImage.TabIndex = 5;
            this.listImage.SelectedIndexChanged += new System.EventHandler(this.listImage_SelectedIndexChanged);
            // 
            // lblImagem
            // 
            this.lblImagem.AutoSize = true;
            this.lblImagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagem.Location = new System.Drawing.Point(274, 97);
            this.lblImagem.Name = "lblImagem";
            this.lblImagem.Size = new System.Drawing.Size(185, 20);
            this.lblImagem.TabIndex = 4;
            this.lblImagem.Text = "Alterar a imagem ao lado";
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(22, 398);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(200, 40);
            this.btnMenu.TabIndex = 9;
            this.btnMenu.Text = "Menu Inicial";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // picBox
            // 
            this.picBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBox.Image = global::simuladorDeMenus.Properties.Resources.everynyan;
            this.picBox.Location = new System.Drawing.Point(501, 120);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(265, 259);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 8;
            this.picBox.TabStop = false;
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.listImage);
            this.Controls.Add(this.lblImagem);
            this.Controls.Add(this.listCor);
            this.Controls.Add(this.lblFundo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Config";
            this.Text = "Configurações";
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFundo;
        private System.Windows.Forms.ListBox listCor;
        private System.Windows.Forms.ListBox listImage;
        private System.Windows.Forms.Label lblImagem;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Button btnMenu;
    }
}