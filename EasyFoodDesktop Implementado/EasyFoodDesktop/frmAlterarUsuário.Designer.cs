namespace EasyFoodDesktop
{
    partial class frmAlterarUsuário
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
            this.cobTipoFunc = new System.Windows.Forms.ComboBox();
            this.btnEscolher = new System.Windows.Forms.Button();
            this.pbImagem = new System.Windows.Forms.PictureBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.ofdImagem = new System.Windows.Forms.OpenFileDialog();
            this.txtLogin = new TextBoxAutoexplicativo.txtAutoexplicativo();
            this.txtNome = new TextBoxAutoexplicativo.txtAutoexplicativo();
            this.txtSenha = new TextBoxAutoexplicativo.txtAutoexplicativo();
            this.txtConfirmarSenha = new TextBoxAutoexplicativo.txtAutoexplicativo();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // cobTipoFunc
            // 
            this.cobTipoFunc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cobTipoFunc.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cobTipoFunc.Font = new System.Drawing.Font("Sansation", 14.25F, System.Drawing.FontStyle.Bold);
            this.cobTipoFunc.FormattingEnabled = true;
            this.cobTipoFunc.Items.AddRange(new object[] {
            "Funcionario",
            "Administrador"});
            this.cobTipoFunc.Location = new System.Drawing.Point(415, 395);
            this.cobTipoFunc.Name = "cobTipoFunc";
            this.cobTipoFunc.Size = new System.Drawing.Size(444, 29);
            this.cobTipoFunc.TabIndex = 43;
            this.cobTipoFunc.Text = "Tipo de Funcionário";
            // 
            // btnEscolher
            // 
            this.btnEscolher.BackgroundImage = global::EasyFoodDesktop.Properties.Resources.botaoimagem;
            this.btnEscolher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEscolher.Enabled = false;
            this.btnEscolher.FlatAppearance.BorderSize = 0;
            this.btnEscolher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEscolher.Location = new System.Drawing.Point(528, 506);
            this.btnEscolher.Name = "btnEscolher";
            this.btnEscolher.Size = new System.Drawing.Size(122, 40);
            this.btnEscolher.TabIndex = 46;
            this.btnEscolher.UseVisualStyleBackColor = true;
            this.btnEscolher.Click += new System.EventHandler(this.btnEscolher_Click);
            // 
            // pbImagem
            // 
            this.pbImagem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pbImagem.Image = global::EasyFoodDesktop.Properties.Resources.boneco;
            this.pbImagem.Location = new System.Drawing.Point(111, 194);
            this.pbImagem.Name = "pbImagem";
            this.pbImagem.Size = new System.Drawing.Size(194, 173);
            this.pbImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagem.TabIndex = 45;
            this.pbImagem.TabStop = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.BackgroundImage = global::EasyFoodDesktop.Properties.Resources.voltar;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Location = new System.Drawing.Point(12, 566);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(31, 31);
            this.btnVoltar.TabIndex = 44;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackgroundImage = global::EasyFoodDesktop.Properties.Resources.botaoalterar1;
            this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Location = new System.Drawing.Point(684, 506);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(122, 40);
            this.btnAlterar.TabIndex = 40;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // ofdImagem
            // 
            this.ofdImagem.FileName = "openFileDialog1";
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLogin.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtLogin.Font = new System.Drawing.Font("Sansation", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtLogin.Location = new System.Drawing.Point(416, 144);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(443, 22);
            this.txtLogin.TabIndex = 48;
            this.txtLogin.TextoVacio = "Login";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtNome.Font = new System.Drawing.Font("Sansation", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtNome.Location = new System.Drawing.Point(415, 206);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(443, 22);
            this.txtNome.TabIndex = 49;
            this.txtNome.TextoVacio = "Novo Nome";
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtSenha.Font = new System.Drawing.Font("Sansation", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtSenha.Location = new System.Drawing.Point(416, 272);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(443, 22);
            this.txtSenha.TabIndex = 50;
            this.txtSenha.TextoVacio = "Nova Senha";
            // 
            // txtConfirmarSenha
            // 
            this.txtConfirmarSenha.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtConfirmarSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmarSenha.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtConfirmarSenha.Font = new System.Drawing.Font("Sansation", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtConfirmarSenha.Location = new System.Drawing.Point(416, 335);
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.Size = new System.Drawing.Size(443, 22);
            this.txtConfirmarSenha.TabIndex = 51;
            this.txtConfirmarSenha.TextoVacio = "Confirmar Senha";
            // 
            // frmAlterarUsuário
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EasyFoodDesktop.Properties.Resources.telaalterarusuarios;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(992, 609);
            this.Controls.Add(this.txtConfirmarSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.btnEscolher);
            this.Controls.Add(this.cobTipoFunc);
            this.Controls.Add(this.pbImagem);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAlterar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAlterarUsuário";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAlterarUsuário";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEscolher;
        private System.Windows.Forms.ComboBox cobTipoFunc;
        private System.Windows.Forms.PictureBox pbImagem;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.OpenFileDialog ofdImagem;
        private TextBoxAutoexplicativo.txtAutoexplicativo txtLogin;
        private TextBoxAutoexplicativo.txtAutoexplicativo txtNome;
        private TextBoxAutoexplicativo.txtAutoexplicativo txtSenha;
        private TextBoxAutoexplicativo.txtAutoexplicativo txtConfirmarSenha;
    }
}