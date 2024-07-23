using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FArchivos : Form
    {
        public FArchivos()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private bool escribirArchivo(String ruta)
        {
            try
            {
                // Abrir el archivo para escritura

                StreamWriter sw = new StreamWriter(ruta);

                // Escribir el contenido de la variable en el archivo
                string contenido = escrituratb.Text;
                string[] lineas = contenido.Split('\n');
                foreach (string linea in lineas)
                {
                    sw.WriteLine(linea);

                }

                // Cerrar el archivo
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al escribir el archivo: " + e.Message);
                return false;
            }
            return true;
        }
        private void leerArchivo(String ruta)
        {
            try
            {
                // Abrir el archivo para lectura
                StreamReader sr = new StreamReader(ruta);

                // Leer cada línea del archivo
                string linea;
                string texto="";
                while ((linea = sr.ReadLine()) != null)
                {
                    texto += linea;
                    //Console.WriteLine(linea);
                }

                // Cerrar el archivo
                sr.Close();
                lecturaTb.Text = texto;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al leer el archivo: " + e.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult openFile = openFileDialog1.ShowDialog(this);
            if ( openFile == DialogResult.OK)
            {

                string fileName = openFileDialog1.FileName;
                leerArchivo(fileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult openFile = saveFileDialog1.ShowDialog();
            if (openFile == DialogResult.OK)
            {

                string fileName = saveFileDialog1.FileName;
                bool exito = escribirArchivo(fileName);
                if (exito)
                {
                    MessageBox.Show("Archivo : " + fileName + " guardado correctamente!");
                }
                else
                {
                    MessageBox.Show("Error guardando archivo");
                }
            }
        }
    }
}
