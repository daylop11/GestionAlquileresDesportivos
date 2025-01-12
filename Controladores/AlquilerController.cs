using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionAlquileresDesportivos.Modelos;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace GestionAlquileresDesportivos.Controladores
{
    public class AlquilerController
{
    private string connectionString = "Server=localhost;Database=AlquilerEquiposDeportivos;Trusted_Connection=True;";

    public void CrearAlquiler(Alquiler alquiler)
    {
        using (var conn = new SqlConnection(connectionString))
        {
            conn.Open();
            var sql = @"INSERT INTO Alquileres (ClienteID, EquipoID, FechaInicio, FechaFin, PrecioTotal) 
                       VALUES (@clienteId, @equipoId, @fechaInicio, @fechaFin, @precioTotal)";
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@clienteId", alquiler.ClienteID);
                cmd.Parameters.AddWithValue("@equipoId", alquiler.EquipoID);
                cmd.Parameters.AddWithValue("@fechaInicio", alquiler.FechaInicio);
                cmd.Parameters.AddWithValue("@fechaFin", alquiler.FechaFin);
                cmd.Parameters.AddWithValue("@precioTotal", alquiler.PrecioTotal);
                cmd.ExecuteNonQuery();
            }
        }
    }

    public List<Alquiler> ObtenerAlquileres()
    {
        var alquileres = new List<Alquiler>();
        using (var conn = new SqlConnection(connectionString))
        {
            conn.Open();
            var sql = @"SELECT a.*, c.Nombre, c.Apellido, e.Nombre as EquipoNombre 
                       FROM Alquileres a 
                       INNER JOIN Clientes c ON a.ClienteID = c.ClienteID 
                       INNER JOIN Equipos e ON a.EquipoID = e.EquipoID";
            using (var cmd = new SqlCommand(sql, conn))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var alquiler = new Alquiler
                        {
                            AlquilerID = reader.GetInt32(0),
                            ClienteID = reader.GetInt32(1),
                            EquipoID = reader.GetInt32(2),
                            FechaInicio = reader.GetDateTime(3),
                            FechaFin = reader.GetDateTime(4),
                            PrecioTotal = reader.GetDecimal(5),
                            Cliente = new Cliente { Nombre = reader.GetString(6), Apellido = reader.GetString(7) },
                            Equipo = new Equipo { Nombre = reader.GetString(8) }
                        };
                        alquileres.Add(alquiler);
                    }
                }
            }
        }
        return alquileres;
    }
}