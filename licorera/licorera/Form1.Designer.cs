namespace licorera
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
            groupBox1 = new GroupBox();
            btnFormulario2 = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnGuardar = new Button();
            txtTelefonoUser = new TextBox();
            txtCorreoUser = new TextBox();
            txtCedulaUser = new TextBox();
            txtApellidoUser = new TextBox();
            txtNombreUser = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnFormulario2);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnModificar);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(txtTelefonoUser);
            groupBox1.Controls.Add(txtCorreoUser);
            groupBox1.Controls.Add(txtCedulaUser);
            groupBox1.Controls.Add(txtApellidoUser);
            groupBox1.Controls.Add(txtNombreUser);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(39, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(220, 354);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Usuario";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnFormulario2
            // 
            btnFormulario2.Location = new Point(15, 227);
            btnFormulario2.Name = "btnFormulario2";
            btnFormulario2.Size = new Size(199, 23);
            btnFormulario2.TabIndex = 13;
            btnFormulario2.Text = "Formulario 2";
            btnFormulario2.UseVisualStyleBackColor = true;
            btnFormulario2.Click += button1_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(119, 297);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(95, 32);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(12, 297);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(101, 32);
            btnModificar.TabIndex = 11;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(12, 258);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(202, 33);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // txtTelefonoUser
            // 
            txtTelefonoUser.Location = new Point(80, 178);
            txtTelefonoUser.Name = "txtTelefonoUser";
            txtTelefonoUser.Size = new Size(134, 23);
            txtTelefonoUser.TabIndex = 9;
            // 
            // txtCorreoUser
            // 
            txtCorreoUser.Location = new Point(80, 140);
            txtCorreoUser.Name = "txtCorreoUser";
            txtCorreoUser.Size = new Size(134, 23);
            txtCorreoUser.TabIndex = 8;
            // 
            // txtCedulaUser
            // 
            txtCedulaUser.Location = new Point(80, 98);
            txtCedulaUser.Name = "txtCedulaUser";
            txtCedulaUser.Size = new Size(134, 23);
            txtCedulaUser.TabIndex = 7;
            // 
            // txtApellidoUser
            // 
            txtApellidoUser.Location = new Point(80, 60);
            txtApellidoUser.Name = "txtApellidoUser";
            txtApellidoUser.Size = new Size(134, 23);
            txtApellidoUser.TabIndex = 6;
            // 
            // txtNombreUser
            // 
            txtNombreUser.Location = new Point(80, 22);
            txtNombreUser.Name = "txtNombreUser";
            txtNombreUser.Size = new Size(134, 23);
            txtNombreUser.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 186);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 4;
            label5.Text = "Telefono:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 148);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 3;
            label4.Text = "Correo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 106);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 2;
            label3.Text = "Cedula:";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 68);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "Apellidos:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 30);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombres:";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(265, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(570, 354);
            dataGridView1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 389);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtTelefonoUser;
        private TextBox txtCorreoUser;
        private TextBox txtCedulaUser;
        private TextBox txtApellidoUser;
        private TextBox txtNombreUser;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnGuardar;
        private Button btnFormulario2;
    }
}
