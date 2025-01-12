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
}
public class ClienteController
{
    private string connectionString = "Server=localhost;Database=AlquilerEquiposDeportivos;Trusted_Connection=True;";

    public List<Cliente> ObtenerClientes()
    {
        var clientes = new List<Cliente>();
        using (var conn = new SqlConnection(connectionString))
        {
            conn.Open();
            using (var cmd = new SqlCommand("SELECT * FROM Clientes", conn))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        clientes.Add(new Cliente
                        {
                            ClienteID = reader.GetInt32(0),
                            Nombre = reader.GetString(1),
                            Apellido = reader.GetString(2),
                            Cedula = reader.GetString(3),
                            Telefono = reader.GetString(4)
                        });
                    }
                }
            }
        }
        return clientes;
    }

    public void AgregarCliente(Cliente cliente)
    {
        using (var conn = new SqlConnection(connectionString))
        {
            conn.Open();
            var sql = "INSERT INTO Clientes (Nombre, Apellido, Cedula, Telefono) VALUES (@nombre, @apellido, @cedula, @telefono)";
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@nombre", cliente.Nombre);
                cmd.Parameters.AddWithValue("@apellido", cliente.Apellido);
                cmd.Parameters.AddWithValue("@cedula", cliente.Cedula);
                cmd.Parameters.AddWithValue("@telefono", cliente.Telefono);
                cmd.ExecuteNonQuery();
            }
        }
    }
}