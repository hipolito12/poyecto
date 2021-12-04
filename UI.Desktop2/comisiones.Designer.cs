
namespace UI.Desktop2
{
    partial class comisiones
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
            this.comisionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tp2DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tp2DataSet = new UI.Desktop2.tp2DataSet();
            this.comisionesTableAdapter = new UI.Desktop2.tp2DataSetTableAdapters.comisionesTableAdapter();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnrefrescar = new System.Windows.Forms.Button();
            this.idcomision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idplan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comisionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcomision,
            this.descripcion,
            this.anio,
            this.idplan});
            this.dataGridView1.DataSource = this.comisionesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 306);
            this.dataGridView1.TabIndex = 0;
            // 
            // comisionesBindingSource
            // 
            this.comisionesBindingSource.DataMember = "comisiones";
            this.comisionesBindingSource.DataSource = this.tp2DataSetBindingSource;
            // 
            // tp2DataSetBindingSource
            // 
            this.tp2DataSetBindingSource.DataSource = this.tp2DataSet;
            this.tp2DataSetBindingSource.Position = 0;
            // 
            // tp2DataSet
            // 
            this.tp2DataSet.DataSetName = "tp2DataSet";
            this.tp2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comisionesTableAdapter
            // 
            this.comisionesTableAdapter.ClearBeforeFill = true;
            // 
            // btnaceptar
            // 
            this.btnaceptar.Location = new System.Drawing.Point(516, 52);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(204, 23);
            this.btnaceptar.TabIndex = 1;
            this.btnaceptar.Text = "Agregar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(516, 117);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(204, 23);
            this.btneliminar.TabIndex = 2;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(516, 181);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(204, 23);
            this.btnmodificar.TabIndex = 3;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnrefrescar
            // 
            this.btnrefrescar.Location = new System.Drawing.Point(124, 334);
            this.btnrefrescar.Name = "btnrefrescar";
            this.btnrefrescar.Size = new System.Drawing.Size(204, 23);
            this.btnrefrescar.TabIndex = 4;
            this.btnrefrescar.Text = "Refrescar";
            this.btnrefrescar.UseVisualStyleBackColor = true;
            this.btnrefrescar.Click += new System.EventHandler(this.btnrefrescar_Click);
            // 
            // idcomision
            // 
            this.idcomision.DataPropertyName = "id_comision";
            this.idcomision.HeaderText = "id_comision";
            this.idcomision.Name = "idcomision";
            this.idcomision.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "desc_comision";
            this.descripcion.HeaderText = "desc_comision";
            this.descripcion.Name = "descripcion";
            // 
            // anio
            // 
            this.anio.DataPropertyName = "anio_especialidad";
            this.anio.HeaderText = "anio_especialidad";
            this.anio.Name = "anio";
            // 
            // idplan
            // 
            this.idplan.DataPropertyName = "id_plan";
            this.idplan.HeaderText = "id_plan";
            this.idplan.Name = "idplan";
            // 
            // comisiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 369);
            this.Controls.Add(this.btnrefrescar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "comisiones";
            this.Text = "comisiones";
            this.Load += new System.EventHandler(this.comisiones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comisionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tp2DataSetBindingSource;
        private tp2DataSet tp2DataSet;
        private System.Windows.Forms.BindingSource comisionesBindingSource;
        private tp2DataSetTableAdapters.comisionesTableAdapter comisionesTableAdapter;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnrefrescar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcomision;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn anio;
        private System.Windows.Forms.DataGridViewTextBoxColumn idplan;
    }
}