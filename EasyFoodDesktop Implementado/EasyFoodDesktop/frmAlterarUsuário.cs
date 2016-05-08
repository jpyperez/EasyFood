using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using MySql.Data.MySqlClient;

namespace EasyFoodDesktop
{

    public partial class frmAlterarUsuário : Form
    {
        String strNomeImagem;
        bool flgEscolheu = false;
        public frmAlterarUsuário()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "")             // campo Login Preenchido?
            {
                MessageBox.Show("Insira dados no campo Login!", "Erro");
                txtLogin.Focus();
                return;
            }
            else if (txtNome.Text == "")                    // Campo Nome preenchido?
            {
                MessageBox.Show("Insira dados no campo Nome!", "Erro");
                txtNome.Focus();
                return;
            }
            else if (txtSenha.Text == "")             // campo Senha Preenchido?
            {
                MessageBox.Show("Insira dados no campo Senha!", "Erro");
                txtSenha.Focus();
                return;
            }
            else if(txtConfirmarSenha.Text == "")
            {
                MessageBox.Show("Insira os dados no campo Confirmar Senha", "Erro");
                txtConfirmarSenha.Focus();
                return;
            }
            else if (cobTipoFunc.Text == "")            // campo Tipo func Preenchido?
            {
                MessageBox.Show("Insira dados no campo Tipo de Funcionário!", "Erro");
                cobTipoFunc.Focus();
                return;
            }
            if(txtSenha.Text != txtConfirmarSenha.Text)
            {
                MessageBox.Show("As senhas não correspondem!", "Erro");
                txtSenha.Focus();
                return;
            }
            // String Connection com o MySQL (Local Host)
            string configuracaoBD = "server=localhost; userid=root; database=easyfood";
            MySqlConnection connBD = new MySqlConnection(configuracaoBD);
            try
            {
                connBD.Open();

                MySqlCommand sqlComm = new MySqlCommand();

                if (flgEscolheu)                    // imagem foi alterada?
                {
                    // Inserir os dados no bd
                    sqlComm = new MySqlCommand("UPDATE Usuarios set nomeUser = @nome, senhaUser = @senha, tipoUser = @tipo, fotoUser = @foto WHERE loginUser = @login", connBD);
                    sqlComm.Parameters.Add("@login", MySqlDbType.VarChar, 60).Value = txtLogin.Text.Trim();
                    sqlComm.Parameters.Add("@senha", MySqlDbType.VarChar, 60).Value = txtSenha.Text.Trim();
                    sqlComm.Parameters.Add("@nome", MySqlDbType.VarChar, 60).Value = txtNome.Text.Trim();
                    sqlComm.Parameters.Add("@tipo", MySqlDbType.VarChar, 60).Value = cobTipoFunc.Text.Trim();
                    sqlComm.Parameters.Add("@foto", MySqlDbType.VarChar, 60).Value = strNomeImagem;
                }
                else
                {
                    // Inserir os dados no bd
                    sqlComm = new MySqlCommand("UPDATE Usuarios set nomeUser = @nome, senhaUser = @senha, tipoUser = @tipo WHERE loginUser = @login", connBD);
                    sqlComm.Parameters.Add("@login", MySqlDbType.VarChar, 60).Value = txtLogin.Text.Trim();
                    sqlComm.Parameters.Add("@senha", MySqlDbType.VarChar, 60).Value = txtSenha.Text.Trim();
                    sqlComm.Parameters.Add("@nome", MySqlDbType.VarChar, 60).Value = txtNome.Text.Trim();
                    sqlComm.Parameters.Add("@tipo", MySqlDbType.VarChar, 60).Value = cobTipoFunc.Text.Trim();
                }
                sqlComm.ExecuteNonQuery();

                // fechamento do bd
                connBD.Close();
                MessageBox.Show("Dados atualizados com sucesso!", "Sucesso");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:\n" + ex.Message, "Erro");
                connBD.Close();
            }

        }

        private void txtLogin_Leave(object sender, EventArgs e)
        {
            if (txtLogin.Text == "")                 // nao tem nada no campo login?
            {
                pbImagem.ImageLocation = Application.StartupPath.ToString() + "\\imagens\\imgPadrao.png";
                return;
            }
            // String Connection com o MySQL (Local Host)
            string configuracaoBD = "server=localhost; userid=root; database=easyfood";         
            MySqlConnection connBD = new MySqlConnection(configuracaoBD);

            try
            {

                connBD.Open();

                MySqlCommand sqlComm = new MySqlCommand();


                // Listar o usuario
                sqlComm = new MySqlCommand("SELECT loginUser, fotoUser, tipoUser FROM Usuarios WHERE loginUser = @login", connBD);
                sqlComm.Parameters.Clear();
                sqlComm.Parameters.Add("@login", MySqlDbType.VarChar, 40).Value = txtLogin.Text.Trim();


                // CommandType
                sqlComm.CommandType = CommandType.Text;
                sqlComm.Connection = connBD;

                MySqlDataReader drBD;
                drBD = sqlComm.ExecuteReader();

                // loop para ver o usuario escolhido
                do
                {
                    if (drBD.HasRows) // tem item? 
                    {
                        drBD.Read();
                        if (drBD.GetString(2) != "Administrador" && drBD.GetString(2) != "Funcionario")
                        {
                            MessageBox.Show("Usuário inválido!", "Erro");
                            txtLogin.Focus();
                            drBD.Close();
                            connBD.Close();
                            return;
                        }
                        pbImagem.ImageLocation = Application.StartupPath.ToString() + "\\Imagens\\" + drBD.GetString(1);
                        btnEscolher.Enabled = true;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Usuário não existe!", "Mensagem");
                        txtLogin.Focus();
                        pbImagem.ImageLocation = Application.StartupPath.ToString() + "\\Imagens\\imgPadrao.png";
                        btnEscolher.Enabled = false;
                    }
                } while (drBD.HasRows);

                drBD.Close();
                connBD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro\n" + ex.Message, "Erro");
                connBD.Close();
            }
        }

        private void btnEscolher_Click(object sender, EventArgs e)
        {
            if (ofdImagem.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(ofdImagem.FileName);
                Bitmap bmp2 = new Bitmap(bmp, pbImagem.Size);

                pbImagem.Image = bmp2;

                pbImagem.Image.Save(Application.StartupPath.ToString() + "\\Imagens\\" + txtLogin.Text + ".png", ImageFormat.Png);

                strNomeImagem = txtLogin.Text + ".png";
                flgEscolheu = true;
            }
        }
        
    }
}
