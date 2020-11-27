using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Articulo oArticulo = new Articulo();
            oArticulo.Nombre = "Pelota";
            oArticulo.Precio = 400;
            oArticulo.Descripcion = "Pelota de cuero";
            MessageBox.Show(oArticulo.Barato());
        }
    }
}
