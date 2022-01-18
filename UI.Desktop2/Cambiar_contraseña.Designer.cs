
namespace UI.Desktop2
{
    partial class Cambiar_contraseña
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
            this.txtactual = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnueva = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtconfirmar = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // txtactual
            // 
            this.txtactual.Location = new System.Drawing.Point(32, 132);
            this.txtactual.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtactual.Multiline = true;
            this.txtactual.Name = "txtactual";
            this.txtactual.Size = new System.Drawing.Size(516, 42);
            this.txtactual.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese contraseña actual";
            // 
            // txtnueva
            // 
            this.txtnueva.Location = new System.Drawing.Point(36, 303);
            this.txtnueva.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnueva.Multiline = true;
            this.txtnueva.Name = "txtnueva";
            this.txtnueva.Size = new System.Drawing.Size(516, 42);
            this.txtnueva.TabIndex = 2;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(154, 515);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(248, 54);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 231);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ingrese Nueva contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 385);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(330, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Confirme nueva contraseña";
            // 
            // txtconfirmar
            // 
            this.txtconfirmar.Location = new System.Drawing.Point(36, 455);
            this.txtconfirmar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtconfirmar.Multiline = true;
            this.txtconfirmar.Name = "txtconfirmar";
            this.txtconfirmar.Size = new System.Drawing.Size(516, 42);
            this.txtconfirmar.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 66);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1008, 503);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // Cambiar_contraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 588);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtconfirmar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtnueva);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtactual);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Cambiar_contraseña";
            this.Text = "Cambiar_contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtactual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnueva;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtconfirmar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}