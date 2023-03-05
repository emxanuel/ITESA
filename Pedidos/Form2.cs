using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pedidos
{
    public partial class Form2 : Form
    {

        SqlConnection connection = new SqlConnection(@"server=EMMANUEL\EMMANUEL; database=Pedidos; integrated security=yes");
        DataTable dt = new DataTable();
        SqlCommand command;
        SqlDataAdapter adapter;

        public Form2()
        {
            InitializeComponent();
            command = new SqlCommand("select distinct Vendedor from listapedidos", connection);
            adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            comboBox1.ValueMember = "Vendedor";
            comboBox1.DisplayMember = "Vendedor";
            comboBox1.DataSource = dt;
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Vendedor;
            Vendedor = comboBox1.Text;
            this.reporte2TableAdapter1.Fill(pedidosDataSet1.Reporte2, Vendedor);
            this.reportViewer1.RefreshReport();
        }
    }
}
