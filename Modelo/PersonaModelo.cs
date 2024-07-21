using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class PersonaModelo : Modelo
    {

        public int Id;
        public string Nombre;
        public string Apellido;

        public void Guardar()
        {
            string sql = $"INSERT INTO personas (Nombre,Apellido) VALUES('{this.Nombre}',{this.Apellido})";
            this.Comando.CommandText = sql;
            this.Comando.ExecuteNonQuery();

        }
        public void Borrar()
        {
            string sql = $"UPDATE personas SET eliminado = true WHERE id ='{this.Id}'";
            this.Comando.CommandText = sql;
            this.Comando.ExecuteNonQuery();
        }

        
    }
}
