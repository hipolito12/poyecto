
namespace UI.Desktop2
{
    partial class Materia
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
            this.tp2DataSet = new UI.Desktop2.tp2DataSet();
            this.materiasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materiasTableAdapter = new UI.Desktop2.tp2DataSetTableAdapters.materiasTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idMateriaD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionMateriaD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hsSemanlaesD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hsTotales_D = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_plan_D = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tp2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tp2DataSet
            // 
            this.tp2DataSet.DataSetName = "tp2DataSet";
            this.tp2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materiasBindingSource
            // 
            this.materiasBindingSource.DataMember = "materias";
            this.materiasBindingSource.DataSource = this.tp2DataSet;
            // 
            // materiasTableAdapter
            // 
            this.materiasTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMateriaD,
            this.descripcionMateriaD,
            this.hsSemanlaesD,
            this.hsTotales_D,
            this.ID_plan_D});
            this.dataGridView1.DataSource = this.materiasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(539, 239);
            this.dataGridView1.TabIndex = 0;
            // 
            // idMateriaD
            // 
            this.idMateriaD.DataPropertyName = "id_materia";
            this.idMateriaD.HeaderText = "id_Materia";
            this.idMateriaD.Name = "idMateriaD";
            this.idMateriaD.ReadOnly = true;
            // 
            // descripcionMateriaD
            // 
            this.descripcionMateriaD.DataPropertyName = "desc_materia";
            this.descripcionMateriaD.HeaderText = "desc_materia";
            this.descripcionMateriaD.Name = "descripcionMateriaD";
            // 
            // hsSemanlaesD
            // 
            this.hsSemanlaesD.DataPropertyName = "hs_semanales";
            this.hsSemanlaesD.HeaderText = "hs_semanales";
            this.hsSemanlaesD.Name = "hsSemanlaesD";
            // 
            // hsTotales_D
            // 
            this.hsTotales_D.DataPropertyName = "hs_totales";
            this.hsTotales_D.HeaderText = "hs_totales";
            this.hsTotales_D.Name = "hsTotales_D";
            // 
            // ID_plan_D
            // 
            this.ID_plan_D.DataPropertyName = "id_plan";
            this.ID_plan_D.HeaderText = "id_plan";
            this.ID_plan_D.Name = "ID_plan_D";
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(567, 337);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(186, 23);
            this.btnagregar.TabIndex = 1;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click_1);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(567, 377);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(186, 23);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Ediatr";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(567, 415);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(186, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(151, 257);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(195, 23);
            this.refresh.TabIndex = 4;
            this.refresh.Text = "Refrcar";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // Materia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Materia";
            this.Text = "Materia";
            this.Load += new System.EventHandler(this.Materia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tp2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private tp2DataSet tp2DataSet;
        private System.Windows.Forms.BindingSource materiasBindingSource;
        private tp2DataSetTableAdapters.materiasTableAdapter materiasTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMateriaD;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionMateriaD;
        private System.Windows.Forms.DataGridViewTextBoxColumn hsSemanlaesD;
        private System.Windows.Forms.DataGridViewTextBoxColumn hsTotales_D;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_plan_D;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button refresh;
    }
}