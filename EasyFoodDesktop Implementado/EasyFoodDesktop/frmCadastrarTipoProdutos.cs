using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EasyFoodDesktop
{
    public partial class frmCadastrarTipoProdutos : Form
    {
        public frmCadastrarTipoProdutos()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // String Connection com o MySQL (Local Host)
            string configuracaoBD = "server=localhost; userid=root; database=easyfood";
            MySqlConnection connBD = new MySqlConnection(configuracaoBD);

            try
            {
                connBD.Open();
                MySqlCommand sqlComm = new MySqlCommand("INSERT INTO TipoProdutos (nomeTipoProd) values (@nome)", connBD);

                // Parâmetros para a pesquisa, cadastro ou exclusão de dados
                sqlComm.Parameters.Clear();
                sqlComm.Parameters.Add("@nome", MySqlDbType.VarChar, 40).Value = txtNome.Text;
                sqlComm.ExecuteNonQuery();

                // fechamento do bd
                connBD.Close();
                MessageBox.Show("Dado cadastrado com sucesso!", "Sucesso");

                // caixas de textos voltam ao normal
                txtNome.Focus();
                txtNome.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:\n" + ex.Message, "Erro");
                connBD.Close();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
