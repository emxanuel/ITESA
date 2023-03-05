using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculadora
{
    public partial class FormCalculadora : Form
    {
        bool operacion, punto;
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (textBox1.Text[textBox1.Text.Length - 1] == '+' || textBox1.Text[textBox1.Text.Length - 1] == '-'
                    || textBox1.Text[textBox1.Text.Length - 1] == '*' || textBox1.Text[textBox1.Text.Length - 1] == '/')
                {
                    operacion = true;
                }
            }
            if (textBox1.Text.Length > 0)
            {
                if (operacion == true)
                {
                    string a = textBox1.Text;
                    a = a.Substring(0, a.Length - 1);
                    a += "+";
                    textBox1.Text = a;
                }
                else
                {
                    textBox1.Text += "+";
                }
                operacion = false;
            }

        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (textBox1.Text[textBox1.Text.Length - 1] == '+' || textBox1.Text[textBox1.Text.Length - 1] == '-'
                    || textBox1.Text[textBox1.Text.Length - 1] == '*' || textBox1.Text[textBox1.Text.Length - 1] == '/')
                {
                    operacion = true;
                }
            }
            if (operacion == true)
            {
                string a = textBox1.Text;
                a = a.Substring(0, a.Length - 1);
                a += "-";
                textBox1.Text = a;
            }
            else
            {
                textBox1.Text += "-";
            }
            operacion = true;

        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (textBox1.Text[textBox1.Text.Length - 1] == '+' || textBox1.Text[textBox1.Text.Length - 1] == '-'
                    || textBox1.Text[textBox1.Text.Length - 1] == '*' || textBox1.Text[textBox1.Text.Length - 1] == '/')
                {
                    operacion = true;
                }
            }
            if (textBox1.Text.Length > 0)
            {
                if (operacion == true)
                {
                    string a = textBox1.Text;
                    a = a.Substring(0, a.Length - 1);
                    a += "*";
                    textBox1.Text = a;
                }
                else
                {
                    textBox1.Text += "*";
                }
                operacion = false;
            }

        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (textBox1.Text[textBox1.Text.Length - 1] == '+' || textBox1.Text[textBox1.Text.Length - 1] == '-'
                    || textBox1.Text[textBox1.Text.Length - 1] == '*' || textBox1.Text[textBox1.Text.Length - 1] == '/')
                {
                    operacion = true;
                }
            }
            if (textBox1.Text.Length > 0)
            {
                if (operacion == true)
                {
                    string a = textBox1.Text;
                    a = a.Substring(0, a.Length - 1);
                    a += "/";
                    textBox1.Text = a;
                }
                else
                {
                    textBox1.Text += "/";
                }
                operacion = false;
            }

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn1.Text;
            operacion = false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn2.Text;
            operacion = false;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn3.Text;
            operacion = false;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn4.Text;
            operacion = false;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn5.Text;
            operacion = false;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn6.Text;
            operacion = false;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn7.Text;
            operacion = false;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn8.Text;
            operacion = false;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn9.Text;
            operacion = false;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text += btn0.Text;
                operacion = false;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        private void btnCambiarSigno_Click(object sender, EventArgs e)
        {
            textBox1.Text = (int.Parse(textBox1.Text) * -1).ToString();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            textBox1.Text = calcular(textBox1.Text).ToString();
        }

        double calcular(string operacion)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("operacion", string.Empty.GetType(), operacion);
            DataRow row = dt.NewRow();
            dt.Rows.Add(row);

            return double.Parse((string)row["operacion"]);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void btnParentesis_Click(object sender, EventArgs e)
        {
            textBox1.Text += "(";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += ")";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (textBox1.Text[i] == '.')
                {
                    punto = true;
                }
            }
            if (punto != true)
            {
                textBox1.Text += ".";
            }
            punto = false;

        }
    }
}
