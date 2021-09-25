
namespace UI.Desktop2
{
    partial class Materias1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.txtHs_Semanales = new System.Windows.Forms.TextBox();
            this.TXTHs_Totales = new System.Windows.Forms.TextBox();
            this.planesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tp2DataSet = new UI.Desktop2.tp2DataSet();
            this.planesTableAdapter = new UI.Desktop2.tp2DataSetTableAdapters.planesTableAdapter();
            this.comboidplan = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hs_Semanales";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hs_Totales";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(282, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "ID_Plan";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(120, 35);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtdescripcion.TabIndex = 6;
            // 
            // txtHs_Semanales
            // 
            this.txtHs_Semanales.Location = new System.Drawing.Point(135, 90);
            this.txtHs_Semanales.Name = "txtHs_Semanales";
            this.txtHs_Semanales.Size = new System.Drawing.Size(100, 20);
            this.txtHs_Semanales.TabIndex = 7;
            // 
            // TXTHs_Totales
            // 
            this.TXTHs_Totales.Location = new System.Drawing.Point(342, 35);
            this.TXTHs_Totales.Name = "TXTHs_Totales";
            this.TXTHs_Totales.Size = new System.Drawing.Size(100, 20);
            this.TXTHs_Totales.TabIndex = 8;
            // 
            // planesBindingSource
            // 
            this.planesBindingSource.DataMember = "planes";
            this.planesBindingSource.DataSource = this.tp2DataSet;
            // 
            // tp2DataSet
            // 
            this.tp2DataSet.DataSetName = "tp2DataSet";
            this.tp2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // planesTableAdapter
            // 
            this.planesTableAdapter.ClearBeforeFill = true;
            // 
            // comboidplan
            // 
            this.comboidplan.FormattingEnabled = true;
            this.comboidplan.Location = new System.Drawing.Point(351, 85);
            this.comboidplan.Name = "comboidplan";
            this.comboidplan.Size = new System.Drawing.Size(121, 21);
            this.comboidplan.TabIndex = 10;
            this.comboidplan.SelectedIndexChanged += new System.EventHandler(this.comboidplan_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(219, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Materias1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 236);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboidplan);
            this.Controls.Add(this.TXTHs_Totales);
            this.Controls.Add(this.txtHs_Semanales);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Materias1";
            this.Text = "Materias1";
            this.Load += new System.EventHandler(this.Materias1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtdescripcion;
        public System.Windows.Forms.TextBox txtHs_Semanales;
        public System.Windows.Forms.TextBox TXTHs_Totales;
        private tp2DataSet tp2DataSet;
        private System.Windows.Forms.BindingSource planesBindingSource;
        private tp2DataSetTableAdapters.planesTableAdapter planesTableAdapter;
        public System.Windows.Forms.ComboBox comboidplan;
        private System.Windows.Forms.Button button1;
    }
}