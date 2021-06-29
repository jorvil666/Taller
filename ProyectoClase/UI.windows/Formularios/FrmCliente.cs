using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.windows.ControladorAplicacion;
using UI.windows.VistaModelo;

namespace UI.windows.Formularios
{
    public partial class FrmCliente : Form
    {
        private ClienteControlador controlador; //consume el core
        private ClienteVistaModelo ClienteVista; //validar la entrada
        public FrmCliente()
        {
            InitializeComponent();
            controlador = new ClienteControlador();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClienteVista = new ClienteVistaModelo();
            ClienteVista.nombreCliente = txtNombre.Text;
            ClienteVista.apellidoCliente = txtApellido.Text;
            ClienteVista.emailCliente = txtEmail.Text;
            controlador.InsertarCliente(ClienteVista);
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {

        }
        public void cargarDatos()
        {
            dataGridView1.DataSource = controlador.ListarClientesActivos();
        }
    }
}
