using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsychologyConsultation.Domain.Entities
{
    public class Consulta
    {
        public int? ConsultaID { get; set; } 
        public int PacienteID { get; set; }
        public DateTime FechaConsulta { get; set; } 
        public string Motivo { get; set; } = null!;

        public virtual Paciente Paciente { get; set; } = null!; // Relación con Paciente
    }

}
