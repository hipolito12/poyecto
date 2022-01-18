
namespace UI.Desktop2
{
    partial class Personas
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
            this.idpersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechanac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipopersonas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idplan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tp2DataSet = new UI.Desktop2.tp2DataSet();
            this.personasTableAdapter = new UI.Desktop2.tp2DataSetTableAdapters.personasTableAdapter();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnElminar = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpersona,
            this.nombre,
            this.apellido,
            this.direccion,
            this.email,
            this.telefono,
            this.fechanac,
            this.legajo,
            this.tipopersonas,
            this.idplan});
            this.dataGridView1.DataSource = this.personasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(4, 3);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1558, 274);
            this.dataGridView1.TabIndex = 0;
            // 
            // idpersona
            // 
            this.idpersona.DataPropertyName = "id_persona";
            this.idpersona.HeaderText = "id_persona";
            this.idpersona.MinimumWidth = 8;
            this.idpersona.Name = "idpersona";
            this.idpersona.ReadOnly = true;
            this.idpersona.Width = 150;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "nombre";
            this.nombre.MinimumWidth = 8;
            this.nombre.Name = "nombre";
            this.nombre.Width = 150;
            // 
            // apellido
            // 
            this.apellido.DataPropertyName = "apellido";
            this.apellido.HeaderText = "apellido";
            this.apellido.MinimumWidth = 8;
            this.apellido.Name = "apellido";
            this.apellido.Width = 150;
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "direccion";
            this.direccion.HeaderText = "direccion";
            this.direccion.MinimumWidth = 8;
            this.direccion.Name = "direccion";
            this.direccion.Width = 150;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "email";
            this.email.MinimumWidth = 8;
            this.email.Name = "email";
            this.email.Width = 150;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "telefono";
            this.telefono.MinimumWidth = 8;
            this.telefono.Name = "telefono";
            this.telefono.Width = 150;
            // 
            // fechanac
            // 
            this.fechanac.DataPropertyName = "fecha_nac";
            this.fechanac.HeaderText = "fecha_nac";
            this.fechanac.MinimumWidth = 8;
            this.fechanac.Name = "fechanac";
            this.fechanac.Width = 150;
            // 
            // legajo
            // 
            this.legajo.DataPropertyName = "legajo";
            this.legajo.HeaderText = "legajo";
            this.legajo.MinimumWidth = 8;
            this.legajo.Name = "legajo";
            this.legajo.Width = 150;
            // 
            // tipopersonas
            // 
            this.tipopersonas.DataPropertyName = "tipo_persona";
            this.tipopersonas.HeaderText = "tipo_persona";
            this.tipopersonas.MinimumWidth = 8;
            this.tipopersonas.Name = "tipopersonas";
            this.tipopersonas.Width = 150;
            // 
            // idplan
            // 
            this.idplan.DataPropertyName = "id_plan";
            this.idplan.HeaderText = "id_plan";
            this.idplan.MinimumWidth = 8;
            this.idplan.Name = "idplan";
            this.idplan.Width = 150;
            // 
            // personasBindingSource
            // 
            this.personasBindingSource.DataMember = "personas";
            this.personasBindingSource.DataSource = this.tp2DataSet;
            // 
            // tp2DataSet
            // 
            this.tp2DataSet.DataSetName = "tp2DataSet";
            this.tp2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personasTableAdapter
            // 
            this.personasTableAdapter.ClearBeforeFill = true;
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(954, 456);
            this.btnAlta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(462, 35);
            this.btnAlta.TabIndex = 1;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(482, 456);
            this.btnmodificar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(462, 35);
            this.btnmodificar.TabIndex = 2;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnElminar
            // 
            this.btnElminar.Location = new System.Drawing.Point(13, 456);
            this.btnElminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnElminar.Name = "btnElminar";
            this.btnElminar.Size = new System.Drawing.Size(462, 35);
            this.btnElminar.TabIndex = 3;
            this.btnElminar.Text = "Eliminar";
            this.btnElminar.UseVisualStyleBackColor = true;
            this.btnElminar.Click += new System.EventHandler(this.btnElminar_Click);
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(482, 286);
            this.Refresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(462, 35);
            this.Refresh.TabIndex = 4;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Personas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1568, 763);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.btnElminar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Personas";
            this.Text = "Personas";
            this.Load += new System.EventHandler(this.Personas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private tp2DataSet tp2DataSet;
        private System.Windows.Forms.BindingSource personasBindingSource;
        private tp2DataSetTableAdapters.personasTableAdapter personasTableAdapter;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnElminar;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechanac;
        private System.Windows.Forms.DataGridViewTextBoxColumn legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipopersonas;
        private System.Windows.Forms.DataGridViewTextBoxColumn idplan;
    }
}