
namespace UI.Desktop2.Login
{
    partial class Alumnos
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
            this.texto = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // texto
            // 
            this.texto.AcceptsTab = true;
            this.texto.Location = new System.Drawing.Point(154, 12);
            this.texto.Name = "texto";
            this.texto.Size = new System.Drawing.Size(453, 64);
            this.texto.TabIndex = 0;
            this.texto.Text = "";
            // 
            // Alumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.texto);
            this.Name = "Alumnos";
            this.Text = "Alumnos";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox texto;
    }
}