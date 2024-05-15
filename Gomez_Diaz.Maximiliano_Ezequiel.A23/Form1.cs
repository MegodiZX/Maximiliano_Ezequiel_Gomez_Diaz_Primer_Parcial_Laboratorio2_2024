using Biblioteca_Clases;
namespace Gomez_Diaz.Maximiliano_Ezequiel.A23
{
    public partial class FrmAtencion : Form
    {
        public FrmAtencion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lst_Medicos.SelectedItem == null || lst_Pacientes.SelectedItem == null)
            {
                DialogResult dialog = MessageBox.Show("Debe seleccionar un Medico y un Paciente para poder continuar.", "Error de los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dialog = MessageBox.Show("", "Atencion finalizada.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAtencion_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void FrmAtencion_Load(object sender, EventArgs e)
        {
            List<Consulta> consultas = new List<Consulta>();
            lst_Medicos.Items.Add(new PersonalMedico(consultas, "Gustavo", "Rivas", new DateTime(1999, 12, 12),false));
            lst_Medicos.Items.Add(new PersonalMedico(consultas,"Lautaro", "Galarza", new DateTime(1951, 11, 12), true));
            lst_Pacientes.Items.Add(new Paciente("Mathias", "Bustamante", new DateTime(1998, 6, 16), "Tigre", "Paciente curado"));
            lst_Pacientes.Items.Add(new Paciente("Lucas", "Ferrini", new DateTime(1989, 1, 21), "DF" , "Paciente curado"));
            lst_Pacientes.Items.Add(new Paciente("Lucas", "Rodriguez", new DateTime(1912, 12, 12), "LaBoca", "Paciente curado"));
            lst_Pacientes.Items.Add(new Paciente("John Jairo", "Trelles", new DateTime(1978, 8, 30), "Medellin", "Paciente curado"));
        }

        private void lst_Medicos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
