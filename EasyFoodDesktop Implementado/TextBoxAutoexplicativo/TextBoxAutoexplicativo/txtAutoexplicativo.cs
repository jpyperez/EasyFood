/***************************************
 * Autor: erkHca CHOSS
 * Email: choss_21@hotmail.com
 * ************************************/
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
namespace TextBoxAutoexplicativo
{
    public class txtAutoexplicativo:TextBox //Heredamos de la clase TextBox
    {
        //Nuevas propiedades
        private string textoVacio;
        [Category("Texto Vacio")]//le agregamos una categoria 
        public string TextoVacio//Contendra el texto que se mostrara cuando el textbox este vacio
        {
            get { return textoVacio; }
            set { textoVacio = value; }
        }
        private Color colorTextoVacio;
        [Category("Texto Vacio")]//para que aparesca en la misma categoria
        public Color ColorTextoVacio
        {
            get { return colorTextoVacio; }
            set { colorTextoVacio = value; }
        }
        //Variables privadas
        bool bndTextoVacio = false;//Bandera que nos indica si esta activo el TextoVacio
        //Constructor
        public txtAutoexplicativo()
        {//Iniciamos los valores por defecto
            colorTextoVacio = Color.Gray;
            textoVacio = "<Descripcion>";
        }
        //Creamos un metodo que nos ayudara a verificar si se inserta el texto vacio o no
        private void VerificaTextoVacio()
        {
            if (this.Text.Length > 0)
                bndTextoVacio = false; // como el textbox tiene contenido desactivamos el textoVacio
            else
                bndTextoVacio = true; // en caso contrario activamos la bandera

            this.SetStyle(ControlStyles.UserPaint, bndTextoVacio);//Esto nos permitira poder acceder al evento Paint del TextBox segun la bandera
            this.Refresh();//Refrescamos el textbox
        }
        //Sobreescrivimos los metodos del textbox
        protected override void OnCreateControl()//Cuando se crea el control en el Form
        {
            base.OnCreateControl();
            VerificaTextoVacio();//Verificamos si debe activarse el TextoVacio
        }
        protected override void OnTextChanged(System.EventArgs e)
        {
            base.OnTextChanged(e);
            VerificaTextoVacio();//cada vez que cambie el texto del TextBox verificamos si se debe activar el TextoVacio
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            //Aqui mostramos en el textBox el contenido del TextoVacio, o el Contenido del TextBox segun sea el caso
            if (bndTextoVacio) //si esta activo el textoVacio
                e.Graphics.DrawString(textoVacio, new Font(this.Font, FontStyle.Italic), new SolidBrush(colorTextoVacio), new Point(0, 0));
            else
                e.Graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), new Point(0, 0));
            base.OnPaint(e);
        }
    }
}
