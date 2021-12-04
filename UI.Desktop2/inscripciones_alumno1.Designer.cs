
namespace UI.Desktop2
{
    partial class inscripciones_alumno1
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
            this.Combocurso = new System.Windows.Forms.ComboBox();
            this.combocondicionalu = new System.Windows.Forms.TextBox();
            this.lblestado = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblalumno = new System.Windows.Forms.Label();
            this.lblnota = new System.Windows.Forms.Label();
            this.txtnota = new System.Windows.Forms.TextBox();
            this.Comboalumno = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Combocurso
            // 
            this.Combocurso.FormattingEnabled = true;
            this.Combocurso.Location = new System.Drawing.Point(106, 152);
            this.Combocurso.Name = "Combocurso";
            this.Combocurso.Size = new System.Drawing.Size(196, 21);
            this.Combocurso.TabIndex = 0;
            // 
            // combocondicionalu
            // 
            this.combocondicionalu.Location = new System.Drawing.Point(106, 37);
            this.combocondicionalu.Name = "combocondicionalu";
            this.combocondicionalu.Size = new System.Drawing.Size(196, 20);
            this.combocondicionalu.TabIndex = 1;
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Location = new System.Drawing.Point(9, 37);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(91, 13);
            this.lblestado.TabIndex = 2;
            this.lblestado.Text = "Condicion alumno";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(26, 201);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(255, 23);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(49, 160);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(48, 13);
            this.lblCurso.TabIndex = 4;
            this.lblCurso.Text = "ID Curso";
            // 
            // lblalumno
            // 
            this.lblalumno.AutoSize = true;
            this.lblalumno.Location = new System.Drawing.Point(49, 122);
            this.lblalumno.Name = "lblalumno";
            this.lblalumno.Size = new System.Drawing.Size(52, 13);
            this.lblalumno.TabIndex = 5;
            this.lblalumno.Text = "IDalumno";
            this.lblalumno.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblnota
            // 
            this.lblnota.AutoSize = true;
            this.lblnota.Location = new System.Drawing.Point(49, 86);
            this.lblnota.Name = "lblnota";
            this.lblnota.Size = new System.Drawing.Size(30, 13);
            this.lblnota.TabIndex = 6;
            this.lblnota.Text = "Nota";
            // 
            // txtnota
            // 
            this.txtnota.Location = new System.Drawing.Point(106, 79);
            this.txtnota.Name = "txtnota";
            this.txtnota.Size = new System.Drawing.Size(196, 20);
            this.txtnota.TabIndex = 7;
            // 
            // Comboalumno
            // 
            this.Comboalumno.FormattingEnabled = true;
            this.Comboalumno.Location = new System.Drawing.Point(106, 122);
            this.Comboalumno.Name = "Comboalumno";
            this.Comboalumno.Size = new System.Drawing.Size(196, 21);
            this.Comboalumno.TabIndex = 8;
            // 
            // inscripciones_alumno1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 291);
            this.Controls.Add(this.Comboalumno);
            this.Controls.Add(this.txtnota);
            this.Controls.Add(this.lblnota);
            this.Controls.Add(this.lblalumno);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblestado);
            this.Controls.Add(this.combocondicionalu);
            this.Controls.Add(this.Combocurso);
            this.Name = "inscripciones_alumno1";
            this.Text = "inscripciones_alumno1";
            this.Load += new System.EventHandler(this.inscripciones_alumno1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblalumno;
        private System.Windows.Forms.Label lblnota;
        public System.Windows.Forms.ComboBox Combocurso;
        public System.Windows.Forms.TextBox combocondicionalu;
        public System.Windows.Forms.TextBox txtnota;
        public System.Windows.Forms.ComboBox Comboalumno;
    }
}