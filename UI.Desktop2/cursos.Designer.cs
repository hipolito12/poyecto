
namespace UI.Desktop2
{
    partial class cursos
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
            this.idcursos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idmateriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcomisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aniocalendario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cursosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tp2DataSet = new UI.Desktop2.tp2DataSet();
            this.cursosTableAdapter = new UI.Desktop2.tp2DataSetTableAdapters.cursosTableAdapter();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btbElimina = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcursos,
            this.idmateriaDataGridViewTextBoxColumn,
            this.idcomisionDataGridViewTextBoxColumn,
            this.aniocalendario,
            this.cupo});
            this.dataGridView1.DataSource = this.cursosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 291);
            this.dataGridView1.TabIndex = 0;
            // 
            // idcursos
            // 
            this.idcursos.DataPropertyName = "id_curso";
            this.idcursos.HeaderText = "id_curso";
            this.idcursos.Name = "idcursos";
            this.idcursos.ReadOnly = true;
            // 
            // idmateriaDataGridViewTextBoxColumn
            // 
            this.idmateriaDataGridViewTextBoxColumn.DataPropertyName = "id_materia";
            this.idmateriaDataGridViewTextBoxColumn.HeaderText = "id_materia";
            this.idmateriaDataGridViewTextBoxColumn.Name = "idmateriaDataGridViewTextBoxColumn";
            // 
            // idcomisionDataGridViewTextBoxColumn
            // 
            this.idcomisionDataGridViewTextBoxColumn.DataPropertyName = "id_comision";
            this.idcomisionDataGridViewTextBoxColumn.HeaderText = "id_comision";
            this.idcomisionDataGridViewTextBoxColumn.Name = "idcomisionDataGridViewTextBoxColumn";
            // 
            // aniocalendario
            // 
            this.aniocalendario.DataPropertyName = "anio_calendario";
            this.aniocalendario.HeaderText = "anio_calendario";
            this.aniocalendario.Name = "aniocalendario";
            // 
            // cupo
            // 
            this.cupo.DataPropertyName = "cupo";
            this.cupo.HeaderText = "cupo";
            this.cupo.Name = "cupo";
            // 
            // cursosBindingSource
            // 
            this.cursosBindingSource.DataMember = "cursos";
            this.cursosBindingSource.DataSource = this.tp2DataSet;
            // 
            // tp2DataSet
            // 
            this.tp2DataSet.DataSetName = "tp2DataSet";
            this.tp2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cursosTableAdapter
            // 
            this.cursosTableAdapter.ClearBeforeFill = true;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(595, 323);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(172, 23);
            this.btnagregar.TabIndex = 1;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btbElimina
            // 
            this.btbElimina.Location = new System.Drawing.Point(595, 415);
            this.btbElimina.Name = "btbElimina";
            this.btbElimina.Size = new System.Drawing.Size(172, 23);
            this.btbElimina.TabIndex = 2;
            this.btbElimina.Text = "Eliminar";
            this.btbElimina.UseVisualStyleBackColor = true;
            this.btbElimina.Click += new System.EventHandler(this.btbElimina_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(595, 370);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(172, 23);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(175, 311);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(169, 23);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 450);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btbElimina);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "cursos";
            this.Text = "cursos";
            this.Load += new System.EventHandler(this.cursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private tp2DataSet tp2DataSet;
        private System.Windows.Forms.BindingSource cursosBindingSource;
        private tp2DataSetTableAdapters.cursosTableAdapter cursosTableAdapter;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btbElimina;
        private System.Windows.Forms.Button btnModificar;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcursos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmateriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcomisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aniocalendario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cupo;
        private System.Windows.Forms.Button btnRefresh;
    }
}