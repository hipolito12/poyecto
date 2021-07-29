
namespace UI.Desktop
{
    partial class Planes
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
            this.label1 = new System.Windows.Forms.Label();
            this.LBLespecialidad = new System.Windows.Forms.Label();
            this.Descripcion = new System.Windows.Forms.Label();
            this.txtespecialidad = new System.Windows.Forms.TextBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.BtnInserrtar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(471, 347);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(513, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 1;
            // 
            // LBLespecialidad
            // 
            this.LBLespecialidad.AutoSize = true;
            this.LBLespecialidad.Location = new System.Drawing.Point(489, 62);
            this.LBLespecialidad.Name = "LBLespecialidad";
            this.LBLespecialidad.Size = new System.Drawing.Size(87, 15);
            this.LBLespecialidad.TabIndex = 2;
            this.LBLespecialidad.Text = "Id_especialidad";
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSize = true;
            this.Descripcion.Location = new System.Drawing.Point(512, 176);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(64, 15);
            this.Descripcion.TabIndex = 3;
            this.Descripcion.Text = "Decripcion";
            // 
            // txtespecialidad
            // 
            this.txtespecialidad.Location = new System.Drawing.Point(592, 62);
            this.txtespecialidad.Name = "txtespecialidad";
            this.txtespecialidad.Size = new System.Drawing.Size(185, 23);
            this.txtespecialidad.TabIndex = 5;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(592, 173);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(185, 23);
            this.txtdescripcion.TabIndex = 6;
            this.txtdescripcion.TextChanged += new System.EventHandler(this.txtdescripcion_TextChanged);
            // 
            // BtnInserrtar
            // 
            this.BtnInserrtar.Location = new System.Drawing.Point(514, 245);
            this.BtnInserrtar.Name = "BtnInserrtar";
            this.BtnInserrtar.Size = new System.Drawing.Size(274, 23);
            this.BtnInserrtar.TabIndex = 7;
            this.BtnInserrtar.Text = "Insertar";
            this.BtnInserrtar.UseVisualStyleBackColor = true;
            this.BtnInserrtar.Click += new System.EventHandler(this.BtnInserrtar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(513, 292);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(275, 23);
            this.btneliminar.TabIndex = 8;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(512, 331);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(276, 23);
            this.btnedit.TabIndex = 9;
            this.btnedit.Text = "Editar";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // Planes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.BtnInserrtar);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.txtespecialidad);
            this.Controls.Add(this.Descripcion);
            this.Controls.Add(this.LBLespecialidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Planes";
            this.Text = "Planes";
            this.Load += new System.EventHandler(this.Planes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBLespecialidad;
        private System.Windows.Forms.Label Descripcion;
        private System.Windows.Forms.TextBox txtespecialidad;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Button BtnInserrtar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnedit;
    }
}