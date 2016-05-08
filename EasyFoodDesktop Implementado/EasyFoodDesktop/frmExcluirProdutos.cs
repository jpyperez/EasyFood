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
    public partial class frmExcluirProdutos : Form
    {
        MySqlDataReader drBD;

        public frmExcluirProdutos()
        {
            InitializeComponent();
        }

        private void rbNome_CheckedChanged(object sender, EventArgs e)
        {
            txtNome.Enabled = true;
            txtCodigo.Enabled = false;
            txtCodigo.Text = "";
            txtNome.Focus();
        }

        private void rbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            txtCodigo.Enabled = true;
            txtNome.Enabled = false;
            txtNome.Text = "";
            txtCodigo.Focus();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if ((rbCodigo.Checked && txtCodigo.Text == "") || (rbNome.Checked && txtNome.Text == ""))
            {
                MessageBox.Show("Insira dados nos campos!", "Erro");
                return;
            }

            // String Connection com o MySQL (Local Host)
            string configuracaoBD = "server=localhost; userid=root; database=easyfood";         
            MySqlConnection connBD = new MySqlConnection(configuracaoBD);
            
            try
            {
                connBD.Open();

                MySqlCommand sqlComm = new MySqlCommand();

                if(rbNome.Checked)                                                          // nome está checado?
                {
                    sqlComm = new MySqlCommand("SELECT PRODUTOS.CodProd Codigo, TIPOPRODUTOS.nomeTipoProd 'Tipo de Produto', PRODUTOS.NomeProd Nome, PRODUTOS.PrecoProd Preco FROM PRODUTOS, TIPOPRODUTOS WHERE codTipoProdFK = codTipoProd AND nomeProd LIKE @nome", connBD);
                    sqlComm.Parameters.Clear();
                    sqlComm.Parameters.Add("@nome", MySqlDbType.VarChar, 40).Value = "%" + txtNome.Text.Trim() + "%";
                }

                if (rbCodigo.Checked)                                                         // código está checado?
                {
                    sqlComm = new MySqlCommand("SELECT PRODUTOS.CodProd Codigo, TIPOPRODUTOS.nomeTipoProd 'Tipo de Produto', PRODUTOS.NomeProd Nome, PRODUTOS.PrecoProd Preco FROM PRODUTOS, TIPOPRODUTOS WHERE codTipoProdFK = codTipoProd AND codProd = @codigo", connBD);
                    sqlComm.Parameters.Clear();
                    sqlComm.Parameters.Add("@codigo", MySqlDbType.Int32, 6).Value = txtCodigo.Text.Trim();
                }

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

                btnExcluir.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro");
                connBD.Close();
            }
        }
       
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente Excluir?", "Confirmar exclusão", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                if ((rbCodigo.Checked && txtCodigo.Text == "") || (rbNome.Checked && txtNome.Text == ""))
                {
                    MessageBox.Show("Insira dados nos campos!", "Verificar");
                    return;
                }

                // String Connection com o MySQL (Local Host)
                string configuracaoBD = "server=localhost; userid=root; database=easyfood";
                MySqlConnection connBD = new MySqlConnection(configuracaoBD);

                try
                {
                    connBD.Open();

                    MySqlCommand sqlComm = new MySqlCommand();

                    if (rbNome.Checked)
                    {
                        if (MessageBox.Show("Deseja realmente excluir todos os produtos com o nome '" + txtNome.Text + "'?", "Confirmar exclusao", MessageBoxButtons.YesNo) == DialogResult.No)
                            return;
                    }

                    if (rbNome.Checked)                                                          // nome está checado?
                    {
                        sqlComm = new MySqlCommand("DELETE FROM Produtos WHERE nomeProd LIKE @nome", connBD);
                        sqlComm.Parameters.Clear();
                        sqlComm.Parameters.Add("@nome", MySqlDbType.VarChar, 40).Value = "%" + txtNome.Text.Trim() + "%";
                    }

                    if (rbCodigo.Checked)                                                         // código está checado?
                    {
                        sqlComm = new MySqlCommand("DELETE FROM Produtos WHERE codProd = @codigo", connBD);
                        sqlComm.Parameters.Clear();
                        sqlComm.Parameters.Add("@codigo", MySqlDbType.Int32, 6).Value = txtCodigo.Text.Trim();
                    }

                    // CommandType
                    sqlComm.CommandType = CommandType.Text;
                    sqlComm.Connection = connBD;

                    sqlComm.ExecuteNonQuery();

                    connBD.Close();

                    MessageBox.Show("Dado excluído com sucesso!", "Sucesso");

                    this.Close();
                }
                catch (Exception ex)
                {
                    if (ex.Message == "Cannot delete or update a parent row: a foreign key constraint fails (`easyfood`.`pedidos`, CONSTRAINT `FK_CODPROD` FOREIGN KEY (`CODPRODFK`) REFERENCES `produtos` (`CODPROD`))")
                        MessageBox.Show("Erro: Produto pode estar referenciando um pedido!", "Erro");
                    else
                        MessageBox.Show("Erro: " + ex.Message, "Erro");
                    connBD.Close();
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
