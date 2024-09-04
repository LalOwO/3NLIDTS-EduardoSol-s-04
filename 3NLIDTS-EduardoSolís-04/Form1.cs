namespace _3NLIDTS_EduardoSolís_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(GetLabel2());
        }

        private void label2_Click(object sender, EventArgs e)
        {
             void btGuardar_Click(object sender, EventArgs e)
            {
                string apellidos = tbapellido.Text;
                string edad = tbedad.Text;
                string estatura = tbestatura.Text;
                string telefono = tbtelefono.Text;

                string genero = "";
                if (rbHombre.Checked)
                {
                    genero = "Hombre";
                }
                else if (rbMujer.Checked)
                {
                    genero = "Mujer";
                }

                string datos = $"Apellidos:{apellidos}\r\n" + $"Telefono:{telefono}\r\n" + $"Estatura:{estatura}\r\nEdad:{edad}años\r\n" + $"Género:{genero}";

                string rutaArchivo = "C:\\Users\\eduardo solis\\Desktop\\UNIVERSIDAD\\tareas\\2.5to sem\\prog avan\\OMGesInfo.txt";
                bool archivoExiste = File.Exists(rutaArchivo);

                using (StreamWriter writer = new StreamWriter(rutaArchivo, true))
                {
                    if (archivoExiste)
                    {
                        writer.WriteLine();
                    }

                    MessageBox.Show("Datos guardados con exito:\n\n" + datos, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

             void btLimpiar_Click(object sender, EventArgs e)
            {
                tbapellido.Clear();
                tbestatura.Clear();
                tbtelefono.Clear();
                tbedad.Clear();
                rbHombre.Checked = false;
                rbMujer.Checked = false;
            }

             void lbEdad_Click(object sender, EventArgs e)
            {

            }

             void rbHombre_CheckedChanged(object sender, EventArgs e)
            {

            }
        }
    }
}
