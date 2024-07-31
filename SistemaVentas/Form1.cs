namespace SistemaVentas
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 2;

                label1.Text = progressBar1.Value.ToString() + " %";
            }
            else
            {
                timer1.Stop();
                this.Hide();
                FormLogin frmLogin = new FormLogin();
                frmLogin.Show();
            }
        }
    }
}
