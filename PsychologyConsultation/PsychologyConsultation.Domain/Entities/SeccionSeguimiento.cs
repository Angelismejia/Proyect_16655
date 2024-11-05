using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsychologyConsultation.Domain.Entities
{
    public class SesionSeguimiento
    {
        public int SesionID { get; set; }
        public int TratamientoID { get; set; }
        public DateTime FechaSesion { get; set; }
        public string Notas { get; set; } = null!;

        public virtual Tratamiento Tratamiento { get; set; } = null!; // Relación con Tratamiento
    }

}
