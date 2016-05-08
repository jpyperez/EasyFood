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
    public partial class frmExcluirUsuario : Form
    {
        MySqlDataReader drBD;
        public frmExcluirUsuario()
        {
            InitializeComponent();
        }

        private void rbLogin_CheckedChanged(object sender, EventArgs e)
        {
            txtLogin.Enabled = true;
            txtCodigo.Enabled = false;
            txtCodigo.Text = "";
            txtLogin.Focus();
        }

        private void rbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            txtCodigo.Enabled = true;
            txtLogin.Enabled = false;
            txtLogin.Text = "";
            txtCodigo.Focus();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if ((rbCodigo.Checked && txtCodigo.Text == "") || (rbLogin.Checked && txtLogin.Text == ""))
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

                if (rbLogin.Checked)                                                          // login está checado?
                {
                    sqlComm = new MySqlCommand("SELECT CodUser Codigo, loginUser Login, NomeUser Nome, tipoUser 'Tipo de Usuario' FROM Usuarios WHERE loginUser LIKE @login AND tipoUser = 'Administrador' OR loginUser LIKE @login AND tipoUser = 'Funcionario'", connBD);
                    sqlComm.Parameters.Clear();
                    sqlComm.Parameters.Add("@login", MySqlDbType.VarChar, 40).Value = "%" + txtLogin.Text + "%";
                }

                if (rbCodigo.Checked)                                                         // código está checado?
                {
                    sqlComm = new MySqlCommand("SELECT CodUser Codigo, loginUser Login, NomeUser Nome, tipoUser 'Tipo de Usuario' FROM Usuarios WHERE codUser = @codigo AND tipoUser = 'Administrador' OR codUser = @codigo AND tipoUser = 'Funcionario'", connBD);
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

                if ((rbCodigo.Checked && txtCodigo.Text == "") || (rbLogin.Checked && txtLogin.Text == ""))
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

                    if (rbLogin.Checked)
                    {
                        if (MessageBox.Show("Deseja realmente excluir todos os usuários que contem '" + txtLogin.Text + "' no login?", "Confirmar exclusao", MessageBoxButtons.YesNo) == DialogResult.No)
                            return;
                    }

                    if (rbLogin.Checked)                                                          // login está checado?
                    {
                        sqlComm = new MySqlCommand("DELETE FROM Usuarios WHERE loginUser LIKE @login", connBD);
                        sqlComm.Parameters.Clear();
                        sqlComm.Parameters.Add("@login", MySqlDbType.VarChar, 40).Value = "%" + txtLogin.Text.Trim() + "%";
                    }

                    if (rbCodigo.Checked)                                                         // código está checado?
                    {
                        sqlComm = new MySqlCommand("DELETE FROM Usuarios WHERE codUser = @codigo", connBD);
                        sqlComm.Parameters.Clear();
                        sqlComm.Parameters.Add("@codigo", MySqlDbType.Int32, 6).Value = txtCodigo.Text.Trim();
                    }

                    // CommandType
                    sqlComm.CommandType = CommandType.Text;
                    sqlComm.Connection = connBD;

                    sqlComm.ExecuteNonQuery();

                    connBD.Close();

                    MessageBox.Show("Usuário excluído com sucesso!", "Sucesso");

                    this.Close();
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
