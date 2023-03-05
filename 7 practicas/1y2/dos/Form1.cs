using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dos
{
    public partial class Form1 : Form
    {
        string dia;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime fecha = dateTimePicker1.Value;
            diatxt.Text = fecha.DayOfWeek.ToString();
            dia = fecha.DayOfWeek.ToString();
            if (dia == "Sunday" || dia == "Saturday")
            {

                tipotxt.Text = "Fin de semana";
            }
            else
            {
                tipotxt.Text = "Dia de semana";
            }

        }
    }
}
