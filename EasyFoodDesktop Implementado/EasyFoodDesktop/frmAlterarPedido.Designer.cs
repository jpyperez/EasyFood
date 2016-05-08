namespace EasyFoodDesktop
{
    partial class frmAlterarPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlterarPedido));
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.cobStatusPed = new System.Windows.Forms.ComboBox();
            this.txtCodPed = new System.Windows.Forms.TextBox();
            this.btnMostrarTudo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackgroundImage = global::EasyFoodDesktop.Properties.Resources.botaoalterar;
            this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlterar.Enabled = false;
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Location = new System.Drawing.Point(203, 350);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(122, 40);
            this.btnAlterar.TabIndex = 4;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoltar.BackgroundImage")));
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Location = new System.Drawing.Point(12, 447);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(31, 31);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackgroundImage = global::EasyFoodDesktop.Properties.Resources.botaopesquisar;
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Location = new System.Drawing.Point(33, 350);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(122, 40);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Location = new System.Drawing.Point(33, 188);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.Size = new System.Drawing.Size(459, 146);
            this.dgvPedidos.TabIndex = 30;
            // 
            // cobStatusPed
            // 
            this.cobStatusPed.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cobStatusPed.Enabled = false;
            this.cobStatusPed.Font = new System.Drawing.Font("Sansation", 8.25F, System.Drawing.FontStyle.Bold);
            this.cobStatusPed.FormattingEnabled = true;
            this.cobStatusPed.Items.AddRange(new object[] {
            "Em andamento",
            "A Caminho",
            "Cancelado",
            "Finalizado"});
            this.cobStatusPed.Location = new System.Drawing.Point(182, 138);
            this.cobStatusPed.Name = "cobStatusPed";
            this.cobStatusPed.Size = new System.Drawing.Size(164, 20);
            this.cobStatusPed.TabIndex = 2;
            // 
            // txtCodPed
            // 
            this.txtCodPed.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCodPed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodPed.Font = new System.Drawing.Font("Sansation", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtCodPed.Location = new System.Drawing.Point(183, 77);
            this.txtCodPed.MaxLength = 6;
            this.txtCodPed.Name = "txtCodPed";
            this.txtCodPed.Size = new System.Drawing.Size(163, 13);
            this.txtCodPed.TabIndex = 1;
            // 
            // btnMostrarTudo
            // 
            this.btnMostrarTudo.BackgroundImage = global::EasyFoodDesktop.Properties.Resources.botaomostrartudo;
            this.btnMostrarTudo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMostrarTudo.FlatAppearance.BorderSize = 0;
            this.btnMostrarTudo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarTudo.Location = new System.Drawing.Point(370, 350);
            this.btnMostrarTudo.Name = "btnMostrarTudo";
            this.btnMostrarTudo.Size = new System.Drawing.Size(122, 40);
            this.btnMostrarTudo.TabIndex = 5;
            this.btnMostrarTudo.UseVisualStyleBackColor = true;
            this.btnMostrarTudo.Click += new System.EventHandler(this.frmAlterarPedido_Load);
            // 
            // frmAlterarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::EasyFoodDesktop.Properties.Resources.telaalterarpedidos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(524, 490);
            this.Controls.Add(this.btnMostrarTudo);
            this.Controls.Add(this.txtCodPed);
            this.Controls.Add(this.cobStatusPed);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.dgvPedidos);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAlterarPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAlterarPedido";
            this.Load += new System.EventHandler(this.frmAlterarPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.ComboBox cobStatusPed;
        private System.Windows.Forms.TextBox txtCodPed;
        private System.Windows.Forms.Button btnMostrarTudo;
    }
}