namespace SistemaVentas
{
    partial class FormInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            lbl_Presentacion = new Label();
            lbl_Mensaje = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            progressBar1 = new ProgressBar();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Orange;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources.Screenshot_2024_07_27_000502;
            pictureBox1.Location = new Point(12, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Padding = new Padding(5);
            pictureBox1.Size = new Size(677, 556);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lbl_Presentacion
            // 
            lbl_Presentacion.AutoSize = true;
            lbl_Presentacion.BackColor = SystemColors.HotTrack;
            lbl_Presentacion.Font = new Font("Impact", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Presentacion.ForeColor = Color.Orange;
            lbl_Presentacion.Location = new Point(725, 9);
            lbl_Presentacion.Name = "lbl_Presentacion";
            lbl_Presentacion.Size = new Size(455, 68);
            lbl_Presentacion.TabIndex = 9;
            lbl_Presentacion.Text = "SISTEMA DE VENTAS\r\n";
            // 
            // lbl_Mensaje
            // 
            lbl_Mensaje.AutoSize = true;
            lbl_Mensaje.BackColor = SystemColors.InfoText;
            lbl_Mensaje.Font = new Font("Impact", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Mensaje.ForeColor = Color.White;
            lbl_Mensaje.Location = new Point(911, 530);
            lbl_Mensaje.Name = "lbl_Mensaje";
            lbl_Mensaje.Size = new Size(258, 35);
            lbl_Mensaje.TabIndex = 8;
            lbl_Mensaje.Text = "Espere un momento...";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(838, 255);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(223, 34);
            progressBar1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(911, 195);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 11;
            label1.Text = "label1";
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(1224, 600);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Controls.Add(lbl_Mensaje);
            Controls.Add(lbl_Presentacion);
            Controls.Add(pictureBox1);
            Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bienvenido!!";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lbl_Presentacion;
        private Label lbl_Mensaje;
        private System.Windows.Forms.Timer timer1;
        private ProgressBar progressBar1;
        private Label label1;
    }
}
