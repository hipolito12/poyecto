﻿
namespace UI.Desktop2
{
    partial class Comisiones_1
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
            this.btnaceptar = new System.Windows.Forms.Button();
            this.comboidpan = new System.Windows.Forms.ComboBox();
            this.lblplan = new System.Windows.Forms.Label();
            this.lblanio = new System.Windows.Forms.Label();
            this.lbldescripcion = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.textanio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnaceptar
            // 
            this.btnaceptar.Location = new System.Drawing.Point(18, 428);
            this.btnaceptar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(464, 35);
            this.btnaceptar.TabIndex = 0;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // comboidpan
            // 
            this.comboidpan.FormattingEnabled = true;
            this.comboidpan.Location = new System.Drawing.Point(180, 260);
            this.comboidpan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboidpan.Name = "comboidpan";
            this.comboidpan.Size = new System.Drawing.Size(254, 28);
            this.comboidpan.TabIndex = 2;
            // 
            // lblplan
            // 
            this.lblplan.AutoSize = true;
            this.lblplan.Location = new System.Drawing.Point(60, 265);
            this.lblplan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblplan.Name = "lblplan";
            this.lblplan.Size = new System.Drawing.Size(60, 20);
            this.lblplan.TabIndex = 4;
            this.lblplan.Text = "ID plan";
            // 
            // lblanio
            // 
            this.lblanio.AutoSize = true;
            this.lblanio.Location = new System.Drawing.Point(60, 205);
            this.lblanio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblanio.Name = "lblanio";
            this.lblanio.Size = new System.Drawing.Size(41, 20);
            this.lblanio.TabIndex = 5;
            this.lblanio.Text = "Anio";
            // 
            // lbldescripcion
            // 
            this.lbldescripcion.AutoSize = true;
            this.lbldescripcion.Location = new System.Drawing.Point(33, 151);
            this.lbldescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldescripcion.Name = "lbldescripcion";
            this.lbldescripcion.Size = new System.Drawing.Size(92, 20);
            this.lbldescripcion.TabIndex = 6;
            this.lbldescripcion.Text = "Descripcion";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(180, 146);
            this.txtdescripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(254, 26);
            this.txtdescripcion.TabIndex = 7;
            // 
            // textanio
            // 
            this.textanio.Location = new System.Drawing.Point(180, 205);
            this.textanio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textanio.Name = "textanio";
            this.textanio.Size = new System.Drawing.Size(254, 26);
            this.textanio.TabIndex = 8;
            // 
            // Comisiones_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 558);
            this.Controls.Add(this.textanio);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.lbldescripcion);
            this.Controls.Add(this.lblanio);
            this.Controls.Add(this.lblplan);
            this.Controls.Add(this.comboidpan);
            this.Controls.Add(this.btnaceptar);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Comisiones_1";
            this.Text = "Comisiones";
            this.Load += new System.EventHandler(this.Comisiones_1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Label lblplan;
        private System.Windows.Forms.Label lblanio;
        private System.Windows.Forms.Label lbldescripcion;
        public System.Windows.Forms.ComboBox comboidpan;
        public System.Windows.Forms.TextBox txtdescripcion;
        public System.Windows.Forms.TextBox textanio;
    }
}