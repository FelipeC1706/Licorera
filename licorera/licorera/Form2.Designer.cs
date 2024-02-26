namespace licorera
{
    partial class Form2
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
            dgvTablaCliente = new DataGridView();
            groupBox1 = new GroupBox();
            btnEliminarClient = new Button();
            btnModificarClient = new Button();
            btnGuardarClient = new Button();
            txtTelefonoClient = new TextBox();
            txtCorreoClient = new TextBox();
            txtCedulaClient = new TextBox();
            txtApellidoClient = new TextBox();
            txtNombreClient = new TextBox();
            lblTelefClient = new Label();
            lblCorreoClient = new Label();
            lblCedulaClient = new Label();
            lblApellClient = new Label();
            lblNomClient = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTablaCliente).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvTablaCliente
            // 
            dgvTablaCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTablaCliente.Location = new Point(249, 23);
            dgvTablaCliente.Name = "dgvTablaCliente";
            dgvTablaCliente.Size = new Size(570, 354);
            dgvTablaCliente.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEliminarClient);
            groupBox1.Controls.Add(btnModificarClient);
            groupBox1.Controls.Add(btnGuardarClient);
            groupBox1.Controls.Add(txtTelefonoClient);
            groupBox1.Controls.Add(txtCorreoClient);
            groupBox1.Controls.Add(txtCedulaClient);
            groupBox1.Controls.Add(txtApellidoClient);
            groupBox1.Controls.Add(txtNombreClient);
            groupBox1.Controls.Add(lblTelefClient);
            groupBox1.Controls.Add(lblCorreoClient);
            groupBox1.Controls.Add(lblCedulaClient);
            groupBox1.Controls.Add(lblApellClient);
            groupBox1.Controls.Add(lblNomClient);
            groupBox1.Location = new Point(23, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(220, 354);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Cliente";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnEliminarClient
            // 
            btnEliminarClient.Location = new Point(119, 297);
            btnEliminarClient.Name = "btnEliminarClient";
            btnEliminarClient.Size = new Size(95, 32);
            btnEliminarClient.TabIndex = 12;
            btnEliminarClient.Text = "Eliminar";
            btnEliminarClient.UseVisualStyleBackColor = true;
            // 
            // btnModificarClient
            // 
            btnModificarClient.Location = new Point(12, 297);
            btnModificarClient.Name = "btnModificarClient";
            btnModificarClient.Size = new Size(101, 32);
            btnModificarClient.TabIndex = 11;
            btnModificarClient.Text = "Modificar";
            btnModificarClient.UseVisualStyleBackColor = true;
            // 
            // btnGuardarClient
            // 
            btnGuardarClient.Location = new Point(12, 258);
            btnGuardarClient.Name = "btnGuardarClient";
            btnGuardarClient.Size = new Size(202, 33);
            btnGuardarClient.TabIndex = 10;
            btnGuardarClient.Text = "Guardar";
            btnGuardarClient.UseVisualStyleBackColor = true;
            // 
            // txtTelefonoClient
            // 
            txtTelefonoClient.Location = new Point(80, 178);
            txtTelefonoClient.Name = "txtTelefonoClient";
            txtTelefonoClient.Size = new Size(134, 23);
            txtTelefonoClient.TabIndex = 9;
            // 
            // txtCorreoClient
            // 
            txtCorreoClient.Location = new Point(80, 140);
            txtCorreoClient.Name = "txtCorreoClient";
            txtCorreoClient.Size = new Size(134, 23);
            txtCorreoClient.TabIndex = 8;
            // 
            // txtCedulaClient
            // 
            txtCedulaClient.Location = new Point(80, 98);
            txtCedulaClient.Name = "txtCedulaClient";
            txtCedulaClient.Size = new Size(134, 23);
            txtCedulaClient.TabIndex = 7;
            // 
            // txtApellidoClient
            // 
            txtApellidoClient.Location = new Point(80, 60);
            txtApellidoClient.Name = "txtApellidoClient";
            txtApellidoClient.Size = new Size(134, 23);
            txtApellidoClient.TabIndex = 6;
            // 
            // txtNombreClient
            // 
            txtNombreClient.Location = new Point(80, 22);
            txtNombreClient.Name = "txtNombreClient";
            txtNombreClient.Size = new Size(134, 23);
            txtNombreClient.TabIndex = 5;
            // 
            // lblTelefClient
            // 
            lblTelefClient.AutoSize = true;
            lblTelefClient.Location = new Point(15, 186);
            lblTelefClient.Name = "lblTelefClient";
            lblTelefClient.Size = new Size(55, 15);
            lblTelefClient.TabIndex = 4;
            lblTelefClient.Text = "Telefono:";
            // 
            // lblCorreoClient
            // 
            lblCorreoClient.AutoSize = true;
            lblCorreoClient.Location = new Point(15, 148);
            lblCorreoClient.Name = "lblCorreoClient";
            lblCorreoClient.Size = new Size(46, 15);
            lblCorreoClient.TabIndex = 3;
            lblCorreoClient.Text = "Correo:";
            // 
            // lblCedulaClient
            // 
            lblCedulaClient.AutoSize = true;
            lblCedulaClient.Location = new Point(15, 106);
            lblCedulaClient.Name = "lblCedulaClient";
            lblCedulaClient.Size = new Size(47, 15);
            lblCedulaClient.TabIndex = 2;
            lblCedulaClient.Text = "Cedula:";
            // 
            // lblApellClient
            // 
            lblApellClient.AutoSize = true;
            lblApellClient.Location = new Point(15, 68);
            lblApellClient.Name = "lblApellClient";
            lblApellClient.Size = new Size(59, 15);
            lblApellClient.TabIndex = 1;
            lblApellClient.Text = "Apellidos:";
            // 
            // lblNomClient
            // 
            lblNomClient.AutoSize = true;
            lblNomClient.Location = new Point(15, 30);
            lblNomClient.Name = "lblNomClient";
            lblNomClient.Size = new Size(59, 15);
            lblNomClient.TabIndex = 0;
            lblNomClient.Text = "Nombres:";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 389);
            Controls.Add(dgvTablaCliente);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dgvTablaCliente).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvTablaCliente;
        private GroupBox groupBox1;
        private Button btnEliminarClient;
        private Button btnModificarClient;
        private Button btnGuardarClient;
        private TextBox txtTelefonoClient;
        private TextBox txtCorreoClient;
        private TextBox txtCedulaClient;
        private TextBox txtApellidoClient;
        private TextBox txtNombreClient;
        private Label lblTelefClient;
        private Label lblCorreoClient;
        private Label lblCedulaClient;
        private Label lblApellClient;
        private Label lblNomClient;
    }
}