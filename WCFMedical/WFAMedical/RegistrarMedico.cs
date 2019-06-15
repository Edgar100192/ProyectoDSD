using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using WCFServices.Dominio;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WFAMedical
{
    public partial class RegistrarMedico : Form
    {
        ServiceReference1.MedicosClient obj = new WFAMedical.ServiceReference1.MedicosClient();
       

        public RegistrarMedico()
        {
            InitializeComponent();
            showdata();
        }
        private void showdata()
        {
            
            Medico ds = new Medico();
            ds = obj.CrearMedico();

            dataGridView1.DataSourse = ds.Tables[0];
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            ServiceReference1.Medicos objMedico = new ServiceReference1.Medicos();
            objMedico.Dni = textBox1.Text;
            objMedico.Nombre = textBox2.Text;
            objMedico.ApellidoPaterno = textBox3.Text;
            objMedico.ApellidoPaterno = textBox4.Text;
            objMedico.Sexo = textBox5.Text;
            objMedico.FechaNacimiento = textBox6.Text;
            objMedico.Correo = textBox7.Text;
            obj.CrearMedico(objMedico);
       
        }
    }
}
