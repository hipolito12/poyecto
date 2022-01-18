
namespace UI.Desktop2
{
    partial class Usuarios
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
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tp2DataSet = new UI.Desktop2.tp2DataSet();
            this.usuariosTableAdapter = new UI.Desktop2.tp2DataSetTableAdapters.usuariosTableAdapter();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnbaja = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnRefressh = new System.Windows.Forms.Button();
            this.idusuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.habilitado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cambiaclave = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idpersonas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idusuario,
            this.nombreU,
            this.clave,
            this.habilitado,
            this.nombre,
            this.apellido,
            this.email,
            this.cambiaclave,
            this.idpersonas});
            this.dataGridView1.DataSource = this.usuariosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-3, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1378, 368);
            this.dataGridView1.TabIndex = 0;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "usuarios";
            this.usuariosBindingSource.DataSource = this.tp2DataSet;
            // 
            // tp2DataSet
            // 
            this.tp2DataSet.DataSetName = "tp2DataSet";
            this.tp2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(405, 562);
            this.btnmodificar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(372, 35);
            this.btnmodificar.TabIndex = 1;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnbaja
            // 
            this.btnbaja.Location = new System.Drawing.Point(802, 562);
            this.btnbaja.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnbaja.Name = "btnbaja";
            this.btnbaja.Size = new System.Drawing.Size(372, 35);
            this.btnbaja.TabIndex = 2;
            this.btnbaja.Text = "Elimianr";
            this.btnbaja.UseVisualStyleBackColor = true;
            this.btnbaja.Click += new System.EventHandler(this.btnbaja_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(13, 562);
            this.btnAlta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(372, 35);
            this.btnAlta.TabIndex = 3;
            this.btnAlta.Text = "Agregar";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnRefressh
            // 
            this.btnRefressh.Location = new System.Drawing.Point(325, 391);
            this.btnRefressh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefressh.Name = "btnRefressh";
            this.btnRefressh.Size = new System.Drawing.Size(502, 35);
            this.btnRefressh.TabIndex = 4;
            this.btnRefressh.Text = "Actualizar";
            this.btnRefressh.UseVisualStyleBackColor = true;
            this.btnRefressh.Click += new System.EventHandler(this.btnRefressh_Click);
            // 
            // idusuario
            // 
            this.idusuario.DataPropertyName = "id_usuario";
            this.idusuario.HeaderText = "id_usuario";
            this.idusuario.MinimumWidth = 8;
            this.idusuario.Name = "idusuario";
            this.idusuario.ReadOnly = true;
            this.idusuario.Width = 150;
            // 
            // nombreU
            // 
            this.nombreU.DataPropertyName = "nombre_usuario";
            this.nombreU.HeaderText = "nombre_usuario";
            this.nombreU.MinimumWidth = 8;
            this.nombreU.Name = "nombreU";
            this.nombreU.ReadOnly = true;
            this.nombreU.Width = 150;
            // 
            // clave
            // 
            this.clave.DataPropertyName = "clave";
            this.clave.HeaderText = "clave";
            this.clave.MinimumWidth = 8;
            this.clave.Name = "clave";
            this.clave.ReadOnly = true;
            this.clave.Width = 150;
            // 
            // habilitado
            // 
            this.habilitado.DataPropertyName = "habilitado";
            this.habilitado.HeaderText = "habilitado";
            this.habilitado.MinimumWidth = 8;
            this.habilitado.Name = "habilitado";
            this.habilitado.ReadOnly = true;
            this.habilitado.Width = 150;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "nombre";
            this.nombre.MinimumWidth = 8;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 150;
            // 
            // apellido
            // 
            this.apellido.DataPropertyName = "apellido";
            this.apellido.HeaderText = "apellido";
            this.apellido.MinimumWidth = 8;
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            this.apellido.Width = 150;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "email";
            this.email.MinimumWidth = 8;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 150;
            // 
            // cambiaclave
            // 
            this.cambiaclave.DataPropertyName = "cambia_clave";
            this.cambiaclave.HeaderText = "cambia_clave";
            this.cambiaclave.MinimumWidth = 8;
            this.cambiaclave.Name = "cambiaclave";
            this.cambiaclave.ReadOnly = true;
            this.cambiaclave.Width = 150;
            // 
            // idpersonas
            // 
            this.idpersonas.DataPropertyName = "id_persona";
            this.idpersonas.HeaderText = "id_persona";
            this.idpersonas.MinimumWidth = 8;
            this.idpersonas.Name = "idpersonas";
            this.idpersonas.ReadOnly = true;
            this.idpersonas.Width = 150;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 692);
            this.Controls.Add(this.btnRefressh);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.btnbaja);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private tp2DataSet tp2DataSet;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private tp2DataSetTableAdapters.usuariosTableAdapter usuariosTableAdapter;
        public System.Windows.Forms.Button btnmodificar;
        public System.Windows.Forms.Button btnbaja;
        public System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnRefressh;
        private System.Windows.Forms.DataGridViewTextBoxColumn idusuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreU;
        private System.Windows.Forms.DataGridViewTextBoxColumn clave;
        private System.Windows.Forms.DataGridViewCheckBoxColumn habilitado;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cambiaclave;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpersonas;
    }
}