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
    public partial class CrearSolicitud : Form
    {
   
        WCFServiceSolicitud.SolicitudesClient obj = new WCFServiceSolicitud.SolicitudesClient();
        public CrearSolicitud()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WCFServiceSolicitud.Solicitud objSolicitud = new WCFServiceSolicitud.Solicitud(); // add type reference

            objSolicitud.Nu_Solicitud = Convert.ToInt32(txtSoli.Text);
            objSolicitud.co_Cliente = Convert.ToInt32(txtcod.Text);
            objSolicitud.Direccion = txtDire.Text;
            objSolicitud.Distrito = txtDistri.Text;
            objSolicitud.dni_medio = Convert.ToInt32(txtdni.Text);
            objSolicitud.fe_registro = txtFecha.Text;
            objSolicitud.observa = txtobse.Text;
            objSolicitud.estado = txtesta.Text;

            obj.CrearSolicitud(objSolicitud);

        }
    }
}
