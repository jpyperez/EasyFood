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
    public partial class PrintOptions : Form
    {
        public PrintOptions()
        {
            InitializeComponent();
        }
        public PrintOptions(List<string> availableFields)
        {
            InitializeComponent();
            //Verifica quais os campos disponíveis
            foreach (string field in availableFields)
                chklst.Items.Add(field, true);
        }
       
        public List<string> GetSelectedColumns()
        {
            //"Guarda" os itens seleccionados na ListBox
            List<string> lst = new List<string>();
            foreach (object item in chklst.CheckedItems)
                lst.Add(item.ToString());
            return lst;
        }

        public string PrintTitle
        {
            //"Guarda" o texto referente ao título
            get { return txtTitle.Text; }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            // Abre a caixa de diálogo referente à impressão
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Fecha a caixa de diálogo referente à impressão
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }




    }
}
