using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EasyFoodDesktop
{
    public partial class frmAlterarPedido : Form
    {
        MySqlDataReader drBD;

        public frmAlterarPedido()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtCodPed.Text == "")
            {
                MessageBox.Show("Insira dados no campo!", "Verificar");
                txtCodPed.Focus();
                return;
            }

            // String Connection com o MySQL (Local Host)
            string configuracaoBD = "server=localhost; userid=root; database=easyfood";
            MySqlConnection connBD = new MySqlConnection(configuracaoBD);

            try
            {
                connBD.Open();

                MySqlCommand sqlComm = new MySqlCommand();

                sqlComm = new MySqlCommand("SELECT codPedido Pedido, qtdProd 'Quantidade de Produto(s)', dataPedido Data, NomeTipoProd 'Tipo do Produto', nomeProd 'Nome do Produto', nomeUser 'Nome Cliente', endPedido 'Endereco de Entrega', statusPedido Estado FROM Pedidos, Produtos, TipoProdutos, Usuarios WHERE codTipoProdFK = codTipoProd AND codProdFK = codProd AND codUserFK = codUser AND codPedido = @codPed", connBD);
                sqlComm.Parameters.Clear();
                sqlComm.Parameters.Add("@codPed", MySqlDbType.Int32, 6).Value = txtCodPed.Text.Trim();
               
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
                cobStatusPed.Enabled = true;
                btnAlterar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro");
                connBD.Close();
            }
        }

        private void frmAlterarPedido_Load(object sender, EventArgs e)
        {
            // String Connection com o MySQL (Local Host)
            string configuracaoBD = "server=localhost; userid=root; database=easyfood";
            MySqlConnection connBD = new MySqlConnection(configuracaoBD);

            try
            {
                connBD.Open();

                MySqlCommand sqlComm = new MySqlCommand("SELECT codPedido Pedido, qtdProd 'Quantidade de Produto(s)', dataPedido Data, NomeTipoProd 'Tipo do Produto', nomeProd 'Nome do Produto', nomeUser 'Nome Cliente', endPedido 'Endereco de Entrega', statusPedido Estado FROM Pedidos, Produtos, tipoProdutos, Usuarios WHERE codTipoProdFK = codTipoProd AND codProdFK = codProd AND codUserFK = codUser", connBD);

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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtCodPed.Text == "")
            {
                MessageBox.Show("Insira dados no campo!", "Verificar");
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

                    sqlComm = new MySqlCommand("UPDATE Pedidos set StatusPedido = @status WHERE codPedido = @codigo", connBD);
                    sqlComm.Parameters.Clear();
                    sqlComm.Parameters.Add("@codigo", MySqlDbType.Int32, 6).Value = txtCodPed.Text.Trim();
                    sqlComm.Parameters.Add("@status", MySqlDbType.VarChar, 40).Value = cobStatusPed.Text.Trim();


                    // CommandType
                    sqlComm.CommandType = CommandType.Text;
                    sqlComm.Connection = connBD;

                    sqlComm.ExecuteNonQuery();

                    connBD.Close();

                    MessageBox.Show("Dados atualizados com sucesso!", "Sucesso");

                    // voltar ao estado normal
                    txtCodPed.Text = "";
                    cobStatusPed.Enabled = false;
                    cobStatusPed.Text = "";
                    txtCodPed.Focus();
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

    }
}
