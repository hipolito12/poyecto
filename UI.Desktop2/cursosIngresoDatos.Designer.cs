
namespace UI.Desktop2
{
    partial class cursos1
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtanio = new System.Windows.Forms.TextBox();
            this.txtCupo = new System.Windows.Forms.TextBox();
            this.ComboMateria = new System.Windows.Forms.ComboBox();
            this.comboComision = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Materia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cupo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Comision";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(410, 65);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Año calendario";
            // 
            // txtanio
            // 
            this.txtanio.Location = new System.Drawing.Point(536, 60);
            this.txtanio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtanio.Name = "txtanio";
            this.txtanio.Size = new System.Drawing.Size(148, 26);
            this.txtanio.TabIndex = 4;
            // 
            // txtCupo
            // 
            this.txtCupo.Location = new System.Drawing.Point(536, 138);
            this.txtCupo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCupo.Name = "txtCupo";
            this.txtCupo.Size = new System.Drawing.Size(148, 26);
            this.txtCupo.TabIndex = 5;
            // 
            // ComboMateria
            // 
            this.ComboMateria.FormattingEnabled = true;
            this.ComboMateria.Location = new System.Drawing.Point(150, 60);
            this.ComboMateria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComboMateria.Name = "ComboMateria";
            this.ComboMateria.Size = new System.Drawing.Size(180, 28);
            this.ComboMateria.TabIndex = 6;
            // 
            // comboComision
            // 
            this.comboComision.FormattingEnabled = true;
            this.comboComision.Location = new System.Drawing.Point(150, 143);
            this.comboComision.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboComision.Name = "comboComision";
            this.comboComision.Size = new System.Drawing.Size(180, 28);
            this.comboComision.TabIndex = 7;
            this.comboComision.SelectedIndexChanged += new System.EventHandler(this.comboComision_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(267, 277);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cursos1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 386);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboComision);
            this.Controls.Add(this.ComboMateria);
            this.Controls.Add(this.txtCupo);
            this.Controls.Add(this.txtanio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "cursos1";
            this.Text = "cursos";
            this.Load += new System.EventHandler(this.cursos1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtanio;
        public System.Windows.Forms.TextBox txtCupo;
        private System.Windows.Forms.ComboBox ComboMateria;
        private System.Windows.Forms.ComboBox comboComision;
        private System.Windows.Forms.Button button1;
    }
}