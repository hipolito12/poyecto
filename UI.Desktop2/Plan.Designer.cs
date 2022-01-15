
namespace UI.Desktop2
{
    partial class _Plan_
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idplan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descplan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idespecialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tp2DataSet = new UI.Desktop2.tp2DataSet();
            this.planesTableAdapter = new UI.Desktop2.tp2DataSetTableAdapters.planesTableAdapter();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnmodificacion = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idplan,
            this.descplan,
            this.idespecialidad});
            this.dataGridView1.DataSource = this.planesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(18, 18);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(520, 231);
            this.dataGridView1.TabIndex = 0;
            // 
            // idplan
            // 
            this.idplan.DataPropertyName = "id_plan";
            this.idplan.HeaderText = "id_plan";
            this.idplan.MinimumWidth = 8;
            this.idplan.Name = "idplan";
            this.idplan.ReadOnly = true;
            this.idplan.Width = 150;
            // 
            // descplan
            // 
            this.descplan.DataPropertyName = "desc_plan";
            this.descplan.HeaderText = "desc_plan";
            this.descplan.MinimumWidth = 8;
            this.descplan.Name = "descplan";
            this.descplan.Width = 150;
            // 
            // idespecialidad
            // 
            this.idespecialidad.DataPropertyName = "id_especialidad";
            this.idespecialidad.HeaderText = "id_especialidad";
            this.idespecialidad.MinimumWidth = 8;
            this.idespecialidad.Name = "idespecialidad";
            this.idespecialidad.Width = 150;
            // 
            // planesBindingSource
            // 
            this.planesBindingSource.DataMember = "planes";
            this.planesBindingSource.DataSource = this.tp2DataSet;
            // 
            // tp2DataSet
            // 
            this.tp2DataSet.DataSetName = "tp2DataSet";
            this.tp2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // planesTableAdapter
            // 
            this.planesTableAdapter.ClearBeforeFill = true;
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(201, 272);
            this.btnrefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(130, 35);
            this.btnrefresh.TabIndex = 1;
            this.btnrefresh.Text = "Refrescar";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnmodificacion
            // 
            this.btnmodificacion.Location = new System.Drawing.Point(594, 112);
            this.btnmodificacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnmodificacion.Name = "btnmodificacion";
            this.btnmodificacion.Size = new System.Drawing.Size(230, 35);
            this.btnmodificacion.TabIndex = 2;
            this.btnmodificacion.Text = "Modificacion";
            this.btnmodificacion.UseVisualStyleBackColor = true;
            this.btnmodificacion.Click += new System.EventHandler(this.btnmodificacion_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(594, 31);
            this.btnAlta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(230, 35);
            this.btnAlta.TabIndex = 3;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(594, 191);
            this.Eliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(230, 35);
            this.Eliminar.TabIndex = 4;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // _Plan_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 383);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.btnmodificacion);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "_Plan_";
            this.Text = "_Plan_";
            this.Load += new System.EventHandler(this._Plan__Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn idplan;
        private System.Windows.Forms.DataGridViewTextBoxColumn descplan;
        private System.Windows.Forms.DataGridViewTextBoxColumn idespecialidad;
        public System.Windows.Forms.DataGridView dataGridView1;
        public tp2DataSet tp2DataSet;
        public System.Windows.Forms.BindingSource planesBindingSource;
        public tp2DataSetTableAdapters.planesTableAdapter planesTableAdapter;
        public System.Windows.Forms.Button btnrefresh;
        public System.Windows.Forms.Button btnmodificacion;
        public System.Windows.Forms.Button btnAlta;
        public System.Windows.Forms.Button Eliminar;
    }
}