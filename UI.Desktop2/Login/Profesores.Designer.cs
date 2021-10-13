
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
            this.components = new System.ComponentModel.Container();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnPlanes = new System.Windows.Forms.Button();
            this.btndocentescursos = new System.Windows.Forms.Button();
            this.btnModuos = new System.Windows.Forms.Button();
            this.btncursos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.richTextBox1.Location = new System.Drawing.Point(39, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(432, 80);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnPlanes
            // 
            this.btnPlanes.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPlanes.Location = new System.Drawing.Point(262, 200);
            this.btnPlanes.Name = "btnPlanes";
            this.btnPlanes.Size = new System.Drawing.Size(165, 23);
            this.btnPlanes.TabIndex = 1;
            this.btnPlanes.Text = "Panes";
            this.btnPlanes.UseVisualStyleBackColor = false;
            this.btnPlanes.Click += new System.EventHandler(this.btnPlanes_Click);
            // 
            // btndocentescursos
            // 
            this.btndocentescursos.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btndocentescursos.Location = new System.Drawing.Point(262, 246);
            this.btndocentescursos.Name = "btndocentescursos";
            this.btndocentescursos.Size = new System.Drawing.Size(165, 23);
            this.btndocentescursos.TabIndex = 2;
            this.btndocentescursos.Text = "docentes por cursos";
            this.btndocentescursos.UseVisualStyleBackColor = false;
            this.btndocentescursos.Click += new System.EventHandler(this.btndocentescursos_Click);
            // 
            // btnModuos
            // 
            this.btnModuos.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnModuos.Location = new System.Drawing.Point(63, 246);
            this.btnModuos.Name = "btnModuos";
            this.btnModuos.Size = new System.Drawing.Size(165, 23);
            this.btnModuos.TabIndex = 4;
            this.btnModuos.Text = "Modulos";
            this.btnModuos.UseVisualStyleBackColor = false;
            this.btnModuos.Click += new System.EventHandler(this.btnModuos_Click);
            // 
            // btncursos
            // 
            this.btncursos.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btncursos.Location = new System.Drawing.Point(63, 200);
            this.btncursos.Name = "btncursos";
            this.btncursos.Size = new System.Drawing.Size(165, 23);
            this.btncursos.TabIndex = 5;
            this.btncursos.Text = "Cursos";
            this.btncursos.UseVisualStyleBackColor = false;
            this.btncursos.Click += new System.EventHandler(this.btncursos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Seleccione una accion";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(97, 26);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Profesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 314);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncursos);
            this.Controls.Add(this.btnModuos);
            this.Controls.Add(this.btndocentescursos);
            this.Controls.Add(this.btnPlanes);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Profesores";
            this.Text = "Profesores";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnPlanes;
        private System.Windows.Forms.Button btndocentescursos;
        private System.Windows.Forms.Button btnModuos;
        private System.Windows.Forms.Button btncursos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}