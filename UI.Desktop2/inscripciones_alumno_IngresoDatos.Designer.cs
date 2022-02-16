
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
            this.lblestado = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblalumno = new System.Windows.Forms.Label();
            this.lblnota = new System.Windows.Forms.Label();
            this.txtnota = new System.Windows.Forms.TextBox();
            this.Comboalumno = new System.Windows.Forms.ComboBox();
            this.txtauxalumno = new System.Windows.Forms.TextBox();
            this.txtauxcurso = new System.Windows.Forms.TextBox();
            this.combocursoaux = new System.Windows.Forms.ComboBox();
            this.combocondicion = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Combocurso
            // 
            this.Combocurso.FormattingEnabled = true;
            this.Combocurso.Location = new System.Drawing.Point(158, 259);
            this.Combocurso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Combocurso.Name = "Combocurso";
            this.Combocurso.Size = new System.Drawing.Size(292, 28);
            this.Combocurso.TabIndex = 0;
            this.Combocurso.SelectedIndexChanged += new System.EventHandler(this.Combocurso_SelectedIndexChanged);
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Location = new System.Drawing.Point(14, 57);
            this.lblestado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(135, 20);
            this.lblestado.TabIndex = 2;
            this.lblestado.Text = "Condicion alumno";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(69, 327);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(382, 35);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(70, 253);
            this.lblCurso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(72, 20);
            this.lblCurso.TabIndex = 4;
            this.lblCurso.Text = "ID Curso";
            // 
            // lblalumno
            // 
            this.lblalumno.AutoSize = true;
            this.lblalumno.Location = new System.Drawing.Point(74, 188);
            this.lblalumno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblalumno.Name = "lblalumno";
            this.lblalumno.Size = new System.Drawing.Size(78, 20);
            this.lblalumno.TabIndex = 5;
            this.lblalumno.Text = "IDalumno";
            this.lblalumno.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblnota
            // 
            this.lblnota.AutoSize = true;
            this.lblnota.Location = new System.Drawing.Point(74, 132);
            this.lblnota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnota.Name = "lblnota";
            this.lblnota.Size = new System.Drawing.Size(43, 20);
            this.lblnota.TabIndex = 6;
            this.lblnota.Text = "Nota";
            // 
            // txtnota
            // 
            this.txtnota.Location = new System.Drawing.Point(159, 122);
            this.txtnota.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnota.Name = "txtnota";
            this.txtnota.Size = new System.Drawing.Size(292, 26);
            this.txtnota.TabIndex = 7;
            // 
            // Comboalumno
            // 
            this.Comboalumno.FormattingEnabled = true;
            this.Comboalumno.Location = new System.Drawing.Point(160, 185);
            this.Comboalumno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Comboalumno.Name = "Comboalumno";
            this.Comboalumno.Size = new System.Drawing.Size(292, 28);
            this.Comboalumno.TabIndex = 8;
            this.Comboalumno.SelectedIndexChanged += new System.EventHandler(this.Comboalumno_SelectedIndexChanged);
            // 
            // txtauxalumno
            // 
            this.txtauxalumno.Location = new System.Drawing.Point(160, 185);
            this.txtauxalumno.Name = "txtauxalumno";
            this.txtauxalumno.Size = new System.Drawing.Size(292, 26);
            this.txtauxalumno.TabIndex = 9;
            // 
            // txtauxcurso
            // 
            this.txtauxcurso.Location = new System.Drawing.Point(158, 259);
            this.txtauxcurso.Name = "txtauxcurso";
            this.txtauxcurso.Size = new System.Drawing.Size(292, 26);
            this.txtauxcurso.TabIndex = 10;
            this.txtauxcurso.TextChanged += new System.EventHandler(this.txtauxcurso_TextChanged);
            // 
            // combocursoaux
            // 
            this.combocursoaux.FormattingEnabled = true;
            this.combocursoaux.Location = new System.Drawing.Point(159, 259);
            this.combocursoaux.Name = "combocursoaux";
            this.combocursoaux.Size = new System.Drawing.Size(291, 28);
            this.combocursoaux.TabIndex = 11;
            this.combocursoaux.SelectedIndexChanged += new System.EventHandler(this.combocursoaux_SelectedIndexChanged);
            // 
            // combocondicion
            // 
            this.combocondicion.AutoCompleteCustomSource.AddRange(new string[] {
            "Aprobado",
            "Aprobacion directa",
            "Libre"});
            this.combocondicion.FormattingEnabled = true;
            this.combocondicion.Items.AddRange(new object[] {
            "Libre",
            "Aprobado",
            "Aprobacion directa"});
            this.combocondicion.Location = new System.Drawing.Point(160, 49);
            this.combocondicion.Name = "combocondicion";
            this.combocondicion.Size = new System.Drawing.Size(290, 28);
            this.combocondicion.TabIndex = 12;
            // 
            // inscripciones_alumno1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 428);
            this.Controls.Add(this.combocondicion);
            this.Controls.Add(this.Comboalumno);
            this.Controls.Add(this.txtnota);
            this.Controls.Add(this.lblnota);
            this.Controls.Add(this.lblalumno);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblestado);
            this.Controls.Add(this.Combocurso);
            this.Controls.Add(this.txtauxcurso);
            this.Controls.Add(this.txtauxalumno);
            this.Controls.Add(this.combocursoaux);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "inscripciones_alumno1";
            this.Text = "inscripciones_alumno1";
            this.Load += new System.EventHandler(this.inscripciones_alumno1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCurso;
        public System.Windows.Forms.ComboBox Combocurso;
        public System.Windows.Forms.TextBox txtnota;
        public System.Windows.Forms.Label lblestado;
        public System.Windows.Forms.Label lblnota;
        public System.Windows.Forms.Button btnAceptar;
        public System.Windows.Forms.Label lblalumno;
        public System.Windows.Forms.ComboBox Comboalumno;
        public System.Windows.Forms.TextBox txtauxalumno;
        public System.Windows.Forms.TextBox txtauxcurso;
        private System.Windows.Forms.ComboBox combocursoaux;
        public System.Windows.Forms.ComboBox combocondicion;
    }
}