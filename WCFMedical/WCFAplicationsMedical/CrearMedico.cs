using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Web;
using System.Data.SqlClient;
using System.ServiceModel;


namespace WCFAplicationsMedical
{
    public partial class CrearMedico : Form
    {
        WCFServiceReference.MedicosClient obj = new WCFServiceReference.MedicosClient();
        public CrearMedico()
        {
            InitializeComponent();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

            WCFServiceReference.Medico objMedico = new WCFServiceReference.Medico(); // add type reference

            objMedico.Dni = Convert.ToInt32(textBoxDni.Text);
            objMedico.Nombre = textBoxNombre.Text;
            objMedico.ApellidoPaterno = textBoxApellidoPaterno.Text;
            objMedico.ApellidoMaterno = textBoxApellidoMaterno.Text;
            objMedico.Sexo = textBoxSexo.Text;
            objMedico.FechaNacimiento = textBoxFechaNacimiento.Text;
            objMedico.Especialidad = textBoxEspecialidad.Text;
            objMedico.Correo = textBoxCorreo.Text;
            obj.CrearMedico(objMedico);
        }
        private void CrearMedico_Load(object sender, EventArgs e)
        {

        }

        private void textBoxDni_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
