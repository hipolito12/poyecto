
namespace UI.Desktop2.Login
{
    partial class Alumnos
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
            this.texto = new System.Windows.Forms.RichTextBox();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnCursos = new System.Windows.Forms.Button();
            this.btnmodulos = new System.Windows.Forms.Button();
            this.btnmaterias = new System.Windows.Forms.Button();
            this.btninscalummnos = new System.Windows.Forms.Button();
            this.btnespecialidades = new System.Windows.Forms.Button();
            this.btnPlanes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // texto
            // 
            this.texto.AcceptsTab = true;
            this.texto.BackColor = System.Drawing.SystemColors.Control;
            this.texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto.ForeColor = System.Drawing.SystemColors.Highlight;
            this.texto.Location = new System.Drawing.Point(58, 37);
            this.texto.Name = "texto";
            this.texto.Size = new System.Drawing.Size(453, 77);
            this.texto.TabIndex = 0;
            this.texto.Text = "";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(97, 26);
            this.contextMenuStrip2.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip2_Opening);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.Highlight;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 11);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(207, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // btnCursos
            // 
            this.btnCursos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCursos.Location = new System.Drawing.Point(328, 386);
            this.btnCursos.Name = "btnCursos";
            this.btnCursos.Size = new System.Drawing.Size(207, 23);
            this.btnCursos.TabIndex = 3;
            this.btnCursos.Text = "Cursos";
            this.btnCursos.UseVisualStyleBackColor = false;
            this.btnCursos.Click += new System.EventHandler(this.btnCursos_Click);
            // 
            // btnmodulos
            // 
            this.btnmodulos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnmodulos.Location = new System.Drawing.Point(26, 386);
            this.btnmodulos.Name = "btnmodulos";
            this.btnmodulos.Size = new System.Drawing.Size(207, 23);
            this.btnmodulos.TabIndex = 4;
            this.btnmodulos.Text = "Modulos";
            this.btnmodulos.UseVisualStyleBackColor = false;
            this.btnmodulos.Click += new System.EventHandler(this.btnmodulos_Click);
            // 
            // btnmaterias
            // 
            this.btnmaterias.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnmaterias.Location = new System.Drawing.Point(26, 333);
            this.btnmaterias.Name = "btnmaterias";
            this.btnmaterias.Size = new System.Drawing.Size(207, 23);
            this.btnmaterias.TabIndex = 5;
            this.btnmaterias.Text = "Materias";
            this.btnmaterias.UseVisualStyleBackColor = false;
            this.btnmaterias.Click += new System.EventHandler(this.btnmaterias_Click);
            // 
            // btninscalummnos
            // 
            this.btninscalummnos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btninscalummnos.Location = new System.Drawing.Point(26, 272);
            this.btninscalummnos.Name = "btninscalummnos";
            this.btninscalummnos.Size = new System.Drawing.Size(207, 23);
            this.btninscalummnos.TabIndex = 6;
            this.btninscalummnos.Text = "Inscripciones Alumnos";
            this.btninscalummnos.UseVisualStyleBackColor = false;
            this.btninscalummnos.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnespecialidades
            // 
            this.btnespecialidades.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnespecialidades.Location = new System.Drawing.Point(328, 333);
            this.btnespecialidades.Name = "btnespecialidades";
            this.btnespecialidades.Size = new System.Drawing.Size(214, 23);
            this.btnespecialidades.TabIndex = 7;
            this.btnespecialidades.Text = "Especialidades";
            this.btnespecialidades.UseVisualStyleBackColor = false;
            this.btnespecialidades.Click += new System.EventHandler(this.btnespecialidades_Click);
            // 
            // btnPlanes
            // 
            this.btnPlanes.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnPlanes.Location = new System.Drawing.Point(328, 272);
            this.btnPlanes.Name = "btnPlanes";
            this.btnPlanes.Size = new System.Drawing.Size(214, 23);
            this.btnPlanes.TabIndex = 8;
            this.btnPlanes.Text = "Planes";
            this.btnPlanes.UseVisualStyleBackColor = false;
            this.btnPlanes.Click += new System.EventHandler(this.btnPlanes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Navegue por las opciones";
            // 
            // Alumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 439);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPlanes);
            this.Controls.Add(this.btnespecialidades);
            this.Controls.Add(this.btninscalummnos);
            this.Controls.Add(this.btnmaterias);
            this.Controls.Add(this.btnmodulos);
            this.Controls.Add(this.btnCursos);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.texto);
            this.Name = "Alumnos";
            this.Text = "Alumnos";
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RichTextBox texto;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnCursos;
        private System.Windows.Forms.Button btnmodulos;
        private System.Windows.Forms.Button btnmaterias;
        private System.Windows.Forms.Button btninscalummnos;
        private System.Windows.Forms.Button btnespecialidades;
        private System.Windows.Forms.Button btnPlanes;
        private System.Windows.Forms.Label label1;
    }
}