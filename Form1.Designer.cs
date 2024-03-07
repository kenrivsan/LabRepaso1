
namespace LabRepaso1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtvEmpleados = new System.Windows.Forms.DataGridView();
            this.dtvAsistencia = new System.Windows.Forms.DataGridView();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.dtvReportes = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtvEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvAsistencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvReportes)).BeginInit();
            this.SuspendLayout();
            // 
            // dtvEmpleados
            // 
            this.dtvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvEmpleados.Location = new System.Drawing.Point(12, 55);
            this.dtvEmpleados.Name = "dtvEmpleados";
            this.dtvEmpleados.RowHeadersWidth = 51;
            this.dtvEmpleados.RowTemplate.Height = 24;
            this.dtvEmpleados.Size = new System.Drawing.Size(452, 291);
            this.dtvEmpleados.TabIndex = 0;
            // 
            // dtvAsistencia
            // 
            this.dtvAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvAsistencia.Location = new System.Drawing.Point(489, 55);
            this.dtvAsistencia.Name = "dtvAsistencia";
            this.dtvAsistencia.RowHeadersWidth = 51;
            this.dtvAsistencia.RowTemplate.Height = 24;
            this.dtvAsistencia.Size = new System.Drawing.Size(516, 291);
            this.dtvAsistencia.TabIndex = 1;
            this.dtvAsistencia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(406, 352);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(136, 54);
            this.btnLeer.TabIndex = 2;
            this.btnLeer.Text = "Ingresar";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(477, 527);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(136, 54);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // dtvReportes
            // 
            this.dtvReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvReportes.Location = new System.Drawing.Point(12, 429);
            this.dtvReportes.Name = "dtvReportes";
            this.dtvReportes.RowHeadersWidth = 51;
            this.dtvReportes.RowTemplate.Height = 24;
            this.dtvReportes.Size = new System.Drawing.Size(439, 291);
            this.dtvReportes.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(583, 448);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(747, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Mostrar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(589, 494);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 724);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dtvReportes);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.dtvAsistencia);
            this.Controls.Add(this.dtvEmpleados);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvAsistencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvReportes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtvEmpleados;
        private System.Windows.Forms.DataGridView dtvAsistencia;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.DataGridView dtvReportes;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

