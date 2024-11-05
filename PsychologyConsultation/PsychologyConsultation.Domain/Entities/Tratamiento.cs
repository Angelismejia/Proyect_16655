using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsychologyConsultation.Domain.Entities
{
    public class Tratamiento
    {
        public int TratamientoID { get; set; }
        public int ConsultaID { get; set; } 
        public string Descripcion { get; set; } = null!;
        public DateTime? FechaInicio { get; set; } 
        public DateTime? FechaFin { get; set; }
        public string Estado { get; set; } = null!;
        public virtual Consulta Consulta { get; set; } = null!; // Relación con Consulta
    }

}
