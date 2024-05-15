using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Clases
{
    public class Consulta
    {
        private DateTime fecha;
        private Paciente paciente;

        public DateTime Fecha { get => fecha; }
        internal Paciente Paciente { get => paciente; }

        public Consulta(DateTime fecha, Paciente paciente)
        {
            this.fecha = fecha;
            this.paciente = paciente;
        }

        public string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{fecha}");
            sb.Append($"se ha antendido a ");
            sb.Append($"{paciente.NombreCompleto()}");
            return sb.ToString();
        }

        
    }
}
