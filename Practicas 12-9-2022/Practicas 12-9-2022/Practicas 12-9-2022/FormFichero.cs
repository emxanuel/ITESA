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

namespace Practicas_12_9_2022
{
    public partial class FormFichero : Form
    {
        string archivo;
        public FormFichero()
        {
            InitializeComponent();
        }

        private void FormFichero_Load(object sender, EventArgs e)
        {
            /*StreamReader reader = new StreamReader("C:\\Users\\ealg2\\Desktop\\" + archivo + "");
            string texto;
            texto = reader.ReadToEnd();
            richTextBox1.Text = texto;
            reader.Close();*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter(archivo);
            writer.Write(richTextBox1.Text);
            writer.Close();
            MessageBox.Show("Guardado con exito");
            
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter(archivo);
            writer.Write(richTextBox1.Text);
            writer.Close();
            MessageBox.Show("Guardado con exito");
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "C:\\";
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.ShowDialog();
            try
            {
                archivo = openFileDialog.FileName;
                StreamReader reader = new StreamReader(archivo);
                string texto;
                texto = reader.ReadToEnd();
                richTextBox1.Text = texto;
                reader.Close();
            }
            catch
            {

            }
        }
    }
}
