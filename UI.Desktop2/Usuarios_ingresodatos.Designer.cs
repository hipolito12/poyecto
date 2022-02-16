
namespace UI.Desktop2
{
    partial class Usuarios_ingresodatos
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
            this.chkhabilitado = new System.Windows.Forms.CheckBox();
            this.chkcambiaclave = new System.Windows.Forms.CheckBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.txtapelliod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkhabilitado
            // 
            this.chkhabilitado.AutoSize = true;
            this.chkhabilitado.Location = new System.Drawing.Point(748, 71);
            this.chkhabilitado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkhabilitado.Name = "chkhabilitado";
            this.chkhabilitado.Size = new System.Drawing.Size(103, 24);
            this.chkhabilitado.TabIndex = 0;
            this.chkhabilitado.Text = "habilitado";
            this.chkhabilitado.UseVisualStyleBackColor = true;
            this.chkhabilitado.CheckedChanged += new System.EventHandler(this.chkhabilitado_CheckedChanged);
            // 
            // chkcambiaclave
            // 
            this.chkcambiaclave.AutoSize = true;
            this.chkcambiaclave.Location = new System.Drawing.Point(748, 148);
            this.chkcambiaclave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkcambiaclave.Name = "chkcambiaclave";
            this.chkcambiaclave.Size = new System.Drawing.Size(134, 24);
            this.chkcambiaclave.TabIndex = 1;
            this.chkcambiaclave.Text = "Cambiar clave";
            this.chkcambiaclave.UseVisualStyleBackColor = true;
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(544, 66);
            this.txtusuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(148, 26);
            this.txtusuario.TabIndex = 2;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(154, 68);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(148, 26);
            this.txtnombre.TabIndex = 3;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(544, 231);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(148, 26);
            this.txtemail.TabIndex = 4;
            // 
            // txtclave
            // 
            this.txtclave.Location = new System.Drawing.Point(544, 148);
            this.txtclave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtclave.Name = "txtclave";
            this.txtclave.Size = new System.Drawing.Size(148, 26);
            this.txtclave.TabIndex = 5;
            // 
            // txtapelliod
            // 
            this.txtapelliod.Location = new System.Drawing.Point(154, 152);
            this.txtapelliod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtapelliod.Name = "txtapelliod";
            this.txtapelliod.Size = new System.Drawing.Size(148, 26);
            this.txtapelliod.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(440, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Clave";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 163);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(442, 242);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Email";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(354, 288);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(166, 35);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "Acpetar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // Usuarios_ingresodatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 331);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtapelliod);
            this.Controls.Add(this.txtclave);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.chkcambiaclave);
            this.Controls.Add(this.chkhabilitado);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Usuarios_ingresodatos";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_ingresodatos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox chkhabilitado;
        public System.Windows.Forms.CheckBox chkcambiaclave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAceptar;
        public System.Windows.Forms.TextBox txtusuario;
        public System.Windows.Forms.TextBox txtnombre;
        public System.Windows.Forms.TextBox txtemail;
        public System.Windows.Forms.TextBox txtclave;
        public System.Windows.Forms.TextBox txtapelliod;
    }
}