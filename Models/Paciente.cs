using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Models
{
    public class Paciente
    {
        public int Id { get; set; }
        public string cedula { get; set; }
        public string nombre { get; set; }
        public string apellido1 { get; set; }
        public string apellido2 { get; set; }
        public string examen { get; set; }
        public string tipo_examen { get; set; }
        public string ExamenAgudezaVisual { get; set; }
        public string ResultadoAgudezaVisual { get; set; }

        public string ExamenRefraccion { get; set; }
        public string ResultadoRefraccion { get; set; }

        public string ExamenSaludOcular { get; set; }
        public string ResultadoSaludOcular { get; set; }


    }




}