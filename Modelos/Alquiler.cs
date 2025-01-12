using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAlquileresDesportivos.Modelos
{
    public class Alquiler
    {
        public int AlquilerID { get; set; }
        public int ClienteID { get; set; }
        public int EquipoID { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public decimal PrecioTotal { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual Equipo Equipo { get; set; }
    }
