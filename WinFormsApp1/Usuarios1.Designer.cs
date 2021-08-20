
namespace UI.Desktop
{
    partial class Usuarios1
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
            this.lblusuario = new System.Windows.Forms.Label();
            this.lblclave = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblapellido = new System.Windows.Forms.Label();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.habilitadoo = new System.Windows.Forms.CheckBox();
            this.btnlata = new System.Windows.Forms.Button();
            this.btnmodificacion = new System.Windows.Forms.Button();
            this.txtnombreU = new System.Windows.Forms.TextBox();
            this.lblu = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.nueva = new System.Windows.Forms.CheckBox();
            this.txtpersona = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Location = new System.Drawing.Point(56, 92);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(63, 15);
            this.lblusuario.TabIndex = 0;
            this.lblusuario.Text = "persona ID";
            this.lblusuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblclave
            // 
            this.lblclave.AutoSize = true;
            this.lblclave.Location = new System.Drawing.Point(67, 143);
            this.lblclave.Name = "lblclave";
            this.lblclave.Size = new System.Drawing.Size(36, 15);
            this.lblclave.TabIndex = 1;
            this.lblclave.Text = "Clave";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(67, 224);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(36, 15);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(324, 92);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(51, 15);
            this.lblnombre.TabIndex = 6;
            this.lblnombre.Text = "Nombre";
            this.lblnombre.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblapellido
            // 
            this.lblapellido.AutoSize = true;
            this.lblapellido.Location = new System.Drawing.Point(324, 172);
            this.lblapellido.Name = "lblapellido";
            this.lblapellido.Size = new System.Drawing.Size(51, 15);
            this.lblapellido.TabIndex = 7;
            this.lblapellido.Text = "Apellido";
            // 
            // txtclave
            // 
            this.txtclave.Location = new System.Drawing.Point(131, 140);
            this.txtclave.Name = "txtclave";
            this.txtclave.Size = new System.Drawing.Size(132, 23);
            this.txtclave.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(131, 224);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(132, 23);
            this.txtEmail.TabIndex = 11;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(406, 92);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(130, 23);
            this.txtNombre.TabIndex = 14;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(406, 169);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(130, 23);
            this.txtApellido.TabIndex = 15;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // habilitadoo
            // 
            this.habilitadoo.AutoSize = true;
            this.habilitadoo.Location = new System.Drawing.Point(354, 228);
            this.habilitadoo.Name = "habilitadoo";
            this.habilitadoo.Size = new System.Drawing.Size(69, 19);
            this.habilitadoo.TabIndex = 16;
            this.habilitadoo.Text = "habilitar";
            this.habilitadoo.UseVisualStyleBackColor = true;
            this.habilitadoo.CheckedChanged += new System.EventHandler(this.checkahab_CheckedChanged);
            // 
            // btnlata
            // 
            this.btnlata.Location = new System.Drawing.Point(131, 278);
            this.btnlata.Name = "btnlata";
            this.btnlata.Size = new System.Drawing.Size(75, 23);
            this.btnlata.TabIndex = 17;
            this.btnlata.Text = "Agregar";
            this.btnlata.UseVisualStyleBackColor = true;
            this.btnlata.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnmodificacion
            // 
            this.btnmodificacion.Location = new System.Drawing.Point(406, 278);
            this.btnmodificacion.Name = "btnmodificacion";
            this.btnmodificacion.Size = new System.Drawing.Size(95, 23);
            this.btnmodificacion.TabIndex = 19;
            this.btnmodificacion.Text = "Editar";
            this.btnmodificacion.UseVisualStyleBackColor = true;
            this.btnmodificacion.Click += new System.EventHandler(this.btnmodificacion_Click);
            // 
            // txtnombreU
            // 
            this.txtnombreU.Location = new System.Drawing.Point(131, 184);
            this.txtnombreU.Name = "txtnombreU";
            this.txtnombreU.Size = new System.Drawing.Size(132, 23);
            this.txtnombreU.TabIndex = 20;
            // 
            // lblu
            // 
            this.lblu.AutoSize = true;
            this.lblu.Location = new System.Drawing.Point(67, 187);
            this.lblu.Name = "lblu";
            this.lblu.Size = new System.Drawing.Size(47, 15);
            this.lblu.TabIndex = 21;
            this.lblu.Text = "Usuario";
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.SystemColors.Control;
            this.txtid.ForeColor = System.Drawing.SystemColors.Control;
            this.txtid.Location = new System.Drawing.Point(550, 307);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 23);
            this.txtid.TabIndex = 22;
            this.txtid.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // nueva
            // 
            this.nueva.AutoSize = true;
            this.nueva.Location = new System.Drawing.Point(489, 226);
            this.nueva.Name = "nueva";
            this.nueva.Size = new System.Drawing.Size(90, 19);
            this.nueva.TabIndex = 23;
            this.nueva.Text = "clave Nueva";
            this.nueva.UseVisualStyleBackColor = true;
            // 
            // txtpersona
            // 
            this.txtpersona.Location = new System.Drawing.Point(131, 92);
            this.txtpersona.Name = "txtpersona";
            this.txtpersona.Size = new System.Drawing.Size(132, 23);
            this.txtpersona.TabIndex = 24;
            this.txtpersona.TextChanged += new System.EventHandler(this.txtpersona_TextChanged_1);
            // 
            // Usuarios1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 333);
            this.Controls.Add(this.txtpersona);
            this.Controls.Add(this.nueva);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lblu);
            this.Controls.Add(this.txtnombreU);
            this.Controls.Add(this.btnmodificacion);
            this.Controls.Add(this.btnlata);
            this.Controls.Add(this.habilitadoo);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtclave);
            this.Controls.Add(this.lblapellido);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblclave);
            this.Controls.Add(this.lblusuario);
            this.Name = "Usuarios1";
            this.Text = "Usuarios1";
            this.Load += new System.EventHandler(this.Usuarios1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label lblclave;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblapellido;
        private System.Windows.Forms.Button btnlata;
        private System.Windows.Forms.Button btnmodificacion;
        private System.Windows.Forms.Label lblu;
        public System.Windows.Forms.TextBox txtclave;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtApellido;
        public System.Windows.Forms.TextBox txtnombreU;
        public System.Windows.Forms.TextBox txtid;
        public System.Windows.Forms.CheckBox habilitadoo;
        public System.Windows.Forms.CheckBox nueva;
        public System.Windows.Forms.TextBox txtpersona;
    }
}