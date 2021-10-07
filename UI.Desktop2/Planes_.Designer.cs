
namespace UI.Desktop2
{
    partial class Planes_
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
            this.tp2DataSet = new UI.Desktop2.tp2DataSet();
            this.planesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.planesTableAdapter = new UI.Desktop2.tp2DataSetTableAdapters.planesTableAdapter();
            this.idplanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descplanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idespecialidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.BtnAlta = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idplanDataGridViewTextBoxColumn,
            this.descplanDataGridViewTextBoxColumn,
            this.idespecialidadDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.planesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(338, 197);
            this.dataGridView1.TabIndex = 0;
            // 
            // tp2DataSet
            // 
            this.tp2DataSet.DataSetName = "tp2DataSet";
            this.tp2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // planesBindingSource
            // 
            this.planesBindingSource.DataMember = "planes";
            this.planesBindingSource.DataSource = this.tp2DataSet;
            // 
            // planesTableAdapter
            // 
            this.planesTableAdapter.ClearBeforeFill = true;
            // 
            // idplanDataGridViewTextBoxColumn
            // 
            this.idplanDataGridViewTextBoxColumn.DataPropertyName = "id_plan";
            this.idplanDataGridViewTextBoxColumn.HeaderText = "id_plan";
            this.idplanDataGridViewTextBoxColumn.Name = "idplanDataGridViewTextBoxColumn";
            this.idplanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descplanDataGridViewTextBoxColumn
            // 
            this.descplanDataGridViewTextBoxColumn.DataPropertyName = "desc_plan";
            this.descplanDataGridViewTextBoxColumn.HeaderText = "desc_plan";
            this.descplanDataGridViewTextBoxColumn.Name = "descplanDataGridViewTextBoxColumn";
            // 
            // idespecialidadDataGridViewTextBoxColumn
            // 
            this.idespecialidadDataGridViewTextBoxColumn.DataPropertyName = "id_especialidad";
            this.idespecialidadDataGridViewTextBoxColumn.HeaderText = "id_especialidad";
            this.idespecialidadDataGridViewTextBoxColumn.Name = "idespecialidadDataGridViewTextBoxColumn";
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(121, 218);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(115, 23);
            this.btnrefresh.TabIndex = 1;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = true;
            // 
            // BtnAlta
            // 
            this.BtnAlta.Location = new System.Drawing.Point(390, 33);
            this.BtnAlta.Name = "BtnAlta";
            this.BtnAlta.Size = new System.Drawing.Size(179, 23);
            this.BtnAlta.TabIndex = 2;
            this.BtnAlta.Text = "Alta";
            this.BtnAlta.UseVisualStyleBackColor = true;
            this.BtnAlta.Click += new System.EventHandler(this.BtnAlta_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(390, 72);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(179, 23);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificacion";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(390, 115);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(179, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // Planes_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 266);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.BtnAlta);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Planes_";
            this.Text = "Planes_";
            this.Load += new System.EventHandler(this.Planes__Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private tp2DataSet tp2DataSet;
        private System.Windows.Forms.BindingSource planesBindingSource;
        private tp2DataSetTableAdapters.planesTableAdapter planesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idplanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descplanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idespecialidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button BtnAlta;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
    }
}