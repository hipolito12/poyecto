
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
            this.idusuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.habilitado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cambia = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idpersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tp2DataSet = new UI.Desktop2.tp2DataSet();
            this.usuariosTableAdapter = new UI.Desktop2.tp2DataSetTableAdapters.usuariosTableAdapter();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnbaja = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnRefressh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
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
            this.cambia,
            this.idpersona});
            this.dataGridView1.DataSource = this.usuariosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, -2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(919, 239);
            this.dataGridView1.TabIndex = 0;
            // 
            // idusuario
            // 
            this.idusuario.DataPropertyName = "id_usuario";
            this.idusuario.HeaderText = "id_usuario";
            this.idusuario.Name = "idusuario";
            this.idusuario.ReadOnly = true;
            // 
            // nombreU
            // 
            this.nombreU.DataPropertyName = "nombre_usuario";
            this.nombreU.HeaderText = "nombre_usuario";
            this.nombreU.Name = "nombreU";
            // 
            // clave
            // 
            this.clave.DataPropertyName = "clave";
            this.clave.HeaderText = "clave";
            this.clave.Name = "clave";
            // 
            // habilitado
            // 
            this.habilitado.DataPropertyName = "habilitado";
            this.habilitado.HeaderText = "habilitado";
            this.habilitado.Name = "habilitado";
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "nombre";
            this.nombre.Name = "nombre";
            // 
            // apellido
            // 
            this.apellido.DataPropertyName = "apellido";
            this.apellido.HeaderText = "apellido";
            this.apellido.Name = "apellido";
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "email";
            this.email.Name = "email";
            // 
            // cambia
            // 
            this.cambia.DataPropertyName = "cambia_clave";
            this.cambia.HeaderText = "cambia_clave";
            this.cambia.Name = "cambia";
            // 
            // idpersona
            // 
            this.idpersona.DataPropertyName = "id_persona";
            this.idpersona.HeaderText = "id_persona";
            this.idpersona.Name = "idpersona";
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
            this.btnmodificar.Location = new System.Drawing.Point(683, 311);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(248, 23);
            this.btnmodificar.TabIndex = 1;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnbaja
            // 
            this.btnbaja.Location = new System.Drawing.Point(683, 359);
            this.btnbaja.Name = "btnbaja";
            this.btnbaja.Size = new System.Drawing.Size(248, 23);
            this.btnbaja.TabIndex = 2;
            this.btnbaja.Text = "Elimianr";
            this.btnbaja.UseVisualStyleBackColor = true;
            this.btnbaja.Click += new System.EventHandler(this.btnbaja_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(683, 254);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(248, 23);
            this.btnAlta.TabIndex = 3;
            this.btnAlta.Text = "Agregar";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnRefressh
            // 
            this.btnRefressh.Location = new System.Drawing.Point(12, 243);
            this.btnRefressh.Name = "btnRefressh";
            this.btnRefressh.Size = new System.Drawing.Size(102, 23);
            this.btnRefressh.TabIndex = 4;
            this.btnRefressh.Text = "Actualizar";
            this.btnRefressh.UseVisualStyleBackColor = true;
            this.btnRefressh.Click += new System.EventHandler(this.btnRefressh_Click);
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 450);
            this.Controls.Add(this.btnRefressh);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.btnbaja);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.dataGridView1);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idusuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreU;
        private System.Windows.Forms.DataGridViewTextBoxColumn clave;
        private System.Windows.Forms.DataGridViewCheckBoxColumn habilitado;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cambia;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpersona;
        public System.Windows.Forms.Button btnmodificar;
        public System.Windows.Forms.Button btnbaja;
        public System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnRefressh;
    }
}