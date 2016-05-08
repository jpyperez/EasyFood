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
    public partial class frmConsultarUsuarios : Form
    {
        MySqlDataReader drBD;
        public frmConsultarUsuarios()
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

                if (rbNome.Checked)                                                          // nome está checado?
                {
                    sqlComm = new MySqlCommand("SELECT CodUser Codigo, loginUser Login, NomeUser Nome, tipoUser 'Tipo de Usuario' FROM Usuarios WHERE nomeUser LIKE @nome", connBD);
                    sqlComm.Parameters.Clear();
                    sqlComm.Parameters.Add("@nome", MySqlDbType.VarChar, 40).Value = "%" + txtNome.Text.Trim() + "%";
                }

                if (rbCodigo.Checked)                                                         // código está checado?
                {
                    sqlComm = new MySqlCommand("SELECT CodUser Codigo, loginUser Login, NomeUser Nome, tipoUser 'Tipo de Usuario' FROM Usuarios WHERE codUser = @codigo", connBD);
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
                dgvUsuarios.DataSource = bSource;
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

        private void frmConsultarUsuarios_Load(object sender, EventArgs e)
        {
            // String Connection com o MySQL (Local Host)
            string configuracaoBD = "server=localhost; userid=root; database=easyfood";
            MySqlConnection connBD = new MySqlConnection(configuracaoBD);

            try
            {
                connBD.Open();

                MySqlCommand sqlComm = new MySqlCommand("SELECT CodUser Codigo, loginUser Login, NomeUser Nome, tipoUser 'Tipo de Usuario' FROM Usuarios", connBD);

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
                dgvUsuarios.DataSource = bSource;
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
            printDGV.Print_DataGridView(dgvUsuarios);
        }
    }
}
