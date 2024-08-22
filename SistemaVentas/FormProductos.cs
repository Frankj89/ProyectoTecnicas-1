using SistemaVentas.ControllerClass;
using SistemaVentas.ModelClass.Interfaces;
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
    /// <summary>
    /// View representation of product list
    /// </summary>
    public partial class FrmProducto : Form
    {

        private List<IProducto> ProductList { get; set; }

        private ProductController ProductController { get; set; }

        /// <summary>
        /// Initialized a new instance of the <see cref="FrmProducto"/> class.
        /// </summary>
        public FrmProducto()
        {
            this.ProductList = new List<IProducto>();
            this.ProductController = new ProductController();
            InitializeComponent();
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            this.ProductList = this.ProductController.GetProductos();
            MessageBox.Show(this.ProductList[1].ToString(), Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);

        }
    }
}
