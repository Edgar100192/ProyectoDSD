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
    public partial class CrearCliente : Form
    {
        WCFServiceCliente.ClientesClient obj = new WCFServiceCliente.ClientesClient();
        public CrearCliente()
        {
            InitializeComponent();
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            WCFServiceCliente.Cliente objCliente = new WCFServiceCliente.Cliente();

            objCliente.cod_cliente = Convert.ToInt32(txt_cliente.Text);
            objCliente.des_nombres = txt_nombres.Text;
            objCliente.des_ape_paterno = txt_paterno.Text;
            objCliente.des_ape_materno = txt_materno.Text;
            objCliente.fec_nacimiento = txt_nacimiento.Text;
            objCliente.des_direccion = txt_direccion.Text;
            objCliente.des_distrito = txt_distrito.Text;
            objCliente.num_telefono = Convert.ToInt32(txt_telefono.Text);
            objCliente.des_email = txt_email.Text;
            objCliente.ind_estado = txt_estado.Text;
            obj.CrearCliente(objCliente);
        }

        private void CrearCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
