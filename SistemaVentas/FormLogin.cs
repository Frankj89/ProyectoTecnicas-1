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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void tn_tiempo_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            txt_usuario.Clear();
            txt_clave.Clear();
        }

        private void btn_acceder_Click(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "admin" && txt_clave.Text == "1234")
            {

                FormPrincipal formPrincipal = new FormPrincipal();
                this.Hide();
                formPrincipal.Show();

            }

            else 
            {
                MessageBox.Show("Los datos ingresados son incorrectos");
                txt_usuario.Clear();
                txt_clave.Clear();
            }
          
        }

        
    }
}
