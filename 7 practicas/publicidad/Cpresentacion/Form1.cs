using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Centidades;
using Cnegocio;


namespace Cpresentacion
{
    public partial class Form1 : Form
    {
        Entidades objentidad = new Entidades();
        Negocio objnegocio = new Negocio();
        Entidades2 objentidad2 = new Entidades2();
        Negocio2 objnegocio2 = new Negocio2();
        public int n = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TBnombre_TextChanged(object sender, EventArgs e)
        {

        }
         public void mostraremisora (int buscar)
        {
            Negocio objDato = new Negocio();
            Tablacliente.DataSource = objDato.Semisora(buscar);
        }
        public void mostrarcobro(int buscar)
        {
            Negocio2 objDato = new Negocio2();
            Tablacliente.DataSource = objDato.Scobro(buscar);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Tablacliente.ClearSelection();
            mostraremisora(0);
        }

        private void TBbuscar_TextChanged(object sender, EventArgs e)
        {
            if (n == 0)
            {
                int buscar;
                int.TryParse(TBbuscar.Text, out buscar);
                if (TBbuscar.Text == "")
                {
                    mostraremisora(0);
                }
                mostraremisora(buscar);
            }
            else
            {
                int buscar;
                int.TryParse(TBbuscar.Text, out buscar);
                if (TBbuscar.Text == "")
                {
                    mostrarcobro(0);
                }
                mostrarcobro(buscar);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (n == 0)
            {
                n = 1;
                mostrarcobro(0);

            }
            else
            {
                n = 0;
                mostraremisora(0);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
                if (Tablacliente.SelectedRows.Count > 0)
                {
                    txtid.Text = Tablacliente.CurrentRow.Cells[0].Value.ToString();
                }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "") { MessageBox.Show("Ingrese informacion"); }
            else {
                double min = 0;
                double sec = 0;
                double r = 0;
                min = Convert.ToDouble(txtmin.Text) * 60;
                sec = Convert.ToDouble(txtsec.Text);
                if (sec >= 60)
                {
                    MessageBox.Show("Ingrese un numero menor a 60");
                    txtsec.Clear();
                }
                else
                {
                    r = ((min + sec) * Convert.ToDouble(txtdias.Text)) * Convert.ToDouble(txtprecio.Text);
                    if (Tablacliente.SelectedRows.Count > 0)
                    {
                        try
                        {
                            objentidad2.Id_emisora = Convert.ToInt32(txtid.Text);
                            objentidad2.Patrocinador = txtpatrocinador.Text.ToLower();
                            objentidad2.Precioxsec = txtprecio.Text.ToLower();
                            objentidad2.Duracion = txtmin.Text + ":" + txtsec.Text;
                            objentidad2.Diasxsemana = Convert.ToInt32(txtdias.Text);
                            objentidad2.Preciototal = r.ToString();
                            objnegocio2.Ccobro(objentidad2);
                            MessageBox.Show("Enviado");
                            limpiarcajas();


                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("No se ha podido enviar" + ex);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Eliga la emisora");
                    }
                }
            }

            
        }
        public void limpiarcajas()
        {
            txtid.Clear();
            txtpatrocinador.Clear();
            txtprecio.Clear();
            txtmin.Clear();
            txtsec.Clear();
            txtdias.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Tablacliente.SelectedRows.Count > 0)
            {
                objentidad2.Id_emisora = Convert.ToInt32(txtid.Text);
                objnegocio2.Dcobro(objentidad2);
                MessageBox.Show("se ha eliminado el registro");
                limpiarcajas();
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }
    }
}
