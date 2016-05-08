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
    public partial class frmCadastrarProdutos : Form
    {
        int nCodTipoProd = 0;

        public frmCadastrarProdutos()
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
                if (txtNome.Text == "" || cobTipProd.Text == "" || txtPreco.Text == "")
                {
                    MessageBox.Show("Insira dados nos campos!", "Verificar");
                    return;
                }

                connBD.Open();

                MySqlCommand sqlComm = new MySqlCommand();

                // verificar qual Tipo de Produto o usuário escolheu
                sqlComm = new MySqlCommand("SELECT codTipoProd, nomeTipoProd FROM tipoProdutos WHERE nomeTipoProd = @nomeFab", connBD);
                sqlComm.Parameters.Clear();
                sqlComm.Parameters.Add("@nomeFab", MySqlDbType.VarChar, 40).Value = cobTipProd.Text;

                // CommandType
                sqlComm.CommandType = CommandType.Text;
                sqlComm.Connection = connBD;

                MySqlDataReader drBD;
                drBD = sqlComm.ExecuteReader();

                // inserir valor do código em uma váriavel
                do
                {
                    if (drBD.HasRows) // tem item? 
                    {
                        drBD.Read();
                        nCodTipoProd = drBD.GetInt32(0);
                        break;
                    }
                } while (drBD.HasRows);

                drBD.Close();
                
                sqlComm = new MySqlCommand("INSERT INTO Produtos (nomeProd, codTipoProdFK, precoProd) values (@nome, @tipoProd, @preco)", connBD);
               
                // Parâmetros para a pesquisa, cadastro ou exclusão de dados
                sqlComm.Parameters.Clear();
                sqlComm.Parameters.Add("@nome", MySqlDbType.VarChar, 40).Value = txtNome.Text.Trim();
                sqlComm.Parameters.Add("@tipoProd", MySqlDbType.Int32, 6).Value = nCodTipoProd;
                sqlComm.Parameters.Add("@preco", MySqlDbType.Double, 8).Value = txtPreco.Text.Trim();
                sqlComm.ExecuteNonQuery();
               
                // fechamento do bd
                connBD.Close();
                MessageBox.Show("Dados cadastrados com sucesso!", "Sucesso");
                
                // caixas de textos voltam ao normal
                txtNome.Focus();
                cobTipProd.Text = "";
                txtNome.Text = "";
                txtPreco.Text = "";
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

        private void frmCadastrarProdutos_Load(object sender, EventArgs e)
        {
            // Listar na combo box os fabricantes

            // String Connection com o MySQL (Local Host)
            string configuracaoBD = "server=localhost; userid=root; database=easyfood";         
            MySqlConnection connBD = new MySqlConnection(configuracaoBD);
            
            try
            {
                connBD.Open();

                MySqlCommand sqlComm = new MySqlCommand("SELECT * FROM TipoProdutos", connBD);

                MySqlDataReader drBD;
                drBD = sqlComm.ExecuteReader();

                // listar todas as linhas
                if (drBD.HasRows)
                {
                    while (drBD.Read())
                    {
                        cobTipProd.Items.Add(drBD.GetString(1));
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro");
                connBD.Close();
            }
        }
        
    }
}