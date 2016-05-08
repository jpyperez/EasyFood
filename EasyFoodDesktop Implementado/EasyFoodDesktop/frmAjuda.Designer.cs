namespace EasyFoodDesktop
{
    partial class frmAjuda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAjuda));
            this.lblNomeMenu = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblNomeMenu
            // 
            this.lblNomeMenu.AutoSize = true;
            this.lblNomeMenu.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeMenu.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeMenu.ForeColor = System.Drawing.Color.White;
            this.lblNomeMenu.Location = new System.Drawing.Point(394, 14);
            this.lblNomeMenu.Name = "lblNomeMenu";
            this.lblNomeMenu.Size = new System.Drawing.Size(47, 15);
            this.lblNomeMenu.TabIndex = 38;
            this.lblNomeMenu.Text = "Ajuda";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = global::EasyFoodDesktop.Properties.Resources.voltar;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Location = new System.Drawing.Point(12, 657);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(31, 31);
            this.btnVoltar.TabIndex = 39;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Sansation", 8.25F, System.Drawing.FontStyle.Bold);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Items.AddRange(new object[] {
            "1 - Tela de Cadastro",
            "",
            "Caso ainda não tenha um usuário no sistema easyfood, clique em cadastrar (na prim" +
                "eira tela do sistema) e escreva o nome e senha de usuário desejado e depois cada" +
                "strar",
            "novamente.",
            "",
            "",
            "2 - Tela de Login",
            "",
            "Caso não tenha um usuário cadastrado siga o passo 1. A tela de login é a primeira" +
                " tela do software onde é preciso se identificar para poder ter acesso ao sistema" +
                ". O ",
            "Primeiro campo em branco é para digitar o nome de usuário e o segundo campo a sen" +
                "ha correspondente, se os dados estiverem corretos basta clicar no botão entrar.",
            "",
            "3 - Menu",
            "",
            "O menu é a área em que é encontrado todos os serviços oferecidos para a manipulaç" +
                "ão de dados como Cadastrar, Alterar e Excluir Produtos. Basta clicar no serviço",
            "desejado para fazer sua utilização.",
            "",
            "4 - Tipo de Produtos",
            "",
            "4.1 Cadastrar um tipo de produto",
            "",
            "Para cadastrar um produto é necessarios que cadastre um tipo de produto primeiro," +
                " para isso, clique na aba Tipo de Produtos, na parte superior do software, e dep" +
                "ois ",
            "em cadastrar, enforme o Nome do tipo, por exemplo, Pizza, será exibido uma menssa" +
                "gem \"Dado Cadastrado Com Sucesso\".",
            "",
            "4.2 Alterar um tipo de produto",
            "",
            "O Processo de alteração do tipo de produto é muito simples, basta ir até a aba su" +
                "perior em Tipo de Produtos e clicar em alterar, digite o código do tipo de produ" +
                "to a ",
            "ser alterado, digite o novo nome e depois clique em alterar. Pronto!, produto alt" +
                "erado com sucesso.",
            "",
            "4.3 Excluir um tipo de produto",
            "",
            "Na aba superior, clique em Tipo de Produtos, escolha a forma de exclusão (pelo có" +
                "digo ou pelo nome) e digite o valor a ser excluido e clique no botão excluir.",
            "",
            "5 - Produtos",
            "",
            "5.1 Cadastrar um produto",
            "",
            "Com o tipo de produto já cadastrado, é possível cadastrar o produto, para isso, c" +
                "lique na aba Produtos e cadastrar, ou, vá no botão Cadastrar Produtos no ",
            "menu principal. Digite o sabor, por exemplo, Queijo, em seguida o tipo de produto" +
                ", e o preço do mesmo, será exibido uma mensagem \"Dado Cadastrado com sucesso\".",
            "",
            "5.2 Alterar um produto",
            "",
            "O processo de alteração do Produto é muito simples, para isso, clique na aba Prod" +
                "utos e alterar, ou, vá no botão Alterar Produtos no menu principal. Digite o cód" +
                "igo a ",
            "ser alterado, digite o novo nome, escolha o novo tipo e digite o novo preço, cliq" +
                "ue no botão alterar e surgirá uma mensagem perguntando se deseja realmente alter" +
                "ar, ",
            "clicando no sim exibirá uma mensagem que os \"Dados [foram] alterados com sucesso\"" +
                ", e os dados serão atualizados.Caso clique em não, nada será feito com o Produto" +
                ".",
            "",
            "5.3 Excluir um produto",
            "",
            "Na aba produtos clique em excluir ou vá no botão Excluir Produtos no menu princip" +
                "al, escolha a forma de exclusão (atráves do nome ou código) digite o nome ou o c" +
                "ódigo, ",
            "clique em pesquisar e depois em excluir e surgirá uma mensagem perguntando se des" +
                "eja realmente excluir, clicando no sim será exibido Dado excluido com sucesso.",
            "",
            "6 - Consultas",
            "",
            "6.1 Produtos",
            "",
            "Na aba consultas clique em produtos ou em Consultar Produtos no menu principal, e" +
                " logo será exibido uma tela para a escolha do dado que deseja consultar(Código o" +
                "u Nome), ",
            "digite o dado a ser consultado depois em pesquisar. Caso queira ver todos os prod" +
                "utos clique em mostrar tudo.",
            "",
            "6.2 Pedidos",
            "",
            "Na aba consultas clique em Pedidos ou em Consultar Pedidos no menu principal, esc" +
                "olha o tipo de dado a ser consultado, clique em pesquisar para realizar a pesqui" +
                "sa ou em ",
            "mostrar tudo para visualizar todos os registros.",
            "",
            "6.3 Local Mapa",
            "",
            "Na aba consultas clique em Local Mapa, digite a cidade, o bairro e a rua a ser pe" +
                "squisado, após estes passos, clique na imagem da lupa e será exibido o mapa com " +
                "o local pesquisado. ",
            "Na parte superior da tela temos duas opções, Voltar e Limpar, o voltar para volta" +
                "r ao menu principal e limpar para esvaziar os campos de cidade, bairro e rua.",
            "",
            "7 - Editar Status de Pedido",
            "",
            "Na aba Pedidos clique em alterar, ou, Editar Status no menu principal, digite o C" +
                "ódigo do Pedido que deseja alterar, clique em pesquisar e o campo Status do pedi" +
                "do será desbloqueado, ",
            "agora basta escolher o status desejado e clique em alterar, será exibido uma mens" +
                "agem de confirmação, clique em sim e será exibido uma mensagem de dados atualiza" +
                "dos com sucesso. ",
            "Se desejar consultar todos os Pedidos clique em Mostrar tudo.",
            "",
            "8 - Calculadora",
            "",
            "Caso seja necessário o apoio de uma calculadora, clique na aba calculadora, local" +
                "izado no menu superior e será executado a calculadora padrão do ",
            "windows."});
            this.listBox1.Location = new System.Drawing.Point(12, 51);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(876, 504);
            this.listBox1.TabIndex = 42;
            // 
            // frmAjuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::EasyFoodDesktop.Properties.Resources.fundo1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblNomeMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAjuda";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAjuda";
            this.Load += new System.EventHandler(this.frmAjuda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeMenu;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.ListBox listBox1;
    }
}