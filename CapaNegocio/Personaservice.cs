using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaPresentacion.Modelos;
using Microsoft.EntityFrameworkCore;

namespace CapaNegocio
{
    public class PersonaService
    {
        private readonly AppDbContext _context;

        public PersonaService(AppDbContext context)
        {
            _context = context;
        }

        // Método para obtener todas las personas
        public List<Persona> ObtenerPersonas()
        {
            return _context.Persona.ToList();
        }

        // Método para agregar una nueva persona
        public void AgregarPersona(Persona persona)
        {
            _context.Persona.Add(persona);
            _context.SaveChanges();
        }

        // Método para actualizar una persona
        public void ActualizarPersona(Persona persona)
        {
            var personaExistente = _context.Persona.FirstOrDefault(p => p.Id == persona.Id);

            if (personaExistente != null)
            {
                _context.Entry(personaExistente).State = EntityState.Detached;
            }

            _context.Persona.Update(persona);
            _context.SaveChanges();
        }

        // Método para eliminar una persona
        public void EliminarPersona(int id)
        {
            var persona = _context.Persona.FirstOrDefault(p => p.Id == id);
            if (persona != null)
            {
                _context.Persona.Remove(persona);
                _context.SaveChanges();
            }
        }
    }
}

