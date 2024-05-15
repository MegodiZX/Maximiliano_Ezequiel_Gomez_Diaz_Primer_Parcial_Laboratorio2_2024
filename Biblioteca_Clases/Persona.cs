using System.Text;

namespace Biblioteca_Clases
{
    public class Persona
    {
        protected string apellido;
        protected string barrioRecidencial;
        protected DateTime nacimiento;
        protected string nombre;
        public int Edad()
        {
            return DateTime.Today.AddTicks(-this.nacimiento.Ticks).Year - 1;

        }

        public string NombreCompleto()
        {
            return $"Apellido: {this.apellido} Nombre: {this.nombre}";
        }

        public Persona(string nombre, string apellido, DateTime nacimiento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacimiento = nacimiento;
            
        }
        public Persona(string nombre, string apellido, DateTime nacimiento,string barrioRecidencial)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacimiento = nacimiento;
            this.barrioRecidencial = barrioRecidencial;
        }

        public string ToString()
        {
            return NombreCompleto();
        }

        public string FichaPersonal(Persona p)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(p.ToString());
            sb.Append($"Edad: {p.Edad}");
            sb.Append($"{p.barrioRecidencial}");
            return sb.ToString();
        }
        virtual internal string FichaExtra()
        {
            return "";
        }

    }
}
