using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinal.Models;

namespace ProyectoFinal.Services
{
    public class PacienteService
    {
        private List<Paciente> pacientes = new List<Paciente>();

        public List<Paciente> GetPaciente()
        {
            return pacientes;
        }

        public Paciente GetPaciente(int id)
        {
            return pacientes.FirstOrDefault(v => v.Id == id);
        }

        public void AddPaciente(Paciente paciente)
        {
            paciente.Id = pacientes.Count > 0 ? pacientes.Max(v => v.Id) + 1 : 1;
            pacientes.Add(paciente);
        }

        public void UpdatePaciente(Paciente paciente)
        {
            var existingPaciente = GetPaciente(paciente.Id);
            if (existingPaciente != null)
            {
                existingPaciente.cedula = paciente.cedula;
                existingPaciente.nombre = paciente.nombre;
                existingPaciente.apellido1 = paciente.apellido1;
                existingPaciente.apellido2 = paciente.apellido2;
                existingPaciente.examen = paciente.examen;
                existingPaciente.tipo_examen = paciente.tipo_examen;
            }
        }

        public Paciente GetPacienteByCedula(string cedula)
        {
            return pacientes.FirstOrDefault(p => p.cedula == cedula);
        }

        public void DeleteVehiculo(int id)
        {
            var vehiculo = GetPaciente(id);
            if (vehiculo != null)
            {
                pacientes.Remove(vehiculo);
            }
        }
    }
}
