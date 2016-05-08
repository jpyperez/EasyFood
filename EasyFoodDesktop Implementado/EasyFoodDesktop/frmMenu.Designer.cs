namespace EasyFoodDesktop
{
    partial class frmMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.lblCadProd = new System.Windows.Forms.Label();
            this.lblAltProd = new System.Windows.Forms.Label();
            this.lblExcProd = new System.Windows.Forms.Label();
            this.lblConsPed = new System.Windows.Forms.Label();
            this.lblConsProd = new System.Windows.Forms.Label();
            this.tmrData = new System.Windows.Forms.Timer(this.components);
            this.lblEditarStatus = new System.Windows.Forms.Label();
            this.btnEditarStatus = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblDataHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnConsProd = new System.Windows.Forms.Button();
            this.btnExcProd = new System.Windows.Forms.Button();
            this.btnConsPed = new System.Windows.Forms.Button();
            this.btnAltProd = new System.Windows.Forms.Button();
            this.btnCadProd = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tspiProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.tspiCadProd = new System.Windows.Forms.ToolStripMenuItem();
            this.tspiAltProd = new System.Windows.Forms.ToolStripMenuItem();
            this.tspiExcProd = new System.Windows.Forms.ToolStripMenuItem();
            this.tspiCadTipProd = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tspiAltTipProd = new System.Windows.Forms.ToolStripMenuItem();
            this.tspiExcTipProd = new System.Windows.Forms.ToolStripMenuItem();
            this.pToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tspiCons = new System.Windows.Forms.ToolStripMenuItem();
            this.tspiConsProd = new System.Windows.Forms.ToolStripMenuItem();
            this.tspiConsPed = new System.Windows.Forms.ToolStripMenuItem();
            this.tspiMapa = new System.Windows.Forms.ToolStripMenuItem();
            this.tspiCalculadora = new System.Windows.Forms.ToolStripMenuItem();
            this.tspiAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tspiFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.tspiCadFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.tspiAltFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.tspiExcFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGanhos = new System.Windows.Forms.Label();
            this.lblTaxaEasyFood = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCadProd
            // 
            this.lblCadProd.AutoSize = true;
            this.lblCadProd.BackColor = System.Drawing.Color.Transparent;
            this.lblCadProd.Font = new System.Drawing.Font("Sansation", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadProd.ForeColor = System.Drawing.Color.Silver;
            this.lblCadProd.Location = new System.Drawing.Point(164, 315);
            this.lblCadProd.Name = "lblCadProd";
            this.lblCadProd.Size = new System.Drawing.Size(136, 17);
            this.lblCadProd.TabIndex = 8;
            this.lblCadProd.Text = "Adicionar Produto";
            // 
            // lblAltProd
            // 
            this.lblAltProd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAltProd.AutoSize = true;
            this.lblAltProd.BackColor = System.Drawing.Color.Transparent;
            this.lblAltProd.Font = new System.Drawing.Font("Sansation", 12F, System.Drawing.FontStyle.Bold);
            this.lblAltProd.ForeColor = System.Drawing.Color.Silver;
            this.lblAltProd.Location = new System.Drawing.Point(458, 315);
            this.lblAltProd.Name = "lblAltProd";
            this.lblAltProd.Size = new System.Drawing.Size(133, 17);
            this.lblAltProd.TabIndex = 9;
            this.lblAltProd.Text = "Atualizar Produto";
            // 
            // lblExcProd
            // 
            this.lblExcProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExcProd.AutoSize = true;
            this.lblExcProd.BackColor = System.Drawing.Color.Transparent;
            this.lblExcProd.Font = new System.Drawing.Font("Sansation", 12F, System.Drawing.FontStyle.Bold);
            this.lblExcProd.ForeColor = System.Drawing.Color.Silver;
            this.lblExcProd.Location = new System.Drawing.Point(741, 315);
            this.lblExcProd.Name = "lblExcProd";
            this.lblExcProd.Size = new System.Drawing.Size(115, 17);
            this.lblExcProd.TabIndex = 10;
            this.lblExcProd.Text = "Excluir Produto";
            // 
            // lblConsPed
            // 
            this.lblConsPed.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblConsPed.AutoSize = true;
            this.lblConsPed.BackColor = System.Drawing.Color.Transparent;
            this.lblConsPed.Font = new System.Drawing.Font("Sansation", 12F, System.Drawing.FontStyle.Bold);
            this.lblConsPed.ForeColor = System.Drawing.Color.Silver;
            this.lblConsPed.Location = new System.Drawing.Point(458, 607);
            this.lblConsPed.Name = "lblConsPed";
            this.lblConsPed.Size = new System.Drawing.Size(139, 17);
            this.lblConsPed.TabIndex = 12;
            this.lblConsPed.Text = "Consultar Pedidos";
            // 
            // lblConsProd
            // 
            this.lblConsProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConsProd.AutoSize = true;
            this.lblConsProd.BackColor = System.Drawing.Color.Transparent;
            this.lblConsProd.Font = new System.Drawing.Font("Sansation", 12F, System.Drawing.FontStyle.Bold);
            this.lblConsProd.ForeColor = System.Drawing.Color.Silver;
            this.lblConsProd.Location = new System.Drawing.Point(733, 607);
            this.lblConsProd.Name = "lblConsProd";
            this.lblConsProd.Size = new System.Drawing.Size(145, 17);
            this.lblConsProd.TabIndex = 13;
            this.lblConsProd.Text = "Consultar Produtos";
            // 
            // tmrData
            // 
            this.tmrData.Interval = 1000;
            this.tmrData.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblEditarStatus
            // 
            this.lblEditarStatus.AutoSize = true;
            this.lblEditarStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblEditarStatus.Font = new System.Drawing.Font("Sansation", 12F, System.Drawing.FontStyle.Bold);
            this.lblEditarStatus.ForeColor = System.Drawing.Color.Silver;
            this.lblEditarStatus.Location = new System.Drawing.Point(180, 607);
            this.lblEditarStatus.Name = "lblEditarStatus";
            this.lblEditarStatus.Size = new System.Drawing.Size(110, 17);
            this.lblEditarStatus.TabIndex = 40;
            this.lblEditarStatus.Text = "Editar Produto";
            // 
            // btnEditarStatus
            // 
            this.btnEditarStatus.BackgroundImage = global::EasyFoodDesktop.Properties.Resources.botaoeditar;
            this.btnEditarStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditarStatus.FlatAppearance.BorderSize = 0;
            this.btnEditarStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarStatus.Location = new System.Drawing.Point(143, 420);
            this.btnEditarStatus.Name = "btnEditarStatus";
            this.btnEditarStatus.Size = new System.Drawing.Size(180, 172);
            this.btnEditarStatus.TabIndex = 39;
            this.btnEditarStatus.UseVisualStyleBackColor = true;
            this.btnEditarStatus.Click += new System.EventHandler(this.btnEditarStatus_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.BackgroundImage = global::EasyFoodDesktop.Properties.Resources.barrainf;
            this.statusStrip1.Font = new System.Drawing.Font("Sansation", 12F, System.Drawing.FontStyle.Bold);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblDataHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 678);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1024, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblDataHora
            // 
            this.lblDataHora.BackColor = System.Drawing.Color.Transparent;
            this.lblDataHora.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataHora.ForeColor = System.Drawing.Color.White;
            this.lblDataHora.Name = "lblDataHora";
            this.lblDataHora.Size = new System.Drawing.Size(90, 17);
            this.lblDataHora.Text = "lblDataHora";
            // 
            // btnConsProd
            // 
            this.btnConsProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsProd.BackgroundImage = global::EasyFoodDesktop.Properties.Resources.botaoconsprod;
            this.btnConsProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConsProd.FlatAppearance.BorderSize = 0;
            this.btnConsProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsProd.Location = new System.Drawing.Point(707, 420);
            this.btnConsProd.Name = "btnConsProd";
            this.btnConsProd.Size = new System.Drawing.Size(180, 172);
            this.btnConsProd.TabIndex = 6;
            this.btnConsProd.UseVisualStyleBackColor = true;
            this.btnConsProd.Click += new System.EventHandler(this.btnConsProd_Click);
            // 
            // btnExcProd
            // 
            this.btnExcProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcProd.BackgroundImage = global::EasyFoodDesktop.Properties.Resources.botaoexcluir;
            this.btnExcProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcProd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExcProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcProd.Location = new System.Drawing.Point(707, 130);
            this.btnExcProd.Name = "btnExcProd";
            this.btnExcProd.Size = new System.Drawing.Size(180, 172);
            this.btnExcProd.TabIndex = 5;
            this.btnExcProd.UseVisualStyleBackColor = true;
            this.btnExcProd.Click += new System.EventHandler(this.btnExcProd_Click);
            // 
            // btnConsPed
            // 
            this.btnConsPed.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnConsPed.BackgroundImage = global::EasyFoodDesktop.Properties.Resources.botaoconsultar;
            this.btnConsPed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConsPed.FlatAppearance.BorderSize = 0;
            this.btnConsPed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsPed.Location = new System.Drawing.Point(430, 420);
            this.btnConsPed.Name = "btnConsPed";
            this.btnConsPed.Size = new System.Drawing.Size(180, 172);
            this.btnConsPed.TabIndex = 4;
            this.btnConsPed.UseVisualStyleBackColor = true;
            this.btnConsPed.Click += new System.EventHandler(this.btnConsPed_Click);
            // 
            // btnAltProd
            // 
            this.btnAltProd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAltProd.BackgroundImage = global::EasyFoodDesktop.Properties.Resources.botaoatualizar;
            this.btnAltProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAltProd.FlatAppearance.BorderSize = 0;
            this.btnAltProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltProd.Location = new System.Drawing.Point(430, 130);
            this.btnAltProd.Name = "btnAltProd";
            this.btnAltProd.Size = new System.Drawing.Size(180, 172);
            this.btnAltProd.TabIndex = 3;
            this.btnAltProd.UseVisualStyleBackColor = true;
            this.btnAltProd.Click += new System.EventHandler(this.btnAltProd_Click);
            // 
            // btnCadProd
            // 
            this.btnCadProd.BackgroundImage = global::EasyFoodDesktop.Properties.Resources.botaoadicionar;
            this.btnCadProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadProd.FlatAppearance.BorderSize = 0;
            this.btnCadProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadProd.Location = new System.Drawing.Point(143, 130);
            this.btnCadProd.Name = "btnCadProd";
            this.btnCadProd.Size = new System.Drawing.Size(180, 172);
            this.btnCadProd.TabIndex = 2;
            this.btnCadProd.UseVisualStyleBackColor = true;
            this.btnCadProd.Click += new System.EventHandler(this.btnCadProd_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::EasyFoodDesktop.Properties.Resources.barrasup;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Font = new System.Drawing.Font("Sansation", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspiProdutos,
            this.tspiCadTipProd,
            this.pToolStripMenuItem,
            this.tspiCons,
            this.tspiCalculadora,
            this.tspiAjuda,
            this.sairToolStripMenuItem,
            this.tspiFuncionarios});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1024, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tspiProdutos
            // 
            this.tspiProdutos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspiCadProd,
            this.tspiAltProd,
            this.tspiExcProd});
            this.tspiProdutos.Font = new System.Drawing.Font("Sansation", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tspiProdutos.ForeColor = System.Drawing.Color.White;
            this.tspiProdutos.Name = "tspiProdutos";
            this.tspiProdutos.Size = new System.Drawing.Size(100, 25);
            this.tspiProdutos.Text = "Produtos";
            // 
            // tspiCadProd
            // 
            this.tspiCadProd.Name = "tspiCadProd";
            this.tspiCadProd.Size = new System.Drawing.Size(165, 26);
            this.tspiCadProd.Text = "Cadastrar";
            this.tspiCadProd.Click += new System.EventHandler(this.tspiCadProd_Click);
            // 
            // tspiAltProd
            // 
            this.tspiAltProd.Name = "tspiAltProd";
            this.tspiAltProd.Size = new System.Drawing.Size(165, 26);
            this.tspiAltProd.Text = "Alterar";
            this.tspiAltProd.Click += new System.EventHandler(this.tspiAltProd_Click);
            // 
            // tspiExcProd
            // 
            this.tspiExcProd.Name = "tspiExcProd";
            this.tspiExcProd.Size = new System.Drawing.Size(165, 26);
            this.tspiExcProd.Text = "Excluir";
            this.tspiExcProd.Click += new System.EventHandler(this.tspiExcProd_Click);
            // 
            // tspiCadTipProd
            // 
            this.tspiCadTipProd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem1,
            this.tspiAltTipProd,
            this.tspiExcTipProd});
            this.tspiCadTipProd.Font = new System.Drawing.Font("Sansation", 14.25F, System.Drawing.FontStyle.Bold);
            this.tspiCadTipProd.ForeColor = System.Drawing.Color.White;
            this.tspiCadTipProd.Name = "tspiCadTipProd";
            this.tspiCadTipProd.Size = new System.Drawing.Size(166, 25);
            this.tspiCadTipProd.Text = "Tipo de Produtos";
            // 
            // cadastrarToolStripMenuItem1
            // 
            this.cadastrarToolStripMenuItem1.Name = "cadastrarToolStripMenuItem1";
            this.cadastrarToolStripMenuItem1.Size = new System.Drawing.Size(165, 26);
            this.cadastrarToolStripMenuItem1.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem1.Click += new System.EventHandler(this.cadastrarToolStripMenuItem1_Click);
            // 
            // tspiAltTipProd
            // 
            this.tspiAltTipProd.Name = "tspiAltTipProd";
            this.tspiAltTipProd.Size = new System.Drawing.Size(165, 26);
            this.tspiAltTipProd.Text = "Alterar";
            this.tspiAltTipProd.Click += new System.EventHandler(this.tspiAltTipProd_Click);
            // 
            // tspiExcTipProd
            // 
            this.tspiExcTipProd.Name = "tspiExcTipProd";
            this.tspiExcTipProd.Size = new System.Drawing.Size(165, 26);
            this.tspiExcTipProd.Text = "Excluir";
            this.tspiExcTipProd.Click += new System.EventHandler(this.tspiExcTipProd_Click);
            // 
            // pToolStripMenuItem
            // 
            this.pToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alterarToolStripMenuItem});
            this.pToolStripMenuItem.Font = new System.Drawing.Font("Sansation", 14.25F, System.Drawing.FontStyle.Bold);
            this.pToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.pToolStripMenuItem.Name = "pToolStripMenuItem";
            this.pToolStripMenuItem.Size = new System.Drawing.Size(92, 25);
            this.pToolStripMenuItem.Text = "Pedidos";
            // 
            // alterarToolStripMenuItem
            // 
            this.alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
            this.alterarToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.alterarToolStripMenuItem.Text = "Alterar";
            this.alterarToolStripMenuItem.Click += new System.EventHandler(this.alterarToolStripMenuItem_Click);
            // 
            // tspiCons
            // 
            this.tspiCons.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspiConsProd,
            this.tspiConsPed,
            this.tspiMapa});
            this.tspiCons.Font = new System.Drawing.Font("Sansation", 14.25F, System.Drawing.FontStyle.Bold);
            this.tspiCons.ForeColor = System.Drawing.Color.White;
            this.tspiCons.Name = "tspiCons";
            this.tspiCons.Size = new System.Drawing.Size(110, 25);
            this.tspiCons.Text = "Consultas";
            // 
            // tspiConsProd
            // 
            this.tspiConsProd.Name = "tspiConsProd";
            this.tspiConsProd.Size = new System.Drawing.Size(180, 26);
            this.tspiConsProd.Text = "Produtos";
            this.tspiConsProd.Click += new System.EventHandler(this.tspiConsProd_Click);
            // 
            // tspiConsPed
            // 
            this.tspiConsPed.Name = "tspiConsPed";
            this.tspiConsPed.Size = new System.Drawing.Size(180, 26);
            this.tspiConsPed.Text = "Pedidos";
            this.tspiConsPed.Click += new System.EventHandler(this.tspiConsPed_Click);
            // 
            // tspiMapa
            // 
            this.tspiMapa.Name = "tspiMapa";
            this.tspiMapa.Size = new System.Drawing.Size(180, 26);
            this.tspiMapa.Text = "Local Mapa";
            this.tspiMapa.Click += new System.EventHandler(this.tspiMapa_Click);
            // 
            // tspiCalculadora
            // 
            this.tspiCalculadora.Font = new System.Drawing.Font("Sansation", 14.25F, System.Drawing.FontStyle.Bold);
            this.tspiCalculadora.ForeColor = System.Drawing.Color.White;
            this.tspiCalculadora.Name = "tspiCalculadora";
            this.tspiCalculadora.Size = new System.Drawing.Size(126, 25);
            this.tspiCalculadora.Text = "Calculadora";
            this.tspiCalculadora.Click += new System.EventHandler(this.tspiCalculadora_Click);
            // 
            // tspiAjuda
            // 
            this.tspiAjuda.Font = new System.Drawing.Font("Sansation", 14.25F, System.Drawing.FontStyle.Bold);
            this.tspiAjuda.ForeColor = System.Drawing.Color.White;
            this.tspiAjuda.Name = "tspiAjuda";
            this.tspiAjuda.Size = new System.Drawing.Size(74, 25);
            this.tspiAjuda.Text = "Ajuda";
            this.tspiAjuda.Click += new System.EventHandler(this.tspiAjuda_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Font = new System.Drawing.Font("Sansation", 14.25F, System.Drawing.FontStyle.Bold);
            this.sairToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(56, 25);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // tspiFuncionarios
            // 
            this.tspiFuncionarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspiCadFuncionarios,
            this.tspiAltFuncionarios,
            this.tspiExcFuncionarios,
            this.consultarToolStripMenuItem});
            this.tspiFuncionarios.Font = new System.Drawing.Font("Sansation", 14.25F, System.Drawing.FontStyle.Bold);
            this.tspiFuncionarios.ForeColor = System.Drawing.Color.White;
            this.tspiFuncionarios.Name = "tspiFuncionarios";
            this.tspiFuncionarios.Size = new System.Drawing.Size(134, 25);
            this.tspiFuncionarios.Text = "&Funcionarios";
            this.tspiFuncionarios.Visible = false;
            this.tspiFuncionarios.Click += new System.EventHandler(this.tspiFuncionarios_Click);
            // 
            // tspiCadFuncionarios
            // 
            this.tspiCadFuncionarios.Name = "tspiCadFuncionarios";
            this.tspiCadFuncionarios.Size = new System.Drawing.Size(165, 26);
            this.tspiCadFuncionarios.Text = "&Cadastrar";
            this.tspiCadFuncionarios.Click += new System.EventHandler(this.tspiCadFuncionarios_Click);
            // 
            // tspiAltFuncionarios
            // 
            this.tspiAltFuncionarios.Name = "tspiAltFuncionarios";
            this.tspiAltFuncionarios.Size = new System.Drawing.Size(165, 26);
            this.tspiAltFuncionarios.Text = "&Alterar";
            this.tspiAltFuncionarios.Click += new System.EventHandler(this.tspiAltFuncionarios_Click);
            // 
            // tspiExcFuncionarios
            // 
            this.tspiExcFuncionarios.Name = "tspiExcFuncionarios";
            this.tspiExcFuncionarios.Size = new System.Drawing.Size(165, 26);
            this.tspiExcFuncionarios.Text = "&Excluir";
            this.tspiExcFuncionarios.Click += new System.EventHandler(this.tspiExcFuncionarios_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.consultarToolStripMenuItem.Text = "&Consultar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sansation", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(543, 679);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 41;
            this.label1.Text = "Ganhos Totais:";
            // 
            // lblGanhos
            // 
            this.lblGanhos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGanhos.AutoSize = true;
            this.lblGanhos.BackColor = System.Drawing.Color.Transparent;
            this.lblGanhos.Font = new System.Drawing.Font("Sansation", 12F, System.Drawing.FontStyle.Bold);
            this.lblGanhos.ForeColor = System.Drawing.Color.White;
            this.lblGanhos.Location = new System.Drawing.Point(656, 679);
            this.lblGanhos.Name = "lblGanhos";
            this.lblGanhos.Size = new System.Drawing.Size(26, 17);
            this.lblGanhos.TabIndex = 42;
            this.lblGanhos.Text = "R$";
            // 
            // lblTaxaEasyFood
            // 
            this.lblTaxaEasyFood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTaxaEasyFood.AutoSize = true;
            this.lblTaxaEasyFood.BackColor = System.Drawing.Color.Transparent;
            this.lblTaxaEasyFood.Font = new System.Drawing.Font("Sansation", 12F, System.Drawing.FontStyle.Bold);
            this.lblTaxaEasyFood.ForeColor = System.Drawing.Color.White;
            this.lblTaxaEasyFood.Location = new System.Drawing.Point(901, 679);
            this.lblTaxaEasyFood.Name = "lblTaxaEasyFood";
            this.lblTaxaEasyFood.Size = new System.Drawing.Size(26, 17);
            this.lblTaxaEasyFood.TabIndex = 44;
            this.lblTaxaEasyFood.Text = "R$";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Sansation", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(785, 679);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 43;
            this.label3.Text = "Taxa EasyFood:";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::EasyFoodDesktop.Properties.Resources.telaMenuPrinc;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 700);
            this.ControlBox = false;
            this.Controls.Add(this.lblTaxaEasyFood);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblGanhos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEditarStatus);
            this.Controls.Add(this.btnEditarStatus);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblConsProd);
            this.Controls.Add(this.lblConsPed);
            this.Controls.Add(this.lblExcProd);
            this.Controls.Add(this.lblAltProd);
            this.Controls.Add(this.lblCadProd);
            this.Controls.Add(this.btnConsProd);
            this.Controls.Add(this.btnExcProd);
            this.Controls.Add(this.btnConsPed);
            this.Controls.Add(this.btnAltProd);
            this.Controls.Add(this.btnCadProd);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tspiProdutos;
        private System.Windows.Forms.ToolStripMenuItem tspiCadProd;
        private System.Windows.Forms.ToolStripMenuItem tspiExcProd;
        private System.Windows.Forms.ToolStripMenuItem tspiAltProd;
        private System.Windows.Forms.ToolStripMenuItem tspiCadTipProd;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tspiExcTipProd;
        private System.Windows.Forms.ToolStripMenuItem tspiAltTipProd;
        private System.Windows.Forms.ToolStripMenuItem tspiCons;
        private System.Windows.Forms.ToolStripMenuItem tspiConsProd;
        private System.Windows.Forms.ToolStripMenuItem tspiConsPed;
        private System.Windows.Forms.Button btnCadProd;
        private System.Windows.Forms.Button btnAltProd;
        private System.Windows.Forms.Button btnConsPed;
        private System.Windows.Forms.Button btnExcProd;
        private System.Windows.Forms.Button btnConsProd;
        private System.Windows.Forms.Label lblCadProd;
        private System.Windows.Forms.Label lblAltProd;
        private System.Windows.Forms.Label lblExcProd;
        private System.Windows.Forms.Label lblConsPed;
        private System.Windows.Forms.Label lblConsProd;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblDataHora;
        private System.Windows.Forms.ToolStripMenuItem tspiAjuda;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem;
        private System.Windows.Forms.Timer tmrData;
        private System.Windows.Forms.ToolStripMenuItem tspiMapa;
        private System.Windows.Forms.Label lblEditarStatus;
        private System.Windows.Forms.Button btnEditarStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGanhos;
        private System.Windows.Forms.Label lblTaxaEasyFood;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem tspiCalculadora;
        private System.Windows.Forms.ToolStripMenuItem tspiFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem tspiCadFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem tspiAltFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem tspiExcFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
    }
}