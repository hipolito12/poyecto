
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
            this.btnalta = new System.Windows.Forms.Button();
            this.combo_id_Curso = new System.Windows.Forms.ComboBox();
            this.Combo_id_docente = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cargos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID_docente";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID_Curso";
            // 
            // txtcargos
            // 
            this.txtcargos.Location = new System.Drawing.Point(130, 70);
            this.txtcargos.Name = "txtcargos";
            this.txtcargos.Size = new System.Drawing.Size(186, 20);
            this.txtcargos.TabIndex = 3;
            // 
            // btnalta
            // 
            this.btnalta.Location = new System.Drawing.Point(86, 206);
            this.btnalta.Name = "btnalta";
            this.btnalta.Size = new System.Drawing.Size(144, 23);
            this.btnalta.TabIndex = 6;
            this.btnalta.Text = "Aceptar";
            this.btnalta.UseVisualStyleBackColor = true;
            this.btnalta.Click += new System.EventHandler(this.btnalta_Click);
            // 
            // combo_id_Curso
            // 
            this.combo_id_Curso.FormattingEnabled = true;
            this.combo_id_Curso.Location = new System.Drawing.Point(130, 163);
            this.combo_id_Curso.Name = "combo_id_Curso";
            this.combo_id_Curso.Size = new System.Drawing.Size(186, 21);
            this.combo_id_Curso.TabIndex = 7;
            // 
            // Combo_id_docente
            // 
            this.Combo_id_docente.FormattingEnabled = true;
            this.Combo_id_docente.Location = new System.Drawing.Point(130, 121);
            this.Combo_id_docente.Name = "Combo_id_docente";
            this.Combo_id_docente.Size = new System.Drawing.Size(186, 21);
            this.Combo_id_docente.TabIndex = 8;
            // 
            // profesores_modulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 252);
            this.Controls.Add(this.Combo_id_docente);
            this.Controls.Add(this.combo_id_Curso);
            this.Controls.Add(this.btnalta);
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
        public System.Windows.Forms.Button btnalta;
        private System.Windows.Forms.ComboBox combo_id_Curso;
        public System.Windows.Forms.ComboBox Combo_id_docente;
    }
}