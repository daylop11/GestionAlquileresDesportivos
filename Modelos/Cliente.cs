﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAlquileresDesportivos.Modelos

public class Cliente
{
    public int ClienteID { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Cedula { get; set; }
    public string Telefono { get; set; }

    public override string ToString()
    {
        return $"{Nombre} {Apellido} - {Cedula}";
    }
}