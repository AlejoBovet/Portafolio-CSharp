using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient; 

namespace AccesosDatos.DataBase
{
    public class ClasDataBase
    {
            private string connectionString;
            private SqlConnection connection;

            public ClasDataBase(string connectionString)
            {
                this.connectionString = connectionString;
                this.connection = new SqlConnection(connectionString);
            }

            // Abrir conexión
            public void Open()
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                    Console.WriteLine("Conexión abierta.");
                }
            }

            // Cerrar conexión
            public void Close()
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                    Console.WriteLine("Conexión cerrada.");
                }
            }

            // Ejecutar una consulta SELECT de ejemplo
            public void ExecuteSelect(string query)
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"Primera columna: {reader[0]}");
                    }
                }
            }

            // Devuelve la conexión por si quieres usarla desde afuera
            public SqlConnection GetConnection()
            {
                return connection;
            }
        }
}
