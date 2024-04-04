namespace practica
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);

            /*
                
            */
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rtb_archivo = new RichTextBox();
            label1 = new Label();
            txt_direccionArchivo = new TextBox();
            btn_abrirArchivo = new Button();
            btn_guardarArchivo = new Button();
            groupBox1 = new GroupBox();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // rtb_archivo
            // 
            rtb_archivo.Location = new Point(18, 51);
            rtb_archivo.Name = "rtb_archivo";
            rtb_archivo.Size = new Size(485, 358);
            rtb_archivo.TabIndex = 0;
            rtb_archivo.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(18, 25);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 1;
            label1.Text = "Direccion:";
            label1.Click += label1_Click;
            // 
            // txt_direccionArchivo
            // 
            txt_direccionArchivo.Location = new Point(78, 22);
            txt_direccionArchivo.Name = "txt_direccionArchivo";
            txt_direccionArchivo.Size = new Size(425, 23);
            txt_direccionArchivo.TabIndex = 2;
            // 
            // btn_abrirArchivo
            // 
            btn_abrirArchivo.BackColor = Color.MediumBlue;
            btn_abrirArchivo.FlatAppearance.BorderSize = 0;
            btn_abrirArchivo.FlatStyle = FlatStyle.Flat;
            btn_abrirArchivo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_abrirArchivo.ForeColor = Color.DodgerBlue;
            btn_abrirArchivo.Location = new Point(65, 440);
            btn_abrirArchivo.Margin = new Padding(0);
            btn_abrirArchivo.Name = "btn_abrirArchivo";
            btn_abrirArchivo.Size = new Size(172, 57);
            btn_abrirArchivo.TabIndex = 3;
            btn_abrirArchivo.Text = "ABRIR";
            btn_abrirArchivo.UseVisualStyleBackColor = false;
            btn_abrirArchivo.Click += btn_abrirArchivo_Click;
            // 
            // btn_guardarArchivo
            // 
            btn_guardarArchivo.BackColor = Color.MediumBlue;
            btn_guardarArchivo.FlatAppearance.BorderSize = 0;
            btn_guardarArchivo.FlatStyle = FlatStyle.Flat;
            btn_guardarArchivo.ForeColor = Color.DodgerBlue;
            btn_guardarArchivo.Location = new Point(273, 440);
            btn_guardarArchivo.Margin = new Padding(0);
            btn_guardarArchivo.Name = "btn_guardarArchivo";
            btn_guardarArchivo.Size = new Size(172, 57);
            btn_guardarArchivo.TabIndex = 4;
            btn_guardarArchivo.Text = "GUARDAR";
            btn_guardarArchivo.UseVisualStyleBackColor = false;
            btn_guardarArchivo.Click += btn_guardarArchivo_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.MenuHighlight;
            groupBox1.Controls.Add(btn_guardarArchivo);
            groupBox1.Controls.Add(btn_abrirArchivo);
            groupBox1.Controls.Add(txt_direccionArchivo);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(rtb_archivo);
            groupBox1.Location = new Point(0, -13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(533, 528);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 509);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtb_archivo;
        private Label label1;
        private TextBox txt_direccionArchivo;
        private Button btn_abrirArchivo;
        private Button btn_guardarArchivo;
        private GroupBox groupBox1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}