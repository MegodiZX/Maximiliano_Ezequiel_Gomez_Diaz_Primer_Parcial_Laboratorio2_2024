using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Clases
{
    public class PersonalMedico : Persona
    {
        private List<Consulta> consultas;
        private bool esResidente;

        public PersonalMedico(List<Consulta> consultas, string nombre, string apellido, DateTime nacimiento, bool esResidente) : base(nombre, apellido, nacimiento)
        {
            this.consultas = consultas;
            this.esResidente = esResidente;
        }

        internal override string FichaExtra()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"¿Finalizo residencia? {this.esResidente}");
            sb.AppendLine($"ATENCIONES:");
            sb.AppendLine($"Edad: {this.consultas}");
            return sb.ToString();
        }
        public static Consulta operator +(PersonalMedico doctor, Paciente paciente)
        {
            Consulta consulta = new Consulta(DateTime.Now, paciente);

            doctor.consultas.Add(consulta);
            return consulta;

        }
    }
}
