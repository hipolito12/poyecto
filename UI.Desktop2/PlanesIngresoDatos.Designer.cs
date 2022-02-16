
namespace UI.Desktop2
{
    partial class PlanesIngresoDatos
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
            this.comboespecialidad = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.comboespecialdad = new System.Windows.Forms.ComboBox();
            this.richdescripcion = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripcion plan";
            // 
            // comboespecialidad
            // 
            this.comboespecialidad.AutoSize = true;
            this.comboespecialidad.Location = new System.Drawing.Point(-2, 208);
            this.comboespecialidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.comboespecialidad.Name = "comboespecialidad";
            this.comboespecialidad.Size = new System.Drawing.Size(107, 20);
            this.comboespecialidad.TabIndex = 2;
            this.comboespecialidad.Text = "Especialidad :";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(201, 288);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(159, 35);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // comboespecialdad
            // 
            this.comboespecialdad.FormattingEnabled = true;
            this.comboespecialdad.Location = new System.Drawing.Point(144, 195);
            this.comboespecialdad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboespecialdad.Name = "comboespecialdad";
            this.comboespecialdad.Size = new System.Drawing.Size(259, 28);
            this.comboespecialdad.TabIndex = 4;
            // 
            // richdescripcion
            // 
            this.richdescripcion.Location = new System.Drawing.Point(74, 80);
            this.richdescripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richdescripcion.Name = "richdescripcion";
            this.richdescripcion.Size = new System.Drawing.Size(420, 72);
            this.richdescripcion.TabIndex = 5;
            this.richdescripcion.Text = "";
            // 
            // PlanesIngresoDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 368);
            this.Controls.Add(this.richdescripcion);
            this.Controls.Add(this.comboespecialdad);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.comboespecialidad);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PlanesIngresoDatos";
            this.Text = "planes";
            this.Load += new System.EventHandler(this.PlanesIngresoDatos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAceptar;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label comboespecialidad;
        public System.Windows.Forms.ComboBox comboespecialdad;
        public System.Windows.Forms.RichTextBox richdescripcion;
    }
}