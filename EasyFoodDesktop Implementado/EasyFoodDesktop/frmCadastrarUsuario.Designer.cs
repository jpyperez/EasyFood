namespace EasyFoodDesktop
{
    partial class frmCadastrarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarUsuario));
            this.btnVoltar = new System.Windows.Forms.Button();
            this.ofdImagem = new System.Windows.Forms.OpenFileDialog();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.pbImagem = new System.Windows.Forms.PictureBox();
            this.cobTipoFunc = new System.Windows.Forms.ComboBox();
            this.btnEscolher = new System.Windows.Forms.Button();
            this.txtSenha = new TextBoxAutoexplicativo.txtAutoexplicativo();
            this.txtNome = new TextBoxAutoexplicativo.txtAutoexplicativo();
            this.txtLogin = new TextBoxAutoexplicativo.txtAutoexplicativo();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).BeginInit();
            this.SuspendLayout();
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
            this.btnVoltar.TabIndex = 7;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // ofdImagem
            // 
            this.ofdImagem.FileName = "openFileDialog1";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackgroundImage = global::EasyFoodDesktop.Properties.Resources.botaocadastrar;
            this.btnCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Location = new System.Drawing.Point(675, 436);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(122, 40);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // pbImagem
            // 
            this.pbImagem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pbImagem.Image = global::EasyFoodDesktop.Properties.Resources.boneco;
            this.pbImagem.Location = new System.Drawing.Point(111, 195);
            this.pbImagem.Name = "pbImagem";
            this.pbImagem.Size = new System.Drawing.Size(193, 172);
            this.pbImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagem.TabIndex = 37;
            this.pbImagem.TabStop = false;
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
            this.cobTipoFunc.Location = new System.Drawing.Point(415, 372);
            this.cobTipoFunc.Name = "cobTipoFunc";
            this.cobTipoFunc.Size = new System.Drawing.Size(443, 29);
            this.cobTipoFunc.TabIndex = 4;
            this.cobTipoFunc.Text = "Tipo de Funcionário";
            // 
            // btnEscolher
            // 
            this.btnEscolher.BackgroundImage = global::EasyFoodDesktop.Properties.Resources.botaoimagem;
            this.btnEscolher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEscolher.FlatAppearance.BorderSize = 0;
            this.btnEscolher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEscolher.Location = new System.Drawing.Point(517, 436);
            this.btnEscolher.Name = "btnEscolher";
            this.btnEscolher.Size = new System.Drawing.Size(122, 40);
            this.btnEscolher.TabIndex = 5;
            this.btnEscolher.UseVisualStyleBackColor = true;
            this.btnEscolher.Click += new System.EventHandler(this.btnEscolher_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtSenha.Font = new System.Drawing.Font("Sansation", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtSenha.Location = new System.Drawing.Point(415, 309);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(443, 22);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.TextoVacio = "Senha";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtNome.Font = new System.Drawing.Font("Sansation", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtNome.Location = new System.Drawing.Point(415, 237);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(443, 22);
            this.txtNome.TabIndex = 2;
            this.txtNome.TextoVacio = "Nome";
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLogin.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtLogin.Font = new System.Drawing.Font("Sansation", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtLogin.Location = new System.Drawing.Point(415, 169);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(443, 22);
            this.txtLogin.TabIndex = 1;
            this.txtLogin.TextoVacio = "Login";
            // 
            // frmCadastrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::EasyFoodDesktop.Properties.Resources.telacadastronew;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(992, 609);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.btnEscolher);
            this.Controls.Add(this.cobTipoFunc);
            this.Controls.Add(this.pbImagem);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCadastrar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadastrarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastrarUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.OpenFileDialog ofdImagem;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.PictureBox pbImagem;
        private System.Windows.Forms.ComboBox cobTipoFunc;
        private System.Windows.Forms.Button btnEscolher;
        private TextBoxAutoexplicativo.txtAutoexplicativo txtSenha;
        private TextBoxAutoexplicativo.txtAutoexplicativo txtNome;
        private TextBoxAutoexplicativo.txtAutoexplicativo txtLogin;
    }
}