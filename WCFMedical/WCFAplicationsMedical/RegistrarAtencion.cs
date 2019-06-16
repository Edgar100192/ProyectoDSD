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
    public partial class RegistrarAtencion : Form
    {
        WCFServiceAtenciones.AtencionesClient obj = new WCFServiceAtenciones.AtencionesClient();
        
        public RegistrarAtencion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            WCFServiceAtenciones.Atencion objAtencion = new WCFServiceAtenciones.Atencion(); // add type reference

            objAtencion.NunAtencion = Convert.ToInt32(txtNumAtencion.Text);
            objAtencion.NumSolicitud = Convert.ToInt32(txtNumSolicitud.Text);
            objAtencion.NumDni = Convert.ToInt32(txtMedico.Text);
            objAtencion.Observacion = txtObservacion.Text;
            objAtencion.FecRegistro = txtFecha.Text;
            objAtencion.HoraInicio = txtHinicio.Text;
            objAtencion.HoraFin = txtHfin.Text;


            obj.CrearAtencion(objAtencion);












        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void RegistrarAtencion_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
