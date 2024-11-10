namespace CapaPresentacion
{
    partial class Form1
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
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            btnGuardarChofer = new Button();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            btnActualizar = new Button();
            btnNuevo = new Button();
            btnCancelar = new Button();
            dataGridView1 = new DataGridView();
            TextBox1 = new TextBox();
            TextBox2 = new TextBox();
            TextBox3 = new TextBox();
            TextBox4 = new TextBox();
            TextBox5 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtCedula = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtFechaNacimiento = new DateTimePicker();
            label11 = new Label();
            label12 = new Label();
            comboBox1 = new ComboBox();
            dataGridView2 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 40, 68);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1597, 58);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_xbox_x_80;
            pictureBox2.Location = new Point(1529, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(77, 46);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Ebrima", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(206, 25);
            label1.TabIndex = 8;
            label1.Text = "Sistema Autobus ITLA";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(1, 81, 170);
            panel2.Controls.Add(btnGuardarChofer);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(btnActualizar);
            panel2.Controls.Add(btnNuevo);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 58);
            panel2.Name = "panel2";
            panel2.Size = new Size(381, 803);
            panel2.TabIndex = 1;
            // 
            // btnGuardarChofer
            // 
            btnGuardarChofer.BackColor = Color.FromArgb(85, 139, 198);
            btnGuardarChofer.BackgroundImageLayout = ImageLayout.Zoom;
            btnGuardarChofer.Cursor = Cursors.Hand;
            btnGuardarChofer.FlatAppearance.BorderSize = 0;
            btnGuardarChofer.FlatStyle = FlatStyle.Flat;
            btnGuardarChofer.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarChofer.ForeColor = SystemColors.ControlLightLight;
            btnGuardarChofer.Image = Properties.Resources.icons8_autobús_32__1_;
            btnGuardarChofer.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardarChofer.Location = new Point(0, 153);
            btnGuardarChofer.Name = "btnGuardarChofer";
            btnGuardarChofer.Size = new Size(372, 96);
            btnGuardarChofer.TabIndex = 7;
            btnGuardarChofer.Text = "AGREGAR CHOFER";
            btnGuardarChofer.UseVisualStyleBackColor = false;
            btnGuardarChofer.Click += btnGuardarChofer_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.channels4_profile;
            pictureBox1.Location = new Point(69, 686);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(215, 126);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(85, 139, 198);
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Image = Properties.Resources.icons8_autobús_32__1_;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, 486);
            button3.Name = "button3";
            button3.Size = new Size(372, 97);
            button3.TabIndex = 4;
            button3.Text = "ELIMINAR";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(85, 139, 198);
            btnActualizar.BackgroundImageLayout = ImageLayout.Zoom;
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.ForeColor = SystemColors.ControlLightLight;
            btnActualizar.Image = Properties.Resources.icons8_autobús_32__1_;
            btnActualizar.ImageAlign = ContentAlignment.MiddleLeft;
            btnActualizar.Location = new Point(0, 315);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(372, 100);
            btnActualizar.TabIndex = 3;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.FromArgb(85, 139, 198);
            btnNuevo.BackgroundImageLayout = ImageLayout.Zoom;
            btnNuevo.Cursor = Cursors.Hand;
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevo.ForeColor = SystemColors.ControlLightLight;
            btnNuevo.Image = Properties.Resources.icons8_autobús_32__1_;
            btnNuevo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevo.Location = new Point(0, 12);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(372, 96);
            btnNuevo.TabIndex = 2;
            btnNuevo.Text = "AGREGAR BUS";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(85, 139, 198);
            btnCancelar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ControlLightLight;
            btnCancelar.Image = Properties.Resources.icons8_x_501;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(1268, 437);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(267, 56);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "    CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(397, 544);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1138, 120);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // TextBox1
            // 
            TextBox1.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBox1.Location = new Point(397, 153);
            TextBox1.Multiline = true;
            TextBox1.Name = "TextBox1";
            TextBox1.Size = new Size(321, 36);
            TextBox1.TabIndex = 3;
            // 
            // TextBox2
            // 
            TextBox2.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBox2.Location = new Point(397, 252);
            TextBox2.Multiline = true;
            TextBox2.Name = "TextBox2";
            TextBox2.Size = new Size(321, 36);
            TextBox2.TabIndex = 4;
            // 
            // TextBox3
            // 
            TextBox3.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBox3.Location = new Point(397, 437);
            TextBox3.Multiline = true;
            TextBox3.Name = "TextBox3";
            TextBox3.Size = new Size(321, 36);
            TextBox3.TabIndex = 5;
            // 
            // TextBox4
            // 
            TextBox4.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBox4.Location = new Point(397, 344);
            TextBox4.Multiline = true;
            TextBox4.Name = "TextBox4";
            TextBox4.Size = new Size(321, 36);
            TextBox4.TabIndex = 6;
            // 
            // TextBox5
            // 
            TextBox5.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBox5.Location = new Point(879, 153);
            TextBox5.Multiline = true;
            TextBox5.Name = "TextBox5";
            TextBox5.Size = new Size(321, 36);
            TextBox5.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Corbel", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(800, 61);
            label2.Name = "label2";
            label2.Size = new Size(96, 36);
            label2.TabIndex = 9;
            label2.Text = "MENU";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(397, 211);
            label3.Name = "label3";
            label3.Size = new Size(69, 21);
            label3.TabIndex = 10;
            label3.Text = "Modelo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(397, 391);
            label4.Name = "label4";
            label4.Size = new Size(51, 21);
            label4.TabIndex = 11;
            label4.Text = "Placa";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(397, 306);
            label5.Name = "label5";
            label5.Size = new Size(51, 21);
            label5.TabIndex = 12;
            label5.Text = "Color";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(881, 109);
            label6.Name = "label6";
            label6.Size = new Size(41, 21);
            label6.TabIndex = 13;
            label6.Text = "Año";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(397, 109);
            label7.Name = "label7";
            label7.Size = new Size(57, 21);
            label7.TabIndex = 14;
            label7.Text = "Marca";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(881, 251);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(321, 37);
            txtNombre.TabIndex = 15;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(881, 344);
            txtApellido.Multiline = true;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(321, 37);
            txtApellido.TabIndex = 16;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(880, 436);
            txtCedula.Multiline = true;
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(321, 37);
            txtCedula.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(881, 211);
            label8.Name = "label8";
            label8.Size = new Size(128, 21);
            label8.TabIndex = 20;
            label8.Text = "Nombre Chofer";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(879, 306);
            label9.Name = "label9";
            label9.Size = new Size(130, 21);
            label9.TabIndex = 21;
            label9.Text = "Apellido Chofer";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.Control;
            label10.Location = new Point(880, 391);
            label10.Name = "label10";
            label10.Size = new Size(118, 21);
            label10.TabIndex = 22;
            label10.Text = "Cedula Chofer";
            // 
            // txtFechaNacimiento
            // 
            txtFechaNacimiento.Location = new Point(1268, 156);
            txtFechaNacimiento.Name = "txtFechaNacimiento";
            txtFechaNacimiento.Size = new Size(253, 23);
            txtFechaNacimiento.TabIndex = 23;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.Control;
            label11.Location = new Point(1268, 109);
            label11.Name = "label11";
            label11.Size = new Size(155, 21);
            label11.TabIndex = 24;
            label11.Text = "Nacimiento Chofer";
            label11.Click += label11_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.Control;
            label12.Location = new Point(1268, 211);
            label12.Name = "label12";
            label12.Size = new Size(45, 21);
            label12.TabIndex = 25;
            label12.Text = "Ruta";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Charles", "Villa Mella", "La Churchill", "Puente Juan Carlo", "San Pedro De Macoris" });
            comboBox1.Location = new Point(1271, 247);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(250, 23);
            comboBox1.TabIndex = 26;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.ButtonFace;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(397, 694);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(1138, 141);
            dataGridView2.TabIndex = 27;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 122, 204);
            ClientSize = new Size(1597, 861);
            Controls.Add(dataGridView2);
            Controls.Add(comboBox1);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(txtFechaNacimiento);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtCedula);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label7);
            Controls.Add(btnCancelar);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(TextBox5);
            Controls.Add(TextBox4);
            Controls.Add(TextBox3);
            Controls.Add(TextBox2);
            Controls.Add(TextBox1);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnNuevo;
        private PictureBox pictureBox1;
        private Button btnCancelar;
        private Button button3;
        private Button btnActualizar;
        private DataGridView dataGridView1;
        private TextBox TextBox1;
        private Label label1;
        private TextBox TextBox2;
        private TextBox TextBox3;
        private TextBox TextBox4;
        private TextBox TextBox5;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox2;
        private Button btnGuardarChofer;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtCedula;
        private Label label8;
        private Label label9;
        private Label label10;
        private DateTimePicker txtFechaNacimiento;
        private Label label11;
        private Label label12;
        private ComboBox comboBox1;
        private DataGridView dataGridView2;
    }
}
