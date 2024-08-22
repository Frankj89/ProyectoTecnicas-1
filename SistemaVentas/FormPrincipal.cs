using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Menu_Productos_Click(object sender, EventArgs e)
        {
            FrmProducto formProductos = new FrmProducto();
            this.Hide();
            formProductos.Show();
        }
    }
}
