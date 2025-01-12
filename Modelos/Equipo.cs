using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAlquileresDesportivos.Modelos
{ }
public class Equipo
{
    public int EquipoID { get; set; }
    public string Nombre { get; set; }
    public string Categoria { get; set; }
    public string Estado { get; set; }
    public decimal PrecioPorDia { get; set; }

    public override string ToString()
    {
        return $"{Nombre} - {Categoria}";
    }
}