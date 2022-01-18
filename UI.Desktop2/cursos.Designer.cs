
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
            this.dataGridView1.Location = new System.Drawing.Point(-69, 5);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1047, 448);
            this.dataGridView1.TabIndex = 0;
            // 
            // idcursos
            // 
            this.idcursos.DataPropertyName = "id_curso";
            this.idcursos.HeaderText = "id_curso";
            this.idcursos.MinimumWidth = 8;
            this.idcursos.Name = "idcursos";
            this.idcursos.ReadOnly = true;
            this.idcursos.Width = 150;
            // 
            // idmateriaDataGridViewTextBoxColumn
            // 
            this.idmateriaDataGridViewTextBoxColumn.DataPropertyName = "id_materia";
            this.idmateriaDataGridViewTextBoxColumn.HeaderText = "id_materia";
            this.idmateriaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idmateriaDataGridViewTextBoxColumn.Name = "idmateriaDataGridViewTextBoxColumn";
            this.idmateriaDataGridViewTextBoxColumn.Width = 150;
            // 
            // idcomisionDataGridViewTextBoxColumn
            // 
            this.idcomisionDataGridViewTextBoxColumn.DataPropertyName = "id_comision";
            this.idcomisionDataGridViewTextBoxColumn.HeaderText = "id_comision";
            this.idcomisionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idcomisionDataGridViewTextBoxColumn.Name = "idcomisionDataGridViewTextBoxColumn";
            this.idcomisionDataGridViewTextBoxColumn.Width = 150;
            // 
            // aniocalendario
            // 
            this.aniocalendario.DataPropertyName = "anio_calendario";
            this.aniocalendario.HeaderText = "anio_calendario";
            this.aniocalendario.MinimumWidth = 8;
            this.aniocalendario.Name = "aniocalendario";
            this.aniocalendario.Width = 150;
            // 
            // cupo
            // 
            this.cupo.DataPropertyName = "cupo";
            this.cupo.HeaderText = "cupo";
            this.cupo.MinimumWidth = 8;
            this.cupo.Name = "cupo";
            this.cupo.Width = 150;
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
            this.btnagregar.Location = new System.Drawing.Point(986, 65);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(258, 35);
            this.btnagregar.TabIndex = 1;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btbElimina
            // 
            this.btbElimina.Location = new System.Drawing.Point(986, 206);
            this.btbElimina.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btbElimina.Name = "btbElimina";
            this.btbElimina.Size = new System.Drawing.Size(258, 35);
            this.btbElimina.TabIndex = 2;
            this.btbElimina.Text = "Eliminar";
            this.btbElimina.UseVisualStyleBackColor = true;
            this.btbElimina.Click += new System.EventHandler(this.btbElimina_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(986, 137);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(258, 35);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(262, 478);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(254, 35);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 692);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btbElimina);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcursos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmateriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcomisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aniocalendario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cupo;
        public System.Windows.Forms.Button btnagregar;
        public System.Windows.Forms.Button btbElimina;
        public System.Windows.Forms.Button btnModificar;
        public System.Windows.Forms.Button btnRefresh;
    }
}