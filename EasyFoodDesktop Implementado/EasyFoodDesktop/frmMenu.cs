using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EasyFoodDesktop
{
    public partial class frmMenu : Form
    {
        string strTipFunc;
        int nCodFunc;
        public frmMenu(String tipoFunc, int codFunc)
        {
            InitializeComponent();
            strTipFunc = tipoFunc;
            nCodFunc = codFunc;
        }
        MySqlDataReader drBD;

        //Contador de segundos
        int segs = 0;

        //percentual da taxa easyfood
        double taxaPercentual = 10.0 / 100.0;

        private void btnCadProd_Click(object sender, EventArgs e)
        {
            frmCadastrarProdutos frmCadProd = new frmCadastrarProdutos();
            frmCadProd.Show();
        }

        private void btnAltProd_Click(object sender, EventArgs e)
        {
            frmAlterarProdutos frmAltProd = new frmAlterarProdutos();
            frmAltProd.Show();
        }

        private void btnExcProd_Click(object sender, EventArgs e)
        {
            frmExcluirProdutos frmExcProd = new frmExcluirProdutos();
            frmExcProd.Show();
        }

        private void btnConsPed_Click(object sender, EventArgs e)
        {
            frmConsultarPedidos frmConsPed = new frmConsultarPedidos();
            frmConsPed.Show();
        }

        private void btnConsProd_Click(object sender, EventArgs e)
        {
            frmConsultarProdutos frmConsProd = new frmConsultarProdutos();
            frmConsProd.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Confirmar fechamento", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }

        private void tspiCadProd_Click(object sender, EventArgs e)
        {
            frmCadastrarProdutos frmCadProd = new frmCadastrarProdutos();
            frmCadProd.Show();
        }

        private void tspiAltProd_Click(object sender, EventArgs e)
        {
            frmAlterarProdutos frmAltProd = new frmAlterarProdutos();
            frmAltProd.Show();
        }

        private void tspiExcProd_Click(object sender, EventArgs e)
        {
            frmExcluirProdutos frmExcProd = new frmExcluirProdutos();
            frmExcProd.Show();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCadastrarTipoProdutos frmCadTipProd = new frmCadastrarTipoProdutos();
            frmCadTipProd.Show();
        }

        private void tspiAltTipProd_Click(object sender, EventArgs e)
        {
            frmAlterarTipoProdutos frmAltTipProd = new frmAlterarTipoProdutos();
            frmAltTipProd.Show();
        }

        private void tspiExcTipProd_Click(object sender, EventArgs e)
        {
            frmExcluirTipoProdutos frmExcTipProd = new frmExcluirTipoProdutos();
            frmExcTipProd.Show();
        }

        private void tspiConsProd_Click(object sender, EventArgs e)
        {
            frmConsultarProdutos frmConsProd = new frmConsultarProdutos();
            frmConsProd.Show();
        }

        private void tspiConsPed_Click(object sender, EventArgs e)
        {
            frmConsultarPedidos frmConsPed = new frmConsultarPedidos();
            frmConsPed.Show();
        }

        private void tspiAjuda_Click(object sender, EventArgs e)
        {
            frmAjuda frmHelp = new frmAjuda();
            frmHelp.Show();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlterarPedido frmAltPed = new frmAlterarPedido();
            frmAltPed.Show();
        }

        private void btnEditarStatus_Click(object sender, EventArgs e)
        {
            frmAlterarPedido frmAltPed = new frmAlterarPedido();
            frmAltPed.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDataHora.Text = DateTime.Now.ToString();

            //Contador de segundos
            ++segs;

            if (segs == 15)
            {
                ganhosEtaxa();
                //limpando contador
                segs = 0;
            }
        }

        public void ganhosEtaxa()
        {
            //Label com ganhos com os pedidos     

            string configuracaoBD = "server=localhost; userid=root; database=easyfood";
            MySqlConnection connBD = new MySqlConnection(configuracaoBD);

            connBD.Open();

            MySqlCommand sqlComm = new MySqlCommand();

            sqlComm = new MySqlCommand("SELECT CODPRODFK, QTDPROD,CODPROD, PRECOPROD, STATUSPEDIDO FROM PEDIDOS, PRODUTOS WHERE CODPRODFK = CODPROD", connBD);
            sqlComm.Parameters.Clear();

            // CommandType
            sqlComm.CommandType = CommandType.Text;
            sqlComm.Connection = connBD;

            sqlComm.ExecuteNonQuery();

            drBD = sqlComm.ExecuteReader();

            //variavel para armazenar valor de ganhos
            double total = 0.0;

            if (drBD.HasRows)      // tem linhas?
            {
                while (drBD.Read())
                    if (drBD.GetString(4) == "Finalizado")
                        total = total + drBD.GetDouble(3) * drBD.GetInt32(1);
            }

            lblGanhos.Text = "R$ " + Convert.ToString(total - (taxaPercentual * total));
            lblTaxaEasyFood.Text = "R$ " + Convert.ToString(taxaPercentual * total);

            drBD.Close();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            // tipo de funcionario
            if (strTipFunc == "Administrador")
                tspiFuncionarios.Visible = true;

            tmrData.Start();
            ganhosEtaxa();
            lblDataHora.Text = DateTime.Now.ToString();
        }

        private void tspiMapa_Click(object sender, EventArgs e)
        {
            frmMapa mapa = new frmMapa();
            mapa.Show();
        }

        private void tspiCalculadora_Click(object sender, EventArgs e)
        {
            Process.Start("Calc.exe");
        }

        private void tspiFuncionarios_Click(object sender, EventArgs e)
        {

        }

        private void tspiCadFuncionarios_Click(object sender, EventArgs e)
        {
            frmCadastrarUsuario frmCadUsu = new frmCadastrarUsuario();
            frmCadUsu.Show();
        }

        private void tspiAltFuncionarios_Click(object sender, EventArgs e)
        {
            frmAlterarUsuário frmAltUsu = new frmAlterarUsuário();
            frmAltUsu.Show();
        }

        private void tspiExcFuncionarios_Click(object sender, EventArgs e)
        {
            frmExcluirUsuario frmExcUsu = new frmExcluirUsuario();
            frmExcUsu.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarUsuarios frmConUsu = new frmConsultarUsuarios();
            frmConUsu.Show();
        }

    }
}
