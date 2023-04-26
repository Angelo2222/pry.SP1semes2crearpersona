using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pry.SP1semes2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearPersona_Click(object sender, EventArgs e)
        {
            ClsPersona objPersona = new ClsPersona();
            objPersona.Nombre = "Angelo";
            objPersona.Apellido = "Marconi";
            objPersona.Domicilio = "Direccion";
            objPersona.DNI = "45088474";
            objPersona.FechaNacimiento = dtpFecha.Value;

            MessageBox.Show(objPersona.ObtenerNombreCompleto());
            MessageBox.Show(objPersona.CalcularEdad().ToString());
        }
    }
}
