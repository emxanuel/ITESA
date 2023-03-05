using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace Practicas_12_9_2022
{
    public partial class FormExcel : Form
    {
        public FormExcel()
        {
            InitializeComponent();
            var excel = new Excel.Application();
            var libro = excel.Workbooks.Open(@"C:\Users\ealg2\Documents\Dioris\Practicas 12-9-2022\excel.xlsx");
            var hoja = libro.Worksheets[1];
            Range range = hoja.UsedRange;
            object[,] values = (object[,])range.Value;
            for (int i = 1; i <= values.GetLength(0); i++)
            {
                object[] rowValues = new object[values.GetLength(1)];
                for (int j = 1; j <= values.GetLength(1); j++)
                {
                    rowValues[j - 1] = values[i, j];
                }
                dataGridView1.Rows.Add(rowValues);
            }
            libro.Close();
            excel.Quit();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int filas, columnas;
            filas = dataGridView1.RowCount;
            columnas = dataGridView1.ColumnCount;
            var excel = new Excel.Application();
            var libro = excel.Workbooks.Open(@"C:\Users\ealg2\Documents\Dioris\Practicas 12-9-2022\excel.xlsx");
            var hoja = libro.Worksheets[1];
            string[,] tabla = new string[filas, columnas];

            try
            {
                for (int i = 1; i <= filas; i++)
                {
                    for (int j = 1; j <= columnas; j++)
                    {
                        if (dataGridView1.Rows[i - 1].Cells[j - 1].Value == null)
                        {
                            tabla[i - 1, j - 1] = "";
                        }
                        else
                        { 
                            tabla[i - 1, j - 1] = dataGridView1.Rows[i - 1].Cells[j - 1].Value.ToString();
                        }
                        hoja.Cells[i, j].Value = tabla[i - 1, j - 1];
                    }
                }
                
                
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            libro.Save();
            excel.Quit();
            MessageBox.Show("Documento Guardado");

        }
    }
}
