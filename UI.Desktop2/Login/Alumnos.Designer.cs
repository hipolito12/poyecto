
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
            this.texto = new System.Windows.Forms.RichTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnCursos = new System.Windows.Forms.Button();
            this.btnmaterias = new System.Windows.Forms.Button();
            this.btninscalummnos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.asasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscripcionDeAlumnosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.materiasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modulosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.planesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.especialidadesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // texto
            // 
            this.texto.AcceptsTab = true;
            this.texto.BackColor = System.Drawing.SystemColors.Control;
            this.texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto.ForeColor = System.Drawing.SystemColors.Highlight;
            this.texto.Location = new System.Drawing.Point(87, 57);
            this.texto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.texto.Name = "texto";
            this.texto.Size = new System.Drawing.Size(678, 116);
            this.texto.TabIndex = 0;
            this.texto.Text = "";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.Highlight;
            this.dateTimePicker1.Location = new System.Drawing.Point(564, 0);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(308, 26);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // btnCursos
            // 
            this.btnCursos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCursos.Location = new System.Drawing.Point(528, 557);
            this.btnCursos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCursos.Name = "btnCursos";
            this.btnCursos.Size = new System.Drawing.Size(310, 35);
            this.btnCursos.TabIndex = 3;
            this.btnCursos.Text = "Cursos";
            this.btnCursos.UseVisualStyleBackColor = false;
            this.btnCursos.Click += new System.EventHandler(this.btnCursos_Click);
            // 
            // btnmaterias
            // 
            this.btnmaterias.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnmaterias.Location = new System.Drawing.Point(528, 418);
            this.btnmaterias.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnmaterias.Name = "btnmaterias";
            this.btnmaterias.Size = new System.Drawing.Size(310, 35);
            this.btnmaterias.TabIndex = 5;
            this.btnmaterias.Text = "Materias";
            this.btnmaterias.UseVisualStyleBackColor = false;
            this.btnmaterias.Click += new System.EventHandler(this.btnmaterias_Click);
            // 
            // btninscalummnos
            // 
            this.btninscalummnos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btninscalummnos.Location = new System.Drawing.Point(45, 418);
            this.btninscalummnos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btninscalummnos.Name = "btninscalummnos";
            this.btninscalummnos.Size = new System.Drawing.Size(310, 35);
            this.btninscalummnos.TabIndex = 6;
            this.btninscalummnos.Text = "Inscribirme a curso";
            this.btninscalummnos.UseVisualStyleBackColor = false;
            this.btninscalummnos.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 242);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 39);
            this.label1.TabIndex = 9;
            this.label1.Text = "Navegue por las opciones";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(872, 33);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // asasToolStripMenuItem
            // 
            this.asasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inscripcionDeAlumnosToolStripMenuItem1,
            this.materiasToolStripMenuItem1,
            this.modulosToolStripMenuItem1,
            this.planesToolStripMenuItem1,
            this.especialidadesToolStripMenuItem1,
            this.cursosToolStripMenuItem1});
            this.asasToolStripMenuItem.Name = "asasToolStripMenuItem";
            this.asasToolStripMenuItem.Size = new System.Drawing.Size(121, 29);
            this.asasToolStripMenuItem.Text = "Navegacion";
            // 
            // inscripcionDeAlumnosToolStripMenuItem1
            // 
            this.inscripcionDeAlumnosToolStripMenuItem1.Name = "inscripcionDeAlumnosToolStripMenuItem1";
            this.inscripcionDeAlumnosToolStripMenuItem1.Size = new System.Drawing.Size(305, 34);
            this.inscripcionDeAlumnosToolStripMenuItem1.Text = "Inscripcion de Alumnos ";
            this.inscripcionDeAlumnosToolStripMenuItem1.Click += new System.EventHandler(this.inscripcionDeAlumnosToolStripMenuItem1_Click);
            // 
            // materiasToolStripMenuItem1
            // 
            this.materiasToolStripMenuItem1.Name = "materiasToolStripMenuItem1";
            this.materiasToolStripMenuItem1.Size = new System.Drawing.Size(305, 34);
            this.materiasToolStripMenuItem1.Text = "Materias";
            this.materiasToolStripMenuItem1.Click += new System.EventHandler(this.materiasToolStripMenuItem1_Click);
            // 
            // modulosToolStripMenuItem1
            // 
            this.modulosToolStripMenuItem1.Name = "modulosToolStripMenuItem1";
            this.modulosToolStripMenuItem1.Size = new System.Drawing.Size(305, 34);
            this.modulosToolStripMenuItem1.Text = "Modulos";
            this.modulosToolStripMenuItem1.Click += new System.EventHandler(this.modulosToolStripMenuItem1_Click);
            // 
            // planesToolStripMenuItem1
            // 
            this.planesToolStripMenuItem1.Name = "planesToolStripMenuItem1";
            this.planesToolStripMenuItem1.Size = new System.Drawing.Size(305, 34);
            this.planesToolStripMenuItem1.Text = "Planes";
            this.planesToolStripMenuItem1.Click += new System.EventHandler(this.planesToolStripMenuItem1_Click);
            // 
            // especialidadesToolStripMenuItem1
            // 
            this.especialidadesToolStripMenuItem1.Name = "especialidadesToolStripMenuItem1";
            this.especialidadesToolStripMenuItem1.Size = new System.Drawing.Size(305, 34);
            this.especialidadesToolStripMenuItem1.Text = "Especialidades";
            this.especialidadesToolStripMenuItem1.Click += new System.EventHandler(this.especialidadesToolStripMenuItem1_Click);
            // 
            // cursosToolStripMenuItem1
            // 
            this.cursosToolStripMenuItem1.Name = "cursosToolStripMenuItem1";
            this.cursosToolStripMenuItem1.Size = new System.Drawing.Size(305, 34);
            this.cursosToolStripMenuItem1.Text = "Cursos";
            this.cursosToolStripMenuItem1.Click += new System.EventHandler(this.cursosToolStripMenuItem1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Location = new System.Drawing.Point(45, 557);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(310, 35);
            this.button1.TabIndex = 11;
            this.button1.Text = "Notas";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Alumnos
            // 
            this.AccessibleDescription = "navegacion";
            this.AccessibleName = "navegacion";
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 675);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btninscalummnos);
            this.Controls.Add(this.btnmaterias);
            this.Controls.Add(this.btnCursos);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.texto);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Alumnos";
            this.Text = "Alumnos";
            this.Load += new System.EventHandler(this.Alumnos_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RichTextBox texto;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnCursos;
        private System.Windows.Forms.Button btnmaterias;
        private System.Windows.Forms.Button btninscalummnos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem asasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscripcionDeAlumnosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem materiasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modulosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem planesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem especialidadesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem1;
        private System.Windows.Forms.Button button1;
    }
}