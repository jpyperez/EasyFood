using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EasyFoodDesktop
{
    public partial class frmMapa : Form
    {
        public frmMapa()
        {
            InitializeComponent();
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            //Rua Dário Carneiro, Vila Perracini, Poá - São Paulo, Brasil
            if (txtRua.Text.Contains("rua"))
                wbGoogleMaps.Navigate("https://www.google.com/maps/place/" + txtRua.Text + ",+" + txtBairro.Text + ",+" + txtCidade.Text + "+-+São+Paulo,+Brasil");
            else
                wbGoogleMaps.Navigate("https://www.google.com/maps/place/" + "Rua+" + txtRua.Text + ",+" + txtBairro.Text + ",+" + txtCidade.Text + "+-+São+Paulo,+Brasil");
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tspiVoltar_Click(object sender, EventArgs e)
        {
            btnVoltar.PerformClick();
        }

        private void tspiLimpar_Click(object sender, EventArgs e)
        {
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtRua.Text = "";
        }
    }
}
