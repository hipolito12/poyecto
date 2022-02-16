
namespace UI.Desktop2
{
    partial class modulos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnBAJA = new System.Windows.Forms.Button();
            this.btnEDIT = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.modulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tp2DataSet = new UI.Desktop2.tp2DataSet();
            this.tp2DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modulosTableAdapter = new UI.Desktop2.tp2DataSetTableAdapters.modulosTableAdapter();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modulosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(612, 85);
            this.btnAlta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(321, 35);
            this.btnAlta.TabIndex = 2;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnBAJA
            // 
            this.btnBAJA.Location = new System.Drawing.Point(612, 164);
            this.btnBAJA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBAJA.Name = "btnBAJA";
            this.btnBAJA.Size = new System.Drawing.Size(321, 35);
            this.btnBAJA.TabIndex = 3;
            this.btnBAJA.Text = "Baja";
            this.btnBAJA.UseVisualStyleBackColor = true;
            this.btnBAJA.Click += new System.EventHandler(this.btnBAJA_Click);
            // 
            // btnEDIT
            // 
            this.btnEDIT.Location = new System.Drawing.Point(612, 237);
            this.btnEDIT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEDIT.Name = "btnEDIT";
            this.btnEDIT.Size = new System.Drawing.Size(321, 35);
            this.btnEDIT.TabIndex = 4;
            this.btnEDIT.Text = "Editar";
            this.btnEDIT.UseVisualStyleBackColor = true;
            this.btnEDIT.Click += new System.EventHandler(this.btnEDIT_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 3);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(524, 405);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // modulosBindingSource
            // 
            this.modulosBindingSource.DataMember = "modulos";
            this.modulosBindingSource.DataSource = this.tp2DataSet;
            this.modulosBindingSource.CurrentChanged += new System.EventHandler(this.modulosBindingSource_CurrentChanged);
            // 
            // tp2DataSet
            // 
            this.tp2DataSet.DataSetName = "tp2DataSet";
            this.tp2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tp2DataSetBindingSource
            // 
            this.tp2DataSetBindingSource.DataSource = this.tp2DataSet;
            this.tp2DataSetBindingSource.Position = 0;
            this.tp2DataSetBindingSource.CurrentChanged += new System.EventHandler(this.tp2DataSetBindingSource_CurrentChanged);
            // 
            // modulosTableAdapter
            // 
            this.modulosTableAdapter.ClearBeforeFill = true;
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(38, 433);
            this.btnrefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(410, 35);
            this.btnrefresh.TabIndex = 7;
            this.btnrefresh.Text = "Refrescar";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.modulosBindingSource, "desc_modulo", true));
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.modulosBindingSource, "desc_modulo", true));
            this.textBox1.Location = new System.Drawing.Point(1346, 662);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 26);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.AcceptsReturn = true;
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.modulosBindingSource, "id_modulo", true));
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.modulosBindingSource, "id_modulo", true));
            this.textBox2.Location = new System.Drawing.Point(1346, 549);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(148, 26);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.modulosBindingSource, "ejecuta", true));
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.modulosBindingSource, "ejecuta", true));
            this.textBox3.Location = new System.Drawing.Point(1346, 603);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(148, 26);
            this.textBox3.TabIndex = 10;
            // 
            // modulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 510);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEDIT);
            this.Controls.Add(this.btnBAJA);
            this.Controls.Add(this.btnAlta);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "modulos";
            this.Text = "Modulos";
            this.Load += new System.EventHandler(this.modulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modulosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnBAJA;
        private System.Windows.Forms.Button btnEDIT;
        private System.Windows.Forms.BindingSource tp2DataSetBindingSource;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnrefresh;
        public System.Windows.Forms.BindingSource modulosBindingSource;
        public tp2DataSetTableAdapters.modulosTableAdapter modulosTableAdapter;
        public tp2DataSet tp2DataSet;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

