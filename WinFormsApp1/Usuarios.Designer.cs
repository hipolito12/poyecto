
namespace UI.Desktop
{
    partial class Usuarios
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblmodificacion = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(509, 330);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblmodificacion
            // 
            this.lblmodificacion.Location = new System.Drawing.Point(592, 345);
            this.lblmodificacion.Name = "lblmodificacion";
            this.lblmodificacion.Size = new System.Drawing.Size(188, 23);
            this.lblmodificacion.TabIndex = 3;
            this.lblmodificacion.Text = "Editar";
            this.lblmodificacion.UseVisualStyleBackColor = true;
            this.lblmodificacion.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::UI.Desktop.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(547, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(267, 313);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(592, 387);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(188, 23);
            this.btnActualizar.TabIndex = 6;
            this.btnActualizar.Text = "Baja";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(592, 425);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(188, 23);
            this.btneditar.TabIndex = 7;
            this.btneditar.Text = "Alta";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 450);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblmodificacion);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button lblmodificacion;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btneditar;
    }
}