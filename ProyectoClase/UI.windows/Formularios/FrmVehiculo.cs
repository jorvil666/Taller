using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tallerUI.UI.windows.ControladorAplicacion;
using tallerUI.UI.windows.VistaModelo;

namespace UI.windows.Formularios
{
    public partial class FrmVehiculo : Form
    {
        private VehiculoControlador controlador; //consume el core
        private VehiculoVistaModelo VehiculoVista; //validar la entrada
        public FrmVehiculo()
        {
            InitializeComponent();
            controlador = new VehiculoControlador();
        }

        private void FrmVehiculo_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            VehiculoVista = new VehiculoVistaModelo();
            VehiculoVista.marca = txtMarca.Text;
            VehiculoVista.modelo = txtModelo.Text;
            VehiculoVista.color = txtColor.Text;
            VehiculoVista.placa = txtPlaca.Text;
            controlador.InsertarVehiculo(VehiculoVista);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
