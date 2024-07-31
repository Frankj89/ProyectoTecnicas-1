namespace SistemaVentas
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Menu_principal = new MenuStrip();
            Menu_Inventarios = new ToolStripMenuItem();
            Menu_Productos = new ToolStripMenuItem();
            Menu_Inventario = new ToolStripMenuItem();
            Menu_Bajo_Inventarios = new ToolStripMenuItem();
            Menu_Ventas = new ToolStripMenuItem();
            Menu_Procesamiento_ventas = new ToolStripMenuItem();
            Menu_Facturas = new ToolStripMenuItem();
            Menu_Pagos = new ToolStripMenuItem();
            Menu_Clientes = new ToolStripMenuItem();
            Menu_Registro_Clientes = new ToolStripMenuItem();
            Menu_Historial_Compras = new ToolStripMenuItem();
            Menu_Reportes = new ToolStripMenuItem();
            Menu_Reportes_Ventas = new ToolStripMenuItem();
            Menu_Reportes_Inventarios = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            Menu_principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Menu_principal
            // 
            Menu_principal.BackColor = SystemColors.MenuHighlight;
            Menu_principal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Menu_principal.ImageScalingSize = new Size(32, 32);
            Menu_principal.Items.AddRange(new ToolStripItem[] { Menu_Inventarios, Menu_Ventas, Menu_Clientes, Menu_Reportes });
            Menu_principal.Location = new Point(0, 0);
            Menu_principal.Name = "Menu_principal";
            Menu_principal.Padding = new Padding(9, 10, 0, 10);
            Menu_principal.Size = new Size(1173, 56);
            Menu_principal.TabIndex = 9;
            Menu_principal.Text = "Menu";
            // 
            // Menu_Inventarios
            // 
            Menu_Inventarios.BackColor = Color.Black;
            Menu_Inventarios.DropDownItems.AddRange(new ToolStripItem[] { Menu_Productos, Menu_Inventario, Menu_Bajo_Inventarios });
            Menu_Inventarios.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Menu_Inventarios.ForeColor = Color.Orange;
            Menu_Inventarios.Name = "Menu_Inventarios";
            Menu_Inventarios.Size = new Size(291, 36);
            Menu_Inventarios.Text = "Gestion De Inventarios";
            // 
            // Menu_Productos
            // 
            Menu_Productos.BackColor = SystemColors.ControlDark;
            Menu_Productos.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Menu_Productos.ForeColor = SystemColors.Desktop;
            Menu_Productos.Name = "Menu_Productos";
            Menu_Productos.Size = new Size(452, 40);
            Menu_Productos.Text = "Productos";
            Menu_Productos.Click += Menu_Productos_Click;
            // 
            // Menu_Inventario
            // 
            Menu_Inventario.BackColor = SystemColors.ControlDark;
            Menu_Inventario.ForeColor = SystemColors.Desktop;
            Menu_Inventario.Name = "Menu_Inventario";
            Menu_Inventario.Size = new Size(452, 40);
            Menu_Inventario.Text = "Inventarios";
            // 
            // Menu_Bajo_Inventarios
            // 
            Menu_Bajo_Inventarios.BackColor = SystemColors.ControlDark;
            Menu_Bajo_Inventarios.ForeColor = SystemColors.Desktop;
            Menu_Bajo_Inventarios.Name = "Menu_Bajo_Inventarios";
            Menu_Bajo_Inventarios.Size = new Size(452, 40);
            Menu_Bajo_Inventarios.Text = "Poductos bajo de Inventarios";
            // 
            // Menu_Ventas
            // 
            Menu_Ventas.BackColor = Color.Black;
            Menu_Ventas.DropDownItems.AddRange(new ToolStripItem[] { Menu_Procesamiento_ventas, Menu_Facturas, Menu_Pagos });
            Menu_Ventas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Menu_Ventas.ForeColor = Color.Orange;
            Menu_Ventas.Name = "Menu_Ventas";
            Menu_Ventas.Size = new Size(237, 36);
            Menu_Ventas.Text = "Gestion De Ventas";
            // 
            // Menu_Procesamiento_ventas
            // 
            Menu_Procesamiento_ventas.BackColor = SystemColors.ControlDark;
            Menu_Procesamiento_ventas.ForeColor = SystemColors.Desktop;
            Menu_Procesamiento_ventas.Name = "Menu_Procesamiento_ventas";
            Menu_Procesamiento_ventas.Size = new Size(270, 40);
            Menu_Procesamiento_ventas.Text = "Ventas";
            // 
            // Menu_Facturas
            // 
            Menu_Facturas.BackColor = SystemColors.ControlDark;
            Menu_Facturas.ForeColor = SystemColors.Desktop;
            Menu_Facturas.Name = "Menu_Facturas";
            Menu_Facturas.Size = new Size(270, 40);
            Menu_Facturas.Text = "Facturas";
            // 
            // Menu_Pagos
            // 
            Menu_Pagos.BackColor = SystemColors.ControlDark;
            Menu_Pagos.ForeColor = SystemColors.Desktop;
            Menu_Pagos.Name = "Menu_Pagos";
            Menu_Pagos.Size = new Size(270, 40);
            Menu_Pagos.Text = "Pagos";
            // 
            // Menu_Clientes
            // 
            Menu_Clientes.BackColor = Color.Black;
            Menu_Clientes.DropDownItems.AddRange(new ToolStripItem[] { Menu_Registro_Clientes, Menu_Historial_Compras });
            Menu_Clientes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Menu_Clientes.ForeColor = Color.Orange;
            Menu_Clientes.Name = "Menu_Clientes";
            Menu_Clientes.Size = new Size(252, 36);
            Menu_Clientes.Text = "Gestion De Clientes";
            // 
            // Menu_Registro_Clientes
            // 
            Menu_Registro_Clientes.BackColor = SystemColors.ControlDark;
            Menu_Registro_Clientes.ForeColor = SystemColors.Desktop;
            Menu_Registro_Clientes.Name = "Menu_Registro_Clientes";
            Menu_Registro_Clientes.Size = new Size(358, 40);
            Menu_Registro_Clientes.Text = "Registro De Clientes";
            // 
            // Menu_Historial_Compras
            // 
            Menu_Historial_Compras.BackColor = SystemColors.ControlDark;
            Menu_Historial_Compras.ForeColor = SystemColors.Desktop;
            Menu_Historial_Compras.Name = "Menu_Historial_Compras";
            Menu_Historial_Compras.Size = new Size(358, 40);
            Menu_Historial_Compras.Text = "Historial de Compras";
            // 
            // Menu_Reportes
            // 
            Menu_Reportes.BackColor = Color.Black;
            Menu_Reportes.DropDownItems.AddRange(new ToolStripItem[] { Menu_Reportes_Ventas, Menu_Reportes_Inventarios });
            Menu_Reportes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Menu_Reportes.ForeColor = Color.Orange;
            Menu_Reportes.Name = "Menu_Reportes";
            Menu_Reportes.Size = new Size(247, 36);
            Menu_Reportes.Text = "Reportes y Analisis";
            // 
            // Menu_Reportes_Ventas
            // 
            Menu_Reportes_Ventas.BackColor = SystemColors.ControlDark;
            Menu_Reportes_Ventas.ForeColor = SystemColors.Desktop;
            Menu_Reportes_Ventas.Name = "Menu_Reportes_Ventas";
            Menu_Reportes_Ventas.Size = new Size(394, 40);
            Menu_Reportes_Ventas.Text = "Reportes De Ventas";
            // 
            // Menu_Reportes_Inventarios
            // 
            Menu_Reportes_Inventarios.BackColor = SystemColors.ControlDark;
            Menu_Reportes_Inventarios.ForeColor = SystemColors.Desktop;
            Menu_Reportes_Inventarios.Name = "Menu_Reportes_Inventarios";
            Menu_Reportes_Inventarios.Size = new Size(394, 40);
            Menu_Reportes_Inventarios.Text = "Reportes De Inventarios";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.Screenshot_2024_07_17_230629;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1173, 682);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1173, 682);
            Controls.Add(Menu_principal);
            Controls.Add(pictureBox1);
            Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            MainMenuStrip = Menu_principal;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Ventas";
            WindowState = FormWindowState.Maximized;
            Menu_principal.ResumeLayout(false);
            Menu_principal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip Menu_principal;
        private ToolStripMenuItem Menu_Inventarios;
        private ToolStripMenuItem Menu_Productos;
        private ToolStripMenuItem Menu_Inventario;
        private ToolStripMenuItem Menu_Bajo_Inventarios;
        private PictureBox pictureBox1;
        private ToolStripMenuItem Menu_Ventas;
        private ToolStripMenuItem Menu_Procesamiento_ventas;
        private ToolStripMenuItem Menu_Facturas;
        private ToolStripMenuItem Menu_Pagos;
        private ToolStripMenuItem Menu_Clientes;
        private ToolStripMenuItem Menu_Registro_Clientes;
        private ToolStripMenuItem Menu_Historial_Compras;
        private ToolStripMenuItem Menu_Reportes;
        private ToolStripMenuItem Menu_Reportes_Ventas;
        private ToolStripMenuItem Menu_Reportes_Inventarios;
    }
}