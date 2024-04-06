namespace baseDatos
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
            this.btn_conectarDatos = new System.Windows.Forms.Button();
            this.btn_desconectarDatos = new System.Windows.Forms.Button();
            this.btn_consultarDatos = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_conectarDatos
            // 
            this.btn_conectarDatos.Location = new System.Drawing.Point(8, 165);
            this.btn_conectarDatos.Name = "btn_conectarDatos";
            this.btn_conectarDatos.Size = new System.Drawing.Size(136, 49);
            this.btn_conectarDatos.TabIndex = 0;
            this.btn_conectarDatos.Text = "Conertar";
            this.btn_conectarDatos.UseVisualStyleBackColor = true;
            // 
            // btn_desconectarDatos
            // 
            this.btn_desconectarDatos.Location = new System.Drawing.Point(8, 238);
            this.btn_desconectarDatos.Name = "btn_desconectarDatos";
            this.btn_desconectarDatos.Size = new System.Drawing.Size(136, 49);
            this.btn_desconectarDatos.TabIndex = 1;
            this.btn_desconectarDatos.Text = "Desconectar";
            this.btn_desconectarDatos.UseVisualStyleBackColor = true;
            // 
            // btn_consultarDatos
            // 
            this.btn_consultarDatos.Location = new System.Drawing.Point(8, 91);
            this.btn_consultarDatos.Name = "btn_consultarDatos";
            this.btn_consultarDatos.Size = new System.Drawing.Size(136, 49);
            this.btn_consultarDatos.TabIndex = 2;
            this.btn_consultarDatos.Text = "Consulta";
            this.btn_consultarDatos.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(177, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(464, 271);
            this.dataGridView1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btn_consultarDatos);
            this.groupBox1.Controls.Add(this.btn_desconectarDatos);
            this.groupBox1.Controls.Add(this.btn_conectarDatos);
            this.groupBox1.Location = new System.Drawing.Point(-2, -6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 317);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 310);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_conectarDatos;
        private System.Windows.Forms.Button btn_desconectarDatos;
        private System.Windows.Forms.Button btn_consultarDatos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

