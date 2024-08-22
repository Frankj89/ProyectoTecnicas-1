namespace SistemaVentas
{
    partial class FormLogin
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btn_cancelar = new Button();
            btn_acceder = new Button();
            pictureBox3 = new PictureBox();
            txt_clave = new TextBox();
            txt_constraseña = new Label();
            txt_usuario = new TextBox();
            pictureBox2 = new PictureBox();
            lbl_usuario = new Label();
            tn_tiempo = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.HotTrack;
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Font = new Font("Impact", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Orange;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(425, 516);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Inicio Sesión";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.Image = Properties.Resources.Screenshot_2024_07_27_130629;
            pictureBox1.Location = new Point(49, 114);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(305, 305);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Cornsilk;
            label1.Location = new Point(619, 12);
            label1.Name = "label1";
            label1.Size = new Size(291, 44);
            label1.TabIndex = 7;
            label1.Text = "Sistema de Ventas";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(btn_cancelar);
            groupBox2.Controls.Add(btn_acceder);
            groupBox2.Controls.Add(pictureBox3);
            groupBox2.Controls.Add(txt_clave);
            groupBox2.Controls.Add(txt_constraseña);
            groupBox2.Controls.Add(txt_usuario);
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Controls.Add(lbl_usuario);
            groupBox2.Font = new Font("Impact", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(455, 126);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(0);
            groupBox2.Size = new Size(604, 402);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Acceder";
            // 
            // btn_cancelar
            // 
            btn_cancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_cancelar.BackColor = Color.FromArgb(255, 128, 128);
            btn_cancelar.Cursor = Cursors.Hand;
            btn_cancelar.FlatStyle = FlatStyle.Popup;
            btn_cancelar.Font = new Font("Impact", 12F);
            btn_cancelar.ForeColor = Color.AliceBlue;
            btn_cancelar.Image = Properties.Resources.Screenshot_2024_07_27_150137;
            btn_cancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_cancelar.Location = new Point(367, 324);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(180, 60);
            btn_cancelar.TabIndex = 6;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_acceder
            // 
            btn_acceder.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_acceder.BackColor = Color.LimeGreen;
            btn_acceder.Cursor = Cursors.Hand;
            btn_acceder.FlatStyle = FlatStyle.Popup;
            btn_acceder.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_acceder.ForeColor = Color.AliceBlue;
            btn_acceder.Image = Properties.Resources.Screenshot_2024_07_27_144551;
            btn_acceder.Location = new Point(81, 324);
            btn_acceder.Name = "btn_acceder";
            btn_acceder.Size = new Size(180, 60);
            btn_acceder.TabIndex = 11;
            btn_acceder.Text = "Acceder";
            btn_acceder.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_acceder.UseVisualStyleBackColor = false;
            btn_acceder.Click += btn_acceder_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ButtonHighlight;
            pictureBox3.Image = Properties.Resources.Screenshot_2024_07_27_134841;
            pictureBox3.Location = new Point(12, 208);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 31);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // txt_clave
            // 
            txt_clave.BackColor = SystemColors.InactiveBorder;
            txt_clave.Cursor = Cursors.IBeam;
            txt_clave.Location = new Point(81, 220);
            txt_clave.Name = "txt_clave";
            txt_clave.PasswordChar = '*';
            txt_clave.Size = new Size(466, 32);
            txt_clave.TabIndex = 9;
            // 
            // txt_constraseña
            // 
            txt_constraseña.AutoSize = true;
            txt_constraseña.BackColor = Color.Black;
            txt_constraseña.ForeColor = Color.Cornsilk;
            txt_constraseña.Location = new Point(73, 167);
            txt_constraseña.Name = "txt_constraseña";
            txt_constraseña.Size = new Size(118, 25);
            txt_constraseña.TabIndex = 8;
            txt_constraseña.Text = "Constraseña:";
            
            // 
            // txt_usuario
            // 
            txt_usuario.BackColor = SystemColors.InactiveBorder;
            txt_usuario.Cursor = Cursors.IBeam;
            txt_usuario.Location = new Point(81, 116);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(466, 32);
            txt_usuario.TabIndex = 8;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ButtonHighlight;
            pictureBox2.Image = Properties.Resources.Screenshot_2024_07_27_134813;
            pictureBox2.Location = new Point(15, 106);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // lbl_usuario
            // 
            lbl_usuario.AutoSize = true;
            lbl_usuario.BackColor = Color.Black;
            lbl_usuario.ForeColor = Color.Cornsilk;
            lbl_usuario.Location = new Point(73, 65);
            lbl_usuario.Name = "lbl_usuario";
            lbl_usuario.Size = new Size(78, 25);
            lbl_usuario.TabIndex = 6;
            lbl_usuario.Text = "Usuario:";
            // 
            // tn_tiempo
            // 
            tn_tiempo.Enabled = true;
            tn_tiempo.Tick += tn_tiempo_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Cornsilk;
            label2.Location = new Point(619, 67);
            label2.Name = "label2";
            label2.Size = new Size(112, 44);
            label2.TabIndex = 12;
            label2.Text = "label2";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(1086, 540);
            Controls.Add(label2);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Label label1;
        private GroupBox groupBox2;
        private Label lbl_usuario;
        private PictureBox pictureBox2;
        private Label txt_constraseña;
        private TextBox txt_usuario;
        private PictureBox pictureBox3;
        private TextBox txt_clave;
        private Button btn_cancelar;
        private Button btn_acceder;
        private System.Windows.Forms.Timer tn_tiempo;
        private Label label2;
    }
}