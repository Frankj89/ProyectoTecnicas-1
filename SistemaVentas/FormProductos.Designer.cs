namespace SistemaVentas
{
    partial class FrmProducto
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
            dgv_productos = new DataGridView();
            label1 = new Label();
            btn_Nuevo = new Button();
            btn_editar = new Button();
            btn_eliminar = new Button();
            btn_cancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_productos).BeginInit();
            SuspendLayout();
            // 
            // dgv_productos
            // 
            dgv_productos.AllowUserToAddRows = false;
            dgv_productos.AllowUserToDeleteRows = false;
            dgv_productos.AllowUserToOrderColumns = true;
            dgv_productos.AllowUserToResizeRows = false;
            dgv_productos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_productos.BackgroundColor = SystemColors.ButtonFace;
            dgv_productos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_productos.EnableHeadersVisualStyles = false;
            dgv_productos.GridColor = SystemColors.ControlDark;
            dgv_productos.Location = new Point(34, 137);
            dgv_productos.Name = "dgv_productos";
            dgv_productos.ReadOnly = true;
            dgv_productos.RowHeadersVisible = false;
            dgv_productos.RowHeadersWidth = 62;
            dgv_productos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_productos.Size = new Size(1113, 506);
            dgv_productos.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.HotTrack;
            label1.Font = new Font("Impact", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Orange;
            label1.Location = new Point(377, 39);
            label1.Name = "label1";
            label1.Size = new Size(449, 68);
            label1.TabIndex = 9;
            label1.Text = "Lista de Productos";
            // 
            // btn_Nuevo
            // 
            btn_Nuevo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_Nuevo.BackColor = Color.LimeGreen;
            btn_Nuevo.Cursor = Cursors.Hand;
            btn_Nuevo.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Nuevo.ForeColor = Color.AliceBlue;
            btn_Nuevo.Location = new Point(34, 693);
            btn_Nuevo.Name = "btn_Nuevo";
            btn_Nuevo.Size = new Size(197, 66);
            btn_Nuevo.TabIndex = 64;
            btn_Nuevo.Text = "Nuevo";
            btn_Nuevo.UseVisualStyleBackColor = false;
            btn_Nuevo.Click += btn_Nuevo_Click;
            // 
            // btn_editar
            // 
            btn_editar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_editar.BackColor = Color.Orange;
            btn_editar.Cursor = Cursors.Hand;
            btn_editar.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_editar.ForeColor = Color.AliceBlue;
            btn_editar.Location = new Point(346, 693);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(197, 66);
            btn_editar.TabIndex = 63;
            btn_editar.Text = "Editar";
            btn_editar.UseVisualStyleBackColor = false;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_eliminar.BackColor = Color.Crimson;
            btn_eliminar.Cursor = Cursors.Hand;
            btn_eliminar.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_eliminar.ForeColor = Color.AliceBlue;
            btn_eliminar.Location = new Point(654, 695);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(197, 66);
            btn_eliminar.TabIndex = 93;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = false;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_cancelar.BackColor = Color.FromArgb(255, 128, 128);
            btn_cancelar.Cursor = Cursors.Hand;
            btn_cancelar.FlatStyle = FlatStyle.Popup;
            btn_cancelar.Font = new Font("Impact", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_cancelar.ForeColor = Color.AliceBlue;
            btn_cancelar.Location = new Point(944, 693);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(197, 66);
            btn_cancelar.TabIndex = 73;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = false;
            // 
            // FrmProducto
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 771);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_editar);
            Controls.Add(btn_Nuevo);
            Controls.Add(label1);
            Controls.Add(dgv_productos);
            Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion de Productos";
            ((System.ComponentModel.ISupportInitialize)dgv_productos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView dgv_productos;
        private Label label1;
        private Button btn_Nuevo;
        private Button btn_editar;
        private Button btn_eliminar;
        private Button btn_cancelar;
    }
}