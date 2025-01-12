using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
namespace GestionAlquileresDesportivos.Controladores
{ }
    public class EquipoController
    {
        private string connectionString = "Server=localhost;Database=AlquilerEquiposDeportivos;Trusted_Connection=True;";

        public List<Equipo> ObtenerEquipos()
        {
            var equipos = new List<Equipo>();
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand("SELECT * FROM Equipos", conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            equipos.Add(new Equipo
                            {
                                EquipoID = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
                                Categoria = reader.GetString(2),
                                Estado = reader.GetString(3),
                                PrecioPorDia = reader.GetDecimal(4)
                            });
                        }
                    }
                }
            }
            return equipos;
        }

        public void AgregarEquipo(Equipo equipo)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var sql = "INSERT INTO Equipos (Nombre, Categoria, Estado, PrecioPorDia) VALUES (@nombre, @categoria, @estado, @precioPorDia)";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", equipo.Nombre);
                    cmd.Parameters.AddWithValue("@categoria", equipo.Categoria);
                    cmd.Parameters.AddWithValue("@estado", equipo.Estado);
                    cmd.Parameters.AddWithValue("@precioPorDia", equipo.PrecioPorDia);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }