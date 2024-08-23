using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinal.Models;

namespace ProyectoFinal.Services
{
    public class DoctorService
    {
        private List<Doctor> doctores = new List<Doctor>();

        public List<Doctor> GetDoctores()
        {
            return doctores;
        }

        public Doctor GetDoctor(int id)
        {
            return doctores.FirstOrDefault(d => d.Id == id);
        }

        public void AddDoctor(Doctor doctor)
        {
            doctor.Id = doctores.Count > 0 ? doctores.Max(d => d.Id) + 1 : 1;
            doctores.Add(doctor);
        }

        public void UpdateDoctor(Doctor doctor)
        {
            var existingDoctor = GetDoctor(doctor.Id);
            if (existingDoctor != null)
            {
                existingDoctor.Cedula = doctor.Cedula;
                existingDoctor.Nombre = doctor.Nombre;
                existingDoctor.Apellido1 = doctor.Apellido1;
                existingDoctor.Apellido2 = doctor.Apellido2;
                existingDoctor.Especialidad = doctor.Especialidad;
            }
        }

        public void DeleteDoctor(int id)
        {
            var doctor = GetDoctor(id);
            if (doctor != null)
            {
                doctores.Remove(doctor);
            }
        }
    }
}