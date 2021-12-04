
namespace UI.Desktop2
{
    partial class Inscripciones_alumno
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
            this.tp2DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alumnosinscripcionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alumnos_inscripcionesTableAdapter = new UI.Desktop2.tp2DataSetTableAdapters.alumnos_inscripcionesTableAdapter();
            this.inscripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnrefrescar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosinscripcionesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inscripcion,
            this.alumno,
            this.curso,
            this.condicion,
            this.nota});
            this.dataGridView1.DataSource = this.alumnosinscripcionesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 359);
            this.dataGridView1.TabIndex = 0;
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
            // 
            // alumnosinscripcionesBindingSource
            // 
            this.alumnosinscripcionesBindingSource.DataMember = "alumnos_inscripciones";
            this.alumnosinscripcionesBindingSource.DataSource = this.tp2DataSetBindingSource;
            // 
            // alumnos_inscripcionesTableAdapter
            // 
            this.alumnos_inscripcionesTableAdapter.ClearBeforeFill = true;
            // 
            // inscripcion
            // 
            this.inscripcion.DataPropertyName = "id_inscripcion";
            this.inscripcion.HeaderText = "id_inscripcion";
            this.inscripcion.Name = "inscripcion";
            this.inscripcion.ReadOnly = true;
            // 
            // alumno
            // 
            this.alumno.DataPropertyName = "id_alumno";
            this.alumno.HeaderText = "id_alumno";
            this.alumno.Name = "alumno";
            // 
            // curso
            // 
            this.curso.DataPropertyName = "id_curso";
            this.curso.HeaderText = "id_curso";
            this.curso.Name = "curso";
            // 
            // condicion
            // 
            this.condicion.DataPropertyName = "condicion";
            this.condicion.HeaderText = "condicion";
            this.condicion.Name = "condicion";
            // 
            // nota
            // 
            this.nota.DataPropertyName = "nota";
            this.nota.HeaderText = "nota";
            this.nota.Name = "nota";
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(562, 93);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(210, 23);
            this.btnagregar.TabIndex = 1;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(562, 166);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(210, 23);
            this.btnmodificar.TabIndex = 2;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(562, 242);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(210, 23);
            this.btneliminar.TabIndex = 3;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnrefrescar
            // 
            this.btnrefrescar.Location = new System.Drawing.Point(91, 378);
            this.btnrefrescar.Name = "btnrefrescar";
            this.btnrefrescar.Size = new System.Drawing.Size(271, 23);
            this.btnrefrescar.TabIndex = 4;
            this.btnrefrescar.Text = "Refrescar";
            this.btnrefrescar.UseVisualStyleBackColor = true;
            this.btnrefrescar.Click += new System.EventHandler(this.btnrefrescar_Click);
            // 
            // Inscripciones_alumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnrefrescar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Inscripciones_alumno";
            this.Text = "Inscripciones_alumno";
            this.Load += new System.EventHandler(this.Inscripciones_alumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosinscripcionesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tp2DataSetBindingSource;
        private tp2DataSet tp2DataSet;
        private System.Windows.Forms.BindingSource alumnosinscripcionesBindingSource;
        private tp2DataSetTableAdapters.alumnos_inscripcionesTableAdapter alumnos_inscripcionesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn inscripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn alumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn condicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnrefrescar;
    }
}