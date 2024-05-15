using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Clases
{
    public class Paciente : Persona
    {
        string diagnostico;

        public string Diagnostico { get => diagnostico; set => diagnostico = value; }

        public Paciente(string nombre, string apellido, DateTime nacimiento, string barrioRecidencial, string diagnostico) :base (nombre,  apellido,  nacimiento,  barrioRecidencial)
        {
            this.diagnostico = diagnostico;
        }
        internal override string FichaExtra()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Recide en {this.barrioRecidencial}");
            sb.AppendLine($"{this.diagnostico}");
            return sb.ToString();
        }
    }
}
