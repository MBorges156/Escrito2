using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Modelo;

namespace Controladores
{
    public class PersonaControlador
    {

        public static void Crear (string nombre, string apellido)
        {
            PersonaModelo persona = new PersonaModelo();
            persona.Nombre = nombre;
            persona.Apellido = apellido;

            persona.Guardar();

        }
        public static void Eliminar(string id)
        {
            PersonaModelo persona = new PersonaModelo();
            persona.Id = Int32.Parse(id);
            persona.Borrar();
        }

        
    }
}
