namespace practica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_abrirArchivo_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Title = "Busca tu archivo";
                openFileDialog1.ShowDialog();
                string Texto = openFileDialog1.FileName;

                if (File.Exists(openFileDialog1.FileName))
                {
                    TextReader leer = new StreamReader(Texto);
                    rtb_archivo.Text = leer.ReadToEnd();
                    leer.Close();
                }
                txt_direccionArchivo.Text = Texto;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al abrir el archivo");
            }
        }

        private void btn_guardarArchivo_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(saveFileDialog1.FileName))
                    {
                        string texto = saveFileDialog1.FileName;

                        StreamWriter textoguardar = File.CreateText(texto);
                        textoguardar.Write(rtb_archivo.Text);
                        textoguardar.Flush();
                        textoguardar.Close();

                        txt_direccionArchivo.Text = texto;
                    }
                    else
                    {
                        string texto = saveFileDialog1.FileName;

                        StreamWriter textoguardar = File.CreateText(texto);
                        textoguardar.Write(rtb_archivo.Text);
                        textoguardar.Flush();
                        textoguardar.Close();

                        txt_direccionArchivo.Text = texto;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al guardar el archivo");
            }
        }
    }
}