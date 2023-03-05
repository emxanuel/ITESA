using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicas_12_9_2022
{
    public partial class FormConversionTemperatura : Form
    {
        public FormConversionTemperatura()
        {
            InitializeComponent();
        }

        private void tbFahrenheit_TextChanged(object sender, EventArgs e)
        {
            double fahrenheit, kelvin;
            if (double.TryParse(tbFahrenheit.Text, out fahrenheit))
            {
                kelvin = (fahrenheit - 32) * 5 / 9 + 273.15;
                tbKelvin.Text = Math.Round(kelvin, 3).ToString() + "K";
            }
        }

        private void tbKelvin_TextChanged(object sender, EventArgs e)
        {
            double fahrenheit, kelvin;
            if(double.TryParse(tbKelvin.Text, out kelvin))
            {
                fahrenheit = (kelvin - 273.15) * 9 / 5 + 32;
                tbFahrenheit.Text = Math.Round(fahrenheit, 3).ToString() + "°F";
            }
        }
    }
}
