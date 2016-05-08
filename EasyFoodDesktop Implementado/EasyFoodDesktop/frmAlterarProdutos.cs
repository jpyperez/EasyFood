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
    public partial class frmAlterarProdutos : Form
    {
        MySqlDataReader drBD;
        int nCodTipoProd = 0;
        public frmAlterarProdutos()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

            // String Connection com o MySQL (Local Host)
            string configuracaoBD = "server=localhost; userid=root; database=easyfood";
            MySqlConnection connBD = new MySqlConnection(configuracaoBD);

            try
            {
                connBD.Open();

                MySqlCommand sqlComm = new MySqlCommand();

                sqlComm = new MySqlCommand("SELECT PRODUTOS.CodProd Codigo, TIPOPRODUTOS.nomeTipoProd 'Tipo de Produto', PRODUTOS.NomeProd Nome, PRODUTOS.PrecoProd Preco FROM PRODUTOS, TIPOPRODUTOS WHERE codTipoProdFK = codTipoProd AND codProd = @codigo", connBD);
                sqlComm.Parameters.Clear();
                sqlComm.Parameters.Add("@codigo", MySqlDbType.Int32, 6).Value = txtCodigo.Text.Trim();
               
                // CommandType
                sqlComm.CommandType = CommandType.Text;
                sqlComm.Connection = connBD;

                sqlComm.ExecuteNonQuery();

                drBD = sqlComm.ExecuteReader();
                if (!drBD.HasRows)      // não tem linhas?
                {
                    MessageBox.Show("Não há dados referente à pesquisa realizada", "Mensagem");
                    return;
                }
                drBD.Close();

                // adaptadores para o gridView
                MySqlDataAdapter bdData = new MySqlDataAdapter();
                bdData.SelectCommand = sqlComm;
                DataTable bdDataSet = new DataTable();
                bdData.Fill(bdDataSet);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = bdDataSet;
                dgvProdutos.DataSource = bSource;
                bdData.Update(bdDataSet);

                // fechar o bd
                connBD.Close();

                // deixar o usuário editar
                txtNome.Enabled = true;
                txtNome.Focus();
                cobTipProd.Enabled = true;
                txtPreco.Enabled = true;
                btnAlterar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro");
                connBD.Close();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtPreco.Text == "" || cobTipProd.Text == "")
            {
                MessageBox.Show("Insira dados nos campos!", "Verificar");
                return;
            }

            if (MessageBox.Show("Deseja realmente atualizar?", "Confirmar atualização", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // String Connection com o MySQL (Local Host)
                string configuracaoBD = "server=localhost; userid=root; database=easyfood";
                MySqlConnection connBD = new MySqlConnection(configuracaoBD);

                try
                {
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

                    sqlComm = new MySqlCommand("UPDATE Produtos set nomeProd = @nome, codTipoProdFK = @tipoProd, precoProd = @preco WHERE codProd = @codigo", connBD);
                    sqlComm.Parameters.Clear();
                    sqlComm.Parameters.Add("@codigo", MySqlDbType.Int32, 6).Value = txtCodigo.Text.Trim();
                    sqlComm.Parameters.Add("@nome", MySqlDbType.VarChar,40).Value = txtNome.Text.Trim();
                    sqlComm.Parameters.Add("@tipoProd", MySqlDbType.Int32, 6).Value = nCodTipoProd;
                    sqlComm.Parameters.Add("@preco", MySqlDbType.Double, 9).Value = txtPreco.Text.Trim();

                    // CommandType
                    sqlComm.CommandType = CommandType.Text;
                    sqlComm.Connection = connBD;

                    sqlComm.ExecuteNonQuery();

                    connBD.Close();

                    MessageBox.Show("Dados atualizados com sucesso!", "Sucesso");
                   
                    // voltar ao estado normal
                    txtCodigo.Text = "";
                    txtNome.Enabled = false;
                    txtNome.Text = "";
                    cobTipProd.Enabled = false;
                    cobTipProd.Text = "";
                    txtPreco.Enabled = false;
                    txtPreco.Text = "";
                    txtCodigo.Focus();
                    btnAlterar.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message, "Erro");
                    connBD.Close();
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAlterarProdutos_Load(object sender, EventArgs e)
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
