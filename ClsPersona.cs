using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pry.SP1semes2
{
    class ClsPersona
    {
        // propiedades - caracterìsticas
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public DateTime FechaNacimiento { get; set; }
        public Int32 Edad { get; set; }
        public string Domicilio { get; set; }
        public string DNI { get; set; }

        // método - acciones (mètodos)
        public string ObtenerNombreCompleto()
        {
            return Nombre + " " + Apellido + " " + Domicilio + " " + DNI + " " + FechaNacimiento;
        }

        public int CalcularEdad()
        {
            Edad = DateTime.Now.Year - FechaNacimiento.Year;
            //grabar en la propiedad EDAD
            return Edad;
        }
    }
}
