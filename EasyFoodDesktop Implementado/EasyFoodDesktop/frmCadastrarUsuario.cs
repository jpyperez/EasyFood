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
    public partial class frmCadastrarUsuario : Form
    {
        String strNomeImagem = "";
        public frmCadastrarUsuario()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "")             // campo Login Preenchido?
            {
                MessageBox.Show("Insira dados no campo Login!", "Erro");
                txtLogin.Focus();
                return;
            }
            else if (txtNome.Text == "" )                    // Campo Nome preenchido?
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
            else if (cobTipoFunc.Text == "")            // campo Tipo func Preenchido?
            {
                MessageBox.Show("Insira dados no campo Tipo de Funcionário!", "Erro");
                cobTipoFunc.Focus();
                return;
            }
            // String Connection com o MySQL (Local Host)
            string configuracaoBD = "server=localhost; userid=root; database=easyfood";
            MySqlConnection connBD = new MySqlConnection(configuracaoBD);
            try
            {
                connBD.Open();

                if (strNomeImagem == "")                            // não foi recebida a imagem?
                    strNomeImagem = "imgPadrao.png";

                MySqlCommand sqlComm = new MySqlCommand();
                // Inserir os dados no bd
                sqlComm = new MySqlCommand("INSERT INTO Usuarios (LoginUser, SenhaUser, nomeUser, tipoUser, fotoUser) values (@login, @senha, @nome, @tipo, @foto)", connBD);
                sqlComm.Parameters.Add("@login", MySqlDbType.VarChar, 60).Value = txtLogin.Text.Trim();
                sqlComm.Parameters.Add("@senha", MySqlDbType.VarChar, 60).Value = txtSenha.Text.Trim();
                sqlComm.Parameters.Add("@nome", MySqlDbType.VarChar, 60).Value = txtNome.Text.Trim();
                sqlComm.Parameters.Add("@tipo", MySqlDbType.VarChar, 60).Value = cobTipoFunc.Text.Trim();
                sqlComm.Parameters.Add("@foto", MySqlDbType.VarChar, 60).Value = strNomeImagem;

                sqlComm.ExecuteNonQuery();

                // fechamento do bd
                connBD.Close();
                MessageBox.Show("Dados cadastrados com sucesso!", "Sucesso");

                this.Close();
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
        
        // Evento de escolher imagem
        private void btnEscolher_Click(object sender, EventArgs e)
        {
            if (ofdImagem.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(ofdImagem.FileName);
                Bitmap bmp2 = new Bitmap(bmp, pbImagem.Size);

                pbImagem.Image = bmp2;

                pbImagem.Image.Save(Application.StartupPath.ToString() + "\\Imagens\\" + txtLogin.Text + ".png", ImageFormat.Png);

                strNomeImagem = txtLogin.Text + ".png";
            }
            
        }

        private void txtLogin_Leave(object sender, EventArgs e)
        {
            if (txtLogin.Text != "")
                btnEscolher.Enabled = true;
            else
                btnEscolher.Enabled = false;
        }

    }
}
