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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "" || txtSenha.Text == "")             // tem dados nos campos?
            {
                MessageBox.Show("Insira dados nos campos!");
                return;
            }
            // String Connection com o MySQL (Local Host)
            string configuracaoBD = "server=localhost; userid=root; database=easyfood";
            MySqlConnection connBD = new MySqlConnection(configuracaoBD);
            try
            {
                connBD.Open();

                MySqlCommand sqlComm = new MySqlCommand();

                sqlComm = new MySqlCommand("SELECT loginUser, senhaUser, tipoUser, codUser FROM Usuarios WHERE loginUser = @login AND senhaUser = @senha", connBD);
                sqlComm.Parameters.Add("@login", MySqlDbType.VarChar, 40).Value = txtLogin.Text.Trim();
                sqlComm.Parameters.Add("@senha", MySqlDbType.VarChar, 40).Value = txtSenha.Text.Trim();

                // CommandType
                sqlComm.CommandType = CommandType.Text;
                sqlComm.Connection = connBD;

                MySqlDataReader drBD;
                drBD = sqlComm.ExecuteReader();

                // verificar se o usuário existe
                do
                {
                    if (drBD.HasRows) // tem item? 
                    {
                        this.Hide();
                        drBD.Read();
                        frmMenu frmMen = new frmMenu(drBD.GetString(2), drBD.GetInt32(3));
                        frmMen.Show();
                        break;                                                              // cai fora do while
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha inválido!", "Erro");
                        txtLogin.Focus();
                    }
                } while (drBD.HasRows);

                drBD.Close();
                connBD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                connBD.Close();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Confirmar fechamento", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnEntrar_Click(null, null);
        }

        private void txtLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                txtSenha.Focus();
        }

        private void txtLogin_Leave(object sender, EventArgs e)
        {
            if (txtLogin.Text == "")                 // nao tem nada no campo login?
            {
                pbImagem.ImageLocation = Application.StartupPath.ToString() + "\\Imagens\\imgPadrao.png";
                return;
            }
            // String Connection com o MySQL (Local Host)
            string configuracaoBD = "server=localhost; userid=root; database=easyfood";         
            MySqlConnection connBD = new MySqlConnection(configuracaoBD);

            try
            {

                connBD.Open();

                MySqlCommand sqlComm = new MySqlCommand();

                // verificar qual Tipo de Produto o usuário escolheu
                sqlComm = new MySqlCommand("SELECT loginUser, fotoUser FROM Usuarios WHERE loginUser = @login", connBD);
                sqlComm.Parameters.Clear();
                sqlComm.Parameters.Add("@login", MySqlDbType.VarChar, 40).Value = txtLogin.Text;

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
                        pbImagem.ImageLocation = Application.StartupPath.ToString() + "\\Imagens\\" + drBD.GetString(1);
                        break;
                    }
                    else
                        pbImagem.ImageLocation = Application.StartupPath.ToString() + "\\Imagens\\imgPadrao.png";
                } while (drBD.HasRows);

                drBD.Close();

                connBD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connBD.Close();
            }
        }


    }
}
