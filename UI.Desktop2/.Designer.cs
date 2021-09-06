
namespace UI.Desktop2
{
    partial class profesores_modulos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcargos = new System.Windows.Forms.TextBox();
            this.txtdocente = new System.Windows.Forms.TextBox();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.btnalta = new System.Windows.Forms.Button();
            this.btnEDT = new System.Windows.Forms.Button();
            this.lblcargo = new System.Windows.Forms.Label();
            this.txtdictado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cargos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID_docente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID_Curso";
            // 
            // txtcargos
            // 
            this.txtcargos.Location = new System.Drawing.Point(130, 70);
            this.txtcargos.Name = "txtcargos";
            this.txtcargos.Size = new System.Drawing.Size(100, 20);
            this.txtcargos.TabIndex = 3;
            // 
            // txtdocente
            // 
            this.txtdocente.Location = new System.Drawing.Point(130, 126);
            this.txtdocente.Name = "txtdocente";
            this.txtdocente.Size = new System.Drawing.Size(100, 20);
            this.txtdocente.TabIndex = 4;
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(130, 188);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(100, 20);
            this.txtCurso.TabIndex = 5;
            // 
            // btnalta
            // 
            this.btnalta.Location = new System.Drawing.Point(12, 3);
            this.btnalta.Name = "btnalta";
            this.btnalta.Size = new System.Drawing.Size(75, 23);
            this.btnalta.TabIndex = 6;
            this.btnalta.Text = "Alta";
            this.btnalta.UseVisualStyleBackColor = true;
            this.btnalta.Click += new System.EventHandler(this.btnalta_Click);
            // 
            // btnEDT
            // 
            this.btnEDT.Location = new System.Drawing.Point(93, 3);
            this.btnEDT.Name = "btnEDT";
            this.btnEDT.Size = new System.Drawing.Size(75, 23);
            this.btnEDT.TabIndex = 7;
            this.btnEDT.Text = "Modificar";
            this.btnEDT.UseVisualStyleBackColor = true;
            this.btnEDT.Click += new System.EventHandler(this.btnEDT_Click);
            // 
            // lblcargo
            // 
            this.lblcargo.AutoSize = true;
            this.lblcargo.Location = new System.Drawing.Point(322, 77);
            this.lblcargo.Name = "lblcargo";
            this.lblcargo.Size = new System.Drawing.Size(61, 13);
            this.lblcargo.TabIndex = 8;
            this.lblcargo.Text = "DictadoI_D";
            // 
            // txtdictado
            // 
            this.txtdictado.Location = new System.Drawing.Point(388, 77);
            this.txtdictado.Name = "txtdictado";
            this.txtdictado.Size = new System.Drawing.Size(100, 20);
            this.txtdictado.TabIndex = 9;
            // 
            // profesores_modulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 252);
            this.Controls.Add(this.txtdictado);
            this.Controls.Add(this.lblcargo);
            this.Controls.Add(this.btnEDT);
            this.Controls.Add(this.btnalta);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.txtdocente);
            this.Controls.Add(this.txtcargos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "profesores_modulos";
            this.Text = "profesores_modulos";
            this.Load += new System.EventHandler(this.profesores_modulos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtcargos;
        public System.Windows.Forms.TextBox txtdocente;
        public System.Windows.Forms.TextBox txtCurso;
        public System.Windows.Forms.Button btnalta;
        public System.Windows.Forms.Button btnEDT;
        public System.Windows.Forms.TextBox txtdictado;
        public System.Windows.Forms.Label lblcargo;
    }
}