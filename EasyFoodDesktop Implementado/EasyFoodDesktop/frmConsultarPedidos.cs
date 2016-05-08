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
    public partial class frmConsultarPedidos : Form
    {

        MySqlDataReader drBD;

        public frmConsultarPedidos()
        {
            InitializeComponent();
        }

        private void rbCodUser_CheckedChanged(object sender, EventArgs e)
        {
            txtNomeUser.Enabled = true;
            txtCodPed.Enabled = false;
            cobStatusPed.Enabled = false;
            txtCodPed.Text = "";
            cobStatusPed.Text = "";
            txtNomeUser.Focus();
        }

        private void rbCodPed_CheckedChanged(object sender, EventArgs e)
        {
            txtCodPed.Enabled = true;
            txtNomeUser.Enabled = false;
            cobStatusPed.Enabled = false;
            txtNomeUser.Text = "";
            cobStatusPed.Text = "";
            txtCodPed.Focus();
        }

        private void rbStatus_CheckedChanged(object sender, EventArgs e)
        {
            cobStatusPed.Enabled = true;
            txtCodPed.Enabled = false;
            txtNomeUser.Enabled = false;
            txtCodPed.Text = "";
            txtNomeUser.Text = "";
            cobStatusPed.Focus();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if ((rbCodPed.Checked && txtCodPed.Text == "") || (rbNomeUser.Checked && txtNomeUser.Text == ""))
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

                if (rbCodPed.Checked)                                                          // nome está checado?
                {
                    sqlComm = new MySqlCommand("SELECT PEDIDOS.codPedido Codigo, PEDIDOS.qtdProd Quantidade, PEDIDOS.dataPedido Data, PRODUTOS.nomeProd Produto, USUARIOS.nomeUser Usuario, PEDIDOS.endPedido Endereco,  PEDIDOS.statusPedido Status FROM PEDIDOS, USUARIOS, PRODUTOS WHERE PEDIDOS.codProdFK = PRODUTOS.codProd AND PEDIDOS.codUserFK = USUARIOS.codUser AND codPedido = @codPed", connBD);
                    sqlComm.Parameters.Clear();
                    sqlComm.Parameters.Add("@codPed", MySqlDbType.Int32, 6).Value = txtCodPed.Text.Trim();
                }

                if (rbNomeUser.Checked)                                                         // código está checado?
                {
                    sqlComm = new MySqlCommand("SELECT PEDIDOS.codPedido Codigo, PEDIDOS.qtdProd Quantidade, PEDIDOS.dataPedido Data, PRODUTOS.nomeProd Produto, USUARIOS.nomeUser Usuario, PEDIDOS.endPedido Endereco,  PEDIDOS.statusPedido Status FROM PEDIDOS, USUARIOS, PRODUTOS WHERE PEDIDOS.codProdFK = PRODUTOS.codProd AND PEDIDOS.codUserFK = USUARIOS.codUser AND USUARIOS.nomeUser LIKE @nomeUser", connBD);
                    sqlComm.Parameters.Clear();
                    sqlComm.Parameters.Add("@nomeUser", MySqlDbType.VarChar, 50).Value = "%" + txtNomeUser.Text.Trim() + "%";
                }

                if (rbStatus.Checked)
                {
                    sqlComm = new MySqlCommand("SELECT PEDIDOS.codPedido Codigo, PEDIDOS.qtdProd Quantidade, PEDIDOS.dataPedido Data, PRODUTOS.nomeProd Produto, USUARIOS.nomeUser Usuario, PEDIDOS.endPedido Endereco,  PEDIDOS.statusPedido Status FROM PEDIDOS, USUARIOS, PRODUTOS WHERE PEDIDOS.codProdFK = PRODUTOS.codProd AND PEDIDOS.codUserFK = USUARIOS.codUser AND StatusPedido LIKE @status", connBD);
                    sqlComm.Parameters.Clear();
                    sqlComm.Parameters.Add("@status", MySqlDbType.VarChar, 40).Value = "%" + cobStatusPed.Text.Trim() + "%";                
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
                dgvPedidos.DataSource = bSource;
                bdData.Update(bdDataSet);

                // fechar o bd
                connBD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro");
                connBD.Close();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConsultarPedidos_Load(object sender, EventArgs e)
        {
            // String Connection com o MySQL (Local Host)
            string configuracaoBD = "server=localhost; userid=root; database=easyfood";
            MySqlConnection connBD = new MySqlConnection(configuracaoBD);

            try
            {
                connBD.Open();

                MySqlCommand sqlComm = new MySqlCommand("SELECT PEDIDOS.codPedido Codigo, PEDIDOS.dataPedido Data, PRODUTOS.nomeProd Produto, PRODUTOS.precoProd 'Preco do Produto', PEDIDOS.qtdProd Quantidade, PRODUTOS.precoProd * PEDIDOS.qtdProd 'Valor Total', USUARIOS.nomeUser Usuario, USUARIOS.telUser 'Telefone de contato', PEDIDOS.endPedido Endereco,  PEDIDOS.statusPedido Status FROM PEDIDOS, USUARIOS, PRODUTOS WHERE PEDIDOS.codProdFK = PRODUTOS.codProd AND PEDIDOS.codUserFK = USUARIOS.codUser", connBD);

                // CommandType
                sqlComm.CommandType = CommandType.Text;
                sqlComm.Connection = connBD;

                sqlComm.ExecuteNonQuery();

                drBD = sqlComm.ExecuteReader();
                if (!drBD.HasRows)      // não tem linhas?
                {
                    MessageBox.Show("Não há dados referente à pesquisa realizada", "Verificar");
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
                dgvPedidos.DataSource = bSource;
                bdData.Update(bdDataSet);

                // fechar o bd
                connBD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro");
                connBD.Close();
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printDGV.Print_DataGridView(dgvPedidos);
        }

    }
}
