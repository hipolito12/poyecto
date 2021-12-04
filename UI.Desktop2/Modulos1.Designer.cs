
namespace UI.Desktop2
{
    partial class Modulos1
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
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.txtEjecuta = new System.Windows.Forms.TextBox();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripcionde Modulo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ejecuta";
            // 
            // txtdesc
            // 
            this.txtdesc.CausesValidation = false;
            this.txtdesc.Location = new System.Drawing.Point(192, 32);
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(122, 20);
            this.txtdesc.TabIndex = 2;
            // 
            // txtEjecuta
            // 
            this.txtEjecuta.Location = new System.Drawing.Point(192, 79);
            this.txtEjecuta.Name = "txtEjecuta";
            this.txtEjecuta.Size = new System.Drawing.Size(122, 20);
            this.txtEjecuta.TabIndex = 3;
            // 
            // btnaceptar
            // 
            this.btnaceptar.Location = new System.Drawing.Point(141, 172);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(173, 23);
            this.btnaceptar.TabIndex = 4;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Modulos1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 207);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.txtEjecuta);
            this.Controls.Add(this.txtdesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Modulos1";
            this.Text = "Modulos1";
            this.Load += new System.EventHandler(this.Modulos1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtdesc;
        public System.Windows.Forms.TextBox txtEjecuta;
        public System.Windows.Forms.Button btnaceptar;
    }
}