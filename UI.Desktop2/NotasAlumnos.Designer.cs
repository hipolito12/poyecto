
namespace UI.Desktop2
{
    partial class NotasAlumnos
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tetsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mostrar_notasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tp2DataSet2 = new UI.Desktop2.tp2DataSet2();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.mostrar_notasTableAdapter = new UI.Desktop2.tp2DataSet2TableAdapters.mostrar_notasTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cursosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tp2DataSet = new UI.Desktop2.tp2DataSet();
            this.cursosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cursosTableAdapter = new UI.Desktop2.tp2DataSetTableAdapters.cursosTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cursosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tetsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrar_notasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // mostrar_notasBindingSource
            // 
            this.mostrar_notasBindingSource.DataMember = "mostrar_notas";
            this.mostrar_notasBindingSource.DataSource = this.tp2DataSet2;
            // 
            // tp2DataSet2
            // 
            this.tp2DataSet2.DataSetName = "tp2DataSet2";
            this.tp2DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "Prueba";
            reportDataSource1.Value = this.tetsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "UI.Desktop2.ReporteNotas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(313, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(891, 455);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // mostrar_notasTableAdapter
            // 
            this.mostrar_notasTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione ciclo lectivo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cursosBindingSource
            // 
            this.cursosBindingSource.DataMember = "cursos";
            this.cursosBindingSource.DataSource = this.tp2DataSet;
            // 
            // tp2DataSet
            // 
            this.tp2DataSet.DataSetName = "tp2DataSet";
            this.tp2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cursosBindingSource1
            // 
            this.cursosBindingSource1.DataMember = "cursos";
            this.cursosBindingSource1.DataSource = this.tp2DataSet;
            // 
            // cursosTableAdapter
            // 
            this.cursosTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 60);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(273, 28);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // cursosBindingSource2
            // 
            this.cursosBindingSource2.DataMember = "cursos";
            this.cursosBindingSource2.DataSource = this.tp2DataSet;
            // 
            // NotasAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 486);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "NotasAlumnos";
            this.Text = "Notas de los alumnos";
            this.Load += new System.EventHandler(this.Pruebas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tetsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrar_notasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource mostrar_notasBindingSource;
        private tp2DataSet2 tp2DataSet2;
        private tp2DataSet2TableAdapters.mostrar_notasTableAdapter mostrar_notasTableAdapter;
        private System.Windows.Forms.BindingSource tetsBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private tp2DataSet tp2DataSet;
        private System.Windows.Forms.BindingSource cursosBindingSource;
        private tp2DataSetTableAdapters.cursosTableAdapter cursosTableAdapter;
        private System.Windows.Forms.BindingSource cursosBindingSource1;
        private System.Windows.Forms.BindingSource cursosBindingSource2;
        public System.Windows.Forms.ComboBox comboBox1;
    }
}