
namespace UI.Desktop2.Login
{
    partial class Profesores
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnPlanes = new System.Windows.Forms.Button();
            this.btndocentescursos = new System.Windows.Forms.Button();
            this.btncursos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnComisiones = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.navegacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscripcionAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.docentesCursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.richTextBox1.Location = new System.Drawing.Point(42, 62);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(646, 121);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnPlanes
            // 
            this.btnPlanes.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPlanes.Location = new System.Drawing.Point(393, 308);
            this.btnPlanes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPlanes.Name = "btnPlanes";
            this.btnPlanes.Size = new System.Drawing.Size(248, 35);
            this.btnPlanes.TabIndex = 1;
            this.btnPlanes.Text = "Planes";
            this.btnPlanes.UseVisualStyleBackColor = false;
            this.btnPlanes.Click += new System.EventHandler(this.btnPlanes_Click);
            // 
            // btndocentescursos
            // 
            this.btndocentescursos.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btndocentescursos.Location = new System.Drawing.Point(393, 378);
            this.btndocentescursos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btndocentescursos.Name = "btndocentescursos";
            this.btndocentescursos.Size = new System.Drawing.Size(248, 35);
            this.btndocentescursos.TabIndex = 2;
            this.btndocentescursos.Text = "Calificar Alumnos";
            this.btndocentescursos.UseVisualStyleBackColor = false;
            this.btndocentescursos.Click += new System.EventHandler(this.btndocentescursos_Click);
            // 
            // btncursos
            // 
            this.btncursos.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btncursos.Location = new System.Drawing.Point(94, 308);
            this.btncursos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btncursos.Name = "btncursos";
            this.btncursos.Size = new System.Drawing.Size(248, 35);
            this.btncursos.TabIndex = 5;
            this.btncursos.Text = "Curso que dicta cada docente";
            this.btncursos.UseVisualStyleBackColor = false;
            this.btncursos.Click += new System.EventHandler(this.btncursos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 197);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "Seleccione una accion";
            // 
            // btnComisiones
            // 
            this.btnComisiones.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnComisiones.Location = new System.Drawing.Point(219, 438);
            this.btnComisiones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnComisiones.Name = "btnComisiones";
            this.btnComisiones.Size = new System.Drawing.Size(278, 35);
            this.btnComisiones.TabIndex = 9;
            this.btnComisiones.Text = "Comisiones";
            this.btnComisiones.UseVisualStyleBackColor = false;
            this.btnComisiones.Click += new System.EventHandler(this.btnComisiones_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navegacionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(710, 33);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // navegacionToolStripMenuItem
            // 
            this.navegacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cursosToolStripMenuItem,
            this.modulosToolStripMenuItem,
            this.inscripcionAlumnosToolStripMenuItem,
            this.planesToolStripMenuItem,
            this.docentesCursosToolStripMenuItem});
            this.navegacionToolStripMenuItem.Name = "navegacionToolStripMenuItem";
            this.navegacionToolStripMenuItem.Size = new System.Drawing.Size(121, 29);
            this.navegacionToolStripMenuItem.Text = "Navegacion";
            // 
            // cursosToolStripMenuItem
            // 
            this.cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            this.cursosToolStripMenuItem.Size = new System.Drawing.Size(285, 34);
            this.cursosToolStripMenuItem.Text = "docentes cursos";
            this.cursosToolStripMenuItem.Click += new System.EventHandler(this.cursosToolStripMenuItem_Click);
            // 
            // modulosToolStripMenuItem
            // 
            this.modulosToolStripMenuItem.Name = "modulosToolStripMenuItem";
            this.modulosToolStripMenuItem.Size = new System.Drawing.Size(285, 34);
            this.modulosToolStripMenuItem.Text = "cantidad de alumnos ";
            this.modulosToolStripMenuItem.Click += new System.EventHandler(this.modulosToolStripMenuItem_Click);
            // 
            // inscripcionAlumnosToolStripMenuItem
            // 
            this.inscripcionAlumnosToolStripMenuItem.Name = "inscripcionAlumnosToolStripMenuItem";
            this.inscripcionAlumnosToolStripMenuItem.Size = new System.Drawing.Size(285, 34);
            this.inscripcionAlumnosToolStripMenuItem.Text = "comisiones";
            this.inscripcionAlumnosToolStripMenuItem.Click += new System.EventHandler(this.inscripcionAlumnosToolStripMenuItem_Click);
            // 
            // planesToolStripMenuItem
            // 
            this.planesToolStripMenuItem.Name = "planesToolStripMenuItem";
            this.planesToolStripMenuItem.Size = new System.Drawing.Size(285, 34);
            this.planesToolStripMenuItem.Text = "Planes";
            this.planesToolStripMenuItem.Click += new System.EventHandler(this.planesToolStripMenuItem_Click);
            // 
            // docentesCursosToolStripMenuItem
            // 
            this.docentesCursosToolStripMenuItem.Name = "docentesCursosToolStripMenuItem";
            this.docentesCursosToolStripMenuItem.Size = new System.Drawing.Size(285, 34);
            this.docentesCursosToolStripMenuItem.Text = "calificar";
            this.docentesCursosToolStripMenuItem.Click += new System.EventHandler(this.docentesCursosToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Location = new System.Drawing.Point(98, 378);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 35);
            this.button1.TabIndex = 11;
            this.button1.Text = "Cantidad de Alumno por curso";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Profesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 515);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnComisiones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncursos);
            this.Controls.Add(this.btndocentescursos);
            this.Controls.Add(this.btnPlanes);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Profesores";
            this.Load += new System.EventHandler(this.Profesores_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnPlanes;
        private System.Windows.Forms.Button btndocentescursos;
        private System.Windows.Forms.Button btncursos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnComisiones;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem navegacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscripcionAlumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem docentesCursosToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}