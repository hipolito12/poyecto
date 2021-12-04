
namespace UI.Desktop2
{
    partial class Especialidades1
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richdescripcion = new System.Windows.Forms.RichTextBox();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.richTextBox1.Location = new System.Drawing.Point(143, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(448, 64);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "Ingrese Descripcion de Especialidad";
            // 
            // richdescripcion
            // 
            this.richdescripcion.Location = new System.Drawing.Point(143, 136);
            this.richdescripcion.Name = "richdescripcion";
            this.richdescripcion.Size = new System.Drawing.Size(448, 150);
            this.richdescripcion.TabIndex = 1;
            this.richdescripcion.Text = "";
            this.richdescripcion.TextChanged += new System.EventHandler(this.richdescripcion_TextChanged);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Location = new System.Drawing.Point(244, 334);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(232, 23);
            this.btnaceptar.TabIndex = 2;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // Especialidades1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.richdescripcion);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Especialidades1";
            this.Text = "Especialidades1";
            this.Load += new System.EventHandler(this.Especialidades1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richdescripcion;
        private System.Windows.Forms.Button btnaceptar;
    }
}