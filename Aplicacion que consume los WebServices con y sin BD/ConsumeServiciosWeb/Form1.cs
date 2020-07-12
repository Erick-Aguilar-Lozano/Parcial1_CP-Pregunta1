using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace $safeprojectname$
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String datosNet;
            ServiceReference1.WebServiceSoapClient ws = new ServiceReference1.WebServiceSoapClient();
            datosNet = ws.DevuelveNombre();
            textBox2.Text = datosNet;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String datosJava;
            ServiceReference2.NombreClient wsjava = new ServiceReference2.NombreClient();
            datosJava = wsjava.DevuelveNombre();
            textBox1.Text = datosJava;
        }

        private void button4_Click(object sender, EventArgs e)
        {
        
            ServiceReference3.WebServiceSoapClient wsBDNET = new ServiceReference3.WebServiceSoapClient();
            dataGridView1.DataSource = wsBDNET.datos();
            textBox4.Text = dataGridView1.DataSource.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String datosBDjava;
            ServiceReference4.webServiceJAVAClient wsBDJAVA = new ServiceReference4.webServiceJAVAClient();
            datosBDjava = wsBDJAVA.retornaUsuario();
            textBox3.Text = datosBDjava; 
        }
    }
}
