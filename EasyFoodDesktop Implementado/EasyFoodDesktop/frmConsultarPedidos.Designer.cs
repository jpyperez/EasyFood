namespace EasyFoodDesktop
{
    partial class frmConsultarPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarPedidos));
            this.txtNomeUser = new System.Windows.Forms.TextBox();
            this.rbNomeUser = new System.Windows.Forms.RadioButton();
            this.txtCodPed = new System.Windows.Forms.TextBox();
            this.rbCodPed = new System.Windows.Forms.RadioButton();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.rbStatus = new System.Windows.Forms.RadioButton();
            this.cobStatusPed = new System.Windows.Forms.ComboBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnMostrarTudo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomeUser
            // 
            this.txtNomeUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNomeUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeUser.Enabled = false;
            this.txtNomeUser.Font = new System.Drawing.Font("Sansation", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtNomeUser.Location = new System.Drawing.Point(174, 169);
            this.txtNomeUser.MaxLength = 40;
            this.txtNomeUser.Name = "txtNomeUser";
            this.txtNomeUser.Size = new System.Drawing.Size(163, 13);
            this.txtNomeUser.TabIndex = 3;
            // 
            // rbNomeUser
            // 
            this.rbNomeUser.AutoSize = true;
            this.rbNomeUser.BackColor = System.Drawing.Color.Transparent;
            this.rbNomeUser.Location = new System.Drawing.Point(149, 167);
            this.rbNomeUser.Name = "rbNomeUser";
            this.rbNomeUser.Size = new System.Drawing.Size(14, 13);
            this.rbNomeUser.TabIndex = 27;
            this.rbNomeUser.TabStop = true;
            this.rbNomeUser.UseVisualStyleBackColor = false;
            this.rbNomeUser.CheckedChanged += new System.EventHandler(this.rbCodUser_CheckedChanged);
            // 
            // txtCodPed
            // 
            this.txtCodPed.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCodPed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodPed.Enabled = false;
            this.txtCodPed.Font = new System.Drawing.Font("Sansation", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtCodPed.Location = new System.Drawing.Point(174, 125);
            this.txtCodPed.MaxLength = 6;
            this.txtCodPed.Name = "txtCodPed";
            this.txtCodPed.Size = new System.Drawing.Size(163, 13);
            this.txtCodPed.TabIndex = 2;
            // 
            // rbCodPed
            // 
            this.rbCodPed.AutoSize = true;
            this.rbCodPed.BackColor = System.Drawing.Color.Transparent;
            this.rbCodPed.Location = new System.Drawing.Point(150, 124);
            this.rbCodPed.Name = "rbCodPed";
            this.rbCodPed.Size = new System.Drawing.Size(14, 13);
            this.rbCodPed.TabIndex = 26;
            this.rbCodPed.UseVisualStyleBackColor = false;
            this.rbCodPed.CheckedChanged += new System.EventHandler(this.rbCodPed_CheckedChanged);
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPedidos.Location = new System.Drawing.Point(23, 204);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.Size = new System.Drawing.Size(459, 251);
            this.dgvPedidos.TabIndex = 24;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.BackgroundImage = global::EasyFoodDesktop.Properties.Resources.voltar;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Location = new System.Drawing.Point(12, 542);
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
            this.btnPesquisar.Location = new System.Drawing.Point(23, 488);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(122, 40);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // rbStatus
            // 
            this.rbStatus.AutoSize = true;
            this.rbStatus.BackColor = System.Drawing.Color.Transparent;
            this.rbStatus.Location = new System.Drawing.Point(150, 77);
            this.rbStatus.Name = "rbStatus";
            this.rbStatus.Size = new System.Drawing.Size(14, 13);
            this.rbStatus.TabIndex = 42;
            this.rbStatus.UseVisualStyleBackColor = false;
            this.rbStatus.CheckedChanged += new System.EventHandler(this.rbStatus_CheckedChanged);
            // 
            // cobStatusPed
            // 
            this.cobStatusPed.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cobStatusPed.Enabled = false;
            this.cobStatusPed.Font = new System.Drawing.Font("Sansation", 8.25F, System.Drawing.FontStyle.Bold);
            this.cobStatusPed.FormattingEnabled = true;
            this.cobStatusPed.Items.AddRange(new object[] {
            "Verificar",
            "A Caminho",
            "Cancelado",
            "Finalizado"});
            this.cobStatusPed.Location = new System.Drawing.Point(174, 76);
            this.cobStatusPed.Name = "cobStatusPed";
            this.cobStatusPed.Size = new System.Drawing.Size(165, 20);
            this.cobStatusPed.TabIndex = 43;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackgroundImage = global::EasyFoodDesktop.Properties.Resources.botaoimprimir;
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Location = new System.Drawing.Point(191, 488);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(122, 40);
            this.btnImprimir.TabIndex = 44;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnMostrarTudo
            // 
            this.btnMostrarTudo.BackgroundImage = global::EasyFoodDesktop.Properties.Resources.botaomostrartudo;
            this.btnMostrarTudo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMostrarTudo.FlatAppearance.BorderSize = 0;
            this.btnMostrarTudo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarTudo.Location = new System.Drawing.Point(360, 488);
            this.btnMostrarTudo.Name = "btnMostrarTudo";
            this.btnMostrarTudo.Size = new System.Drawing.Size(122, 40);
            this.btnMostrarTudo.TabIndex = 45;
            this.btnMostrarTudo.UseVisualStyleBackColor = true;
            this.btnMostrarTudo.Click += new System.EventHandler(this.frmConsultarPedidos_Load);
            // 
            // frmConsultarPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::EasyFoodDesktop.Properties.Resources.telaconsultarpedido;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(507, 585);
            this.Controls.Add(this.btnMostrarTudo);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.cobStatusPed);
            this.Controls.Add(this.rbStatus);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.txtNomeUser);
            this.Controls.Add(this.rbNomeUser);
            this.Controls.Add(this.txtCodPed);
            this.Controls.Add(this.rbCodPed);
            this.Controls.Add(this.dgvPedidos);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultarPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultarPedidos";
            this.Load += new System.EventHandler(this.frmConsultarPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeUser;
        private System.Windows.Forms.RadioButton rbNomeUser;
        private System.Windows.Forms.TextBox txtCodPed;
        private System.Windows.Forms.RadioButton rbCodPed;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.RadioButton rbStatus;
        private System.Windows.Forms.ComboBox cobStatusPed;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnMostrarTudo;
    }
}