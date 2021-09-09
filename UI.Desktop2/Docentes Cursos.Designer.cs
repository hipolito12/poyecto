
namespace UI.Desktop2
{
    partial class Docentes_Cursos
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
            this.docentes_cursosTableAdapter1 = new UI.Desktop2.tp2DataSetTableAdapters.docentes_cursosTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_dictado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_docente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docentescursosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tp2DataSet = new UI.Desktop2.tp2DataSet();
            this.btnalta = new System.Windows.Forms.Button();
            this.btnbaja = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docentescursosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // docentes_cursosTableAdapter1
            // 
            this.docentes_cursosTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_dictado,
            this.id_curso,
            this.id_docente,
            this.cargo});
            this.dataGridView1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.docentescursosBindingSource, "id_dictado", true));
            this.dataGridView1.DataSource = this.docentescursosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 302);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id_dictado
            // 
            this.id_dictado.DataPropertyName = "id_dictado";
            this.id_dictado.HeaderText = "id_dictado";
            this.id_dictado.Name = "id_dictado";
            this.id_dictado.ReadOnly = true;
            // 
            // id_curso
            // 
            this.id_curso.DataPropertyName = "id_curso";
            this.id_curso.HeaderText = "id_curso";
            this.id_curso.Name = "id_curso";
            // 
            // id_docente
            // 
            this.id_docente.DataPropertyName = "id_docente";
            this.id_docente.HeaderText = "id_docente";
            this.id_docente.Name = "id_docente";
            // 
            // cargo
            // 
            this.cargo.DataPropertyName = "cargo";
            this.cargo.HeaderText = "cargo";
            this.cargo.Name = "cargo";
            // 
            // docentescursosBindingSource
            // 
            this.docentescursosBindingSource.DataMember = "docentes_cursos";
            this.docentescursosBindingSource.DataSource = this.tp2DataSet;
            // 
            // tp2DataSet
            // 
            this.tp2DataSet.DataSetName = "tp2DataSet";
            this.tp2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnalta
            // 
            this.btnalta.Location = new System.Drawing.Point(502, 324);
            this.btnalta.Name = "btnalta";
            this.btnalta.Size = new System.Drawing.Size(182, 23);
            this.btnalta.TabIndex = 1;
            this.btnalta.Text = "Alta";
            this.btnalta.UseVisualStyleBackColor = true;
            this.btnalta.Click += new System.EventHandler(this.btnalta_Click);
            // 
            // btnbaja
            // 
            this.btnbaja.Location = new System.Drawing.Point(502, 376);
            this.btnbaja.Name = "btnbaja";
            this.btnbaja.Size = new System.Drawing.Size(182, 23);
            this.btnbaja.TabIndex = 2;
            this.btnbaja.Text = "Baja";
            this.btnbaja.UseVisualStyleBackColor = true;
            this.btnbaja.Click += new System.EventHandler(this.btnbaja_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(502, 415);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(182, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Modificacion";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(117, 324);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(182, 23);
            this.btnRefrescar.TabIndex = 4;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // Docentes_Cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 436);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnbaja);
            this.Controls.Add(this.btnalta);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Docentes_Cursos";
            this.Text = "Docentes_Cursos";
            this.Load += new System.EventHandler(this.Docentes_Cursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docentescursosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnalta;
        private System.Windows.Forms.Button btnbaja;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnRefrescar;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_dictado;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_docente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargo;
        public tp2DataSetTableAdapters.docentes_cursosTableAdapter docentes_cursosTableAdapter1;
        public System.Windows.Forms.BindingSource docentescursosBindingSource;
        public tp2DataSet tp2DataSet;
    }
}