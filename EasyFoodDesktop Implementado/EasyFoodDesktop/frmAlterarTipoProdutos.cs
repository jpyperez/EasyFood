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

    public partial class frmAlterarTipoProdutos : Form
    {

        MySqlDataReader drBD;

        public frmAlterarTipoProdutos()
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
                            
                sqlComm = new MySqlCommand("SELECT codTipoProd Codigo, nomeTipoProd Nome FROM TipoProdutos WHERE codTipoProd = @codigo", connBD);
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
                dgvTipoProdutos.DataSource = bSource;
                bdData.Update(bdDataSet);

                // fechar o bd
                connBD.Close();

                // deixar o usuário editar
                txtNome.Enabled = true;
                txtNome.Focus();
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
            if (txtNome.Text == "")
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

                    sqlComm = new MySqlCommand("UPDATE TipoProdutos set nomeTipoProd = @nome WHERE codTipoProd = @codigo", connBD);
                    sqlComm.Parameters.Clear();
                    sqlComm.Parameters.Add("@codigo", MySqlDbType.Int32, 6).Value = txtCodigo.Text.Trim();
                    sqlComm.Parameters.Add("@nome", MySqlDbType.VarChar, 40).Value = txtNome.Text.Trim();


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

    }
}
