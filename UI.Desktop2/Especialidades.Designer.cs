
namespace UI.Desktop2
{
    partial class Especialidades
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
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnModificacion = new System.Windows.Forms.Button();
            this.btnBAJA = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.tp2DataSet = new UI.Desktop2.tp2DataSet();
            this.especialidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.especialidadesTableAdapter = new UI.Desktop2.tp2DataSetTableAdapters.especialidadesTableAdapter();
            this.idespecialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descespecialidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idespecialidad,
            this.descespecialidadDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.especialidadesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, -2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(379, 195);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(465, 30);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(193, 23);
            this.btnAlta.TabIndex = 1;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnModificacion
            // 
            this.btnModificacion.Location = new System.Drawing.Point(465, 84);
            this.btnModificacion.Name = "btnModificacion";
            this.btnModificacion.Size = new System.Drawing.Size(193, 23);
            this.btnModificacion.TabIndex = 2;
            this.btnModificacion.Text = "Modificacion";
            this.btnModificacion.UseVisualStyleBackColor = true;
            this.btnModificacion.Click += new System.EventHandler(this.btnModificacion_Click);
            // 
            // btnBAJA
            // 
            this.btnBAJA.Location = new System.Drawing.Point(465, 132);
            this.btnBAJA.Name = "btnBAJA";
            this.btnBAJA.Size = new System.Drawing.Size(193, 23);
            this.btnBAJA.TabIndex = 3;
            this.btnBAJA.Text = "Eliminar";
            this.btnBAJA.UseVisualStyleBackColor = true;
            this.btnBAJA.Click += new System.EventHandler(this.btnBAJA_Click);
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(88, 199);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(193, 23);
            this.refresh.TabIndex = 4;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            // 
            // tp2DataSet
            // 
            this.tp2DataSet.DataSetName = "tp2DataSet";
            this.tp2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // especialidadesBindingSource
            // 
            this.especialidadesBindingSource.DataMember = "especialidades";
            this.especialidadesBindingSource.DataSource = this.tp2DataSet;
            // 
            // especialidadesTableAdapter
            // 
            this.especialidadesTableAdapter.ClearBeforeFill = true;
            // 
            // idespecialidad
            // 
            this.idespecialidad.DataPropertyName = "id_especialidad";
            this.idespecialidad.HeaderText = "id_especialidad";
            this.idespecialidad.Name = "idespecialidad";
            this.idespecialidad.ReadOnly = true;
            // 
            // descespecialidadDataGridViewTextBoxColumn
            // 
            this.descespecialidadDataGridViewTextBoxColumn.DataPropertyName = "desc_especialidad";
            this.descespecialidadDataGridViewTextBoxColumn.HeaderText = "desc_especialidad";
            this.descespecialidadDataGridViewTextBoxColumn.Name = "descespecialidadDataGridViewTextBoxColumn";
            // 
            // Especialidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 290);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.btnBAJA);
            this.Controls.Add(this.btnModificacion);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Especialidades";
            this.Text = "Especialidades";
            this.Load += new System.EventHandler(this.Especialidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnModificacion;
        private System.Windows.Forms.Button btnBAJA;
        private System.Windows.Forms.Button refresh;
        private tp2DataSet tp2DataSet;
        private System.Windows.Forms.BindingSource especialidadesBindingSource;
        private tp2DataSetTableAdapters.especialidadesTableAdapter especialidadesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idespecialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn descespecialidadDataGridViewTextBoxColumn;
    }
}