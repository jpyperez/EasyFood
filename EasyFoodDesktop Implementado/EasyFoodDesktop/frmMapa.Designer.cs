namespace EasyFoodDesktop
{
    partial class frmMapa
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
            this.wbGoogleMaps = new System.Windows.Forms.WebBrowser();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.tspiVoltar = new System.Windows.Forms.ToolStripMenuItem();
            this.tspiLimpar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMapa = new System.Windows.Forms.ToolStrip();
            this.menuStripMapa.SuspendLayout();
            this.SuspendLayout();
            // 
            // wbGoogleMaps
            // 
            this.wbGoogleMaps.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.wbGoogleMaps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wbGoogleMaps.Location = new System.Drawing.Point(12, 111);
            this.wbGoogleMaps.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbGoogleMaps.Name = "wbGoogleMaps";
            this.wbGoogleMaps.Size = new System.Drawing.Size(976, 410);
            this.wbGoogleMaps.TabIndex = 39;
            // 
            // txtCidade
            // 
            this.txtCidade.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCidade.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtCidade.Font = new System.Drawing.Font("Sansation", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtCidade.Location = new System.Drawing.Point(176, 75);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(173, 13);
            this.txtCidade.TabIndex = 1;
            // 
            // txtRua
            // 
            this.txtRua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRua.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtRua.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRua.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtRua.Font = new System.Drawing.Font("Sansation", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtRua.Location = new System.Drawing.Point(648, 75);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(173, 13);
            this.txtRua.TabIndex = 3;
            // 
            // txtBairro
            // 
            this.txtBairro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBairro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtBairro.Font = new System.Drawing.Font("Sansation", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtBairro.Location = new System.Drawing.Point(412, 75);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(176, 13);
            this.txtBairro.TabIndex = 2;
            // 
            // btnProcurar
            // 
            this.btnProcurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcurar.BackColor = System.Drawing.Color.Transparent;
            this.btnProcurar.BackgroundImage = global::EasyFoodDesktop.Properties.Resources.botaomapa;
            this.btnProcurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProcurar.FlatAppearance.BorderSize = 0;
            this.btnProcurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcurar.Location = new System.Drawing.Point(899, 45);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(60, 60);
            this.btnProcurar.TabIndex = 4;
            this.btnProcurar.UseVisualStyleBackColor = false;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.BackgroundImage = global::EasyFoodDesktop.Properties.Resources.voltar;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Location = new System.Drawing.Point(12, 525);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(31, 31);
            this.btnVoltar.TabIndex = 47;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // tspiVoltar
            // 
            this.tspiVoltar.Font = new System.Drawing.Font("Sansation", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tspiVoltar.ForeColor = System.Drawing.Color.White;
            this.tspiVoltar.Name = "tspiVoltar";
            this.tspiVoltar.Size = new System.Drawing.Size(75, 25);
            this.tspiVoltar.Text = "Voltar";
            this.tspiVoltar.Click += new System.EventHandler(this.tspiVoltar_Click);
            // 
            // tspiLimpar
            // 
            this.tspiLimpar.Font = new System.Drawing.Font("Sansation", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tspiLimpar.ForeColor = System.Drawing.Color.White;
            this.tspiLimpar.Name = "tspiLimpar";
            this.tspiLimpar.Size = new System.Drawing.Size(82, 25);
            this.tspiLimpar.Text = "Limpar";
            this.tspiLimpar.Click += new System.EventHandler(this.tspiLimpar_Click);
            // 
            // menuStripMapa
            // 
            this.menuStripMapa.BackColor = System.Drawing.Color.Transparent;
            this.menuStripMapa.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStripMapa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspiVoltar,
            this.tspiLimpar});
            this.menuStripMapa.Location = new System.Drawing.Point(0, 0);
            this.menuStripMapa.Name = "menuStripMapa";
            this.menuStripMapa.Size = new System.Drawing.Size(1000, 25);
            this.menuStripMapa.TabIndex = 48;
            this.menuStripMapa.Text = "toolStrip1";
            // 
            // frmMapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::EasyFoodDesktop.Properties.Resources.telamapa;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 568);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.wbGoogleMaps);
            this.Controls.Add(this.menuStripMapa);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMapa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMapa";
            this.menuStripMapa.ResumeLayout(false);
            this.menuStripMapa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbGoogleMaps;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.ToolStripMenuItem tspiVoltar;
        private System.Windows.Forms.ToolStripMenuItem tspiLimpar;
        private System.Windows.Forms.ToolStrip menuStripMapa;
    }
}