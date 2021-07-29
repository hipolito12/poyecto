
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.descripcion = new System.Windows.Forms.Label();
            this.hs_semanales = new System.Windows.Forms.Label();
            this.toatal = new System.Windows.Forms.Label();
            this.plan = new System.Windows.Forms.Label();
            this.descrip = new System.Windows.Forms.TextBox();
            this.totales = new System.Windows.Forms.TextBox();
            this.semanales = new System.Windows.Forms.TextBox();
            this.plant = new System.Windows.Forms.TextBox();
            this.edit = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-17, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(592, 285);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // descripcion
            // 
            this.descripcion.AutoSize = true;
            this.descripcion.Location = new System.Drawing.Point(630, 173);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(71, 15);
            this.descripcion.TabIndex = 2;
            this.descripcion.Text = "descripcion.";
            // 
            // hs_semanales
            // 
            this.hs_semanales.AutoSize = true;
            this.hs_semanales.Location = new System.Drawing.Point(642, 227);
            this.hs_semanales.Name = "hs_semanales";
            this.hs_semanales.Size = new System.Drawing.Size(59, 15);
            this.hs_semanales.TabIndex = 3;
            this.hs_semanales.Text = "hs_totales";
            this.hs_semanales.Click += new System.EventHandler(this.hs_semanales_Click);
            // 
            // toatal
            // 
            this.toatal.AutoSize = true;
            this.toatal.Location = new System.Drawing.Point(642, 274);
            this.toatal.Name = "toatal";
            this.toatal.Size = new System.Drawing.Size(68, 15);
            this.toatal.TabIndex = 4;
            this.toatal.Text = "hs_semanal";
            // 
            // plan
            // 
            this.plan.AutoSize = true;
            this.plan.Location = new System.Drawing.Point(642, 315);
            this.plan.Name = "plan";
            this.plan.Size = new System.Drawing.Size(45, 15);
            this.plan.TabIndex = 5;
            this.plan.Text = "id_plan";
            // 
            // descrip
            // 
            this.descrip.Location = new System.Drawing.Point(738, 173);
            this.descrip.Name = "descrip";
            this.descrip.Size = new System.Drawing.Size(147, 23);
            this.descrip.TabIndex = 7;
            this.descrip.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // totales
            // 
            this.totales.Location = new System.Drawing.Point(738, 224);
            this.totales.Name = "totales";
            this.totales.Size = new System.Drawing.Size(147, 23);
            this.totales.TabIndex = 8;
            // 
            // semanales
            // 
            this.semanales.Location = new System.Drawing.Point(738, 271);
            this.semanales.Name = "semanales";
            this.semanales.Size = new System.Drawing.Size(147, 23);
            this.semanales.TabIndex = 9;
            // 
            // plant
            // 
            this.plant.Location = new System.Drawing.Point(738, 312);
            this.plant.Name = "plant";
            this.plant.Size = new System.Drawing.Size(147, 23);
            this.plant.TabIndex = 10;
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(738, 385);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(147, 23);
            this.edit.TabIndex = 11;
            this.edit.Text = "editar";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.button1_Click);
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(738, 356);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(147, 23);
            this.insert.TabIndex = 12;
            this.insert.Text = "insertar";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(738, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "eliminar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.plant);
            this.Controls.Add(this.semanales);
            this.Controls.Add(this.totales);
            this.Controls.Add(this.descrip);
            this.Controls.Add(this.plan);
            this.Controls.Add(this.toatal);
            this.Controls.Add(this.hs_semanales);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label descripcion;
        private System.Windows.Forms.Label hs_semanales;
        private System.Windows.Forms.Label toatal;
        private System.Windows.Forms.Label plan;
        private System.Windows.Forms.TextBox descrip;
        private System.Windows.Forms.TextBox totales;
        private System.Windows.Forms.TextBox semanales;
        private System.Windows.Forms.TextBox plant;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button button1;
    }
}

