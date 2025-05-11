using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Security.Principal;

namespace DSE
{
    internal class DSE_DAO
    {

        public string conexionString = "server=DESKTOP-UVOMFLN\\SQLEXPRESS;Database=dkan;Trusted_Connection=true;MultipleActiveResultSets=true;TrustServerCertificate=true";

        // Obtiene una consulta general de todas las ventas 
        public (List<eventos>, List<int>) obtenerEvento()
        {
            List<int> ID = new List<int>();
            List<eventos> returnThese = new List<eventos>();
            SqlConnection connection = new SqlConnection(conexionString);
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("select * from eventos", connection);

            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    eventos evento = new eventos()
                    {
                        id_evento = reader.GetInt32(0),
                        nombre = reader.GetString(1),
                        fecha = reader.GetDateTime(2),
                        lugar = reader.GetString(3),
                        hora = reader.GetTimeSpan(4),
                        precio_preventa = reader.GetInt32(5),
                        precio_taquilla = reader.GetInt32(6),
                        capacidad_personas = reader.GetInt32(7)
                    };
                    ID.Add(evento.id_evento);
                    returnThese.Add(evento);
                }
                connection.Close();
                return (returnThese, ID);
            }
        }

        // regresa una lista con la busqueda y la informacion de ventas 
        public (List<eventos>, List<int>) Buscar(string ID_evento)
        {
            List<eventos> returnThese = new List<eventos>();
            List<int> ID = new List<int>();
            string busqueda = "%" + ID_evento + "%";
            SqlConnection connection = new SqlConnection(conexionString);
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Parameters.AddWithValue("@busqueda", busqueda);
            sqlCommand.CommandText = "select * from eventos where nombre Like @busqueda";

            sqlCommand.Connection = connection;

            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    eventos evento = new eventos()
                    {
                        id_evento = reader.GetInt32(0),
                        nombre = reader.GetString(1),
                        fecha = reader.GetDateTime(2),
                        lugar = reader.GetString(3),
                        hora = reader.GetTimeSpan(4),
                        precio_preventa = reader.GetInt32(5),
                        precio_taquilla = reader.GetInt32(6),
                        capacidad_personas = reader.GetInt32(7)
                    };
                    ID.Add(evento.id_evento);
                    returnThese.Add(evento);
                }

                connection.Close();
                return (returnThese, ID);
            }
        }
        public (string, string) total(int GridSelectRow)
        {
            int total = 0;
            int cantidad = 0;
            string res;
            string res2;
            SqlConnection connection = new SqlConnection(conexionString);
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("select * from ventas Where id_evento = @GridSelectRow", connection);
            sqlCommand.Parameters.AddWithValue("@GridSelectRow", GridSelectRow);
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    cantidad += reader.GetInt32(4);
                    total += reader.GetInt32(5);

                }
                res = Convert.ToString(total);
                res2 = Convert.ToString(cantidad);
                connection.Close();
                return (res, res2);
            }
        }
        public (List<Ventas>, List<string>) obtenerVenta(int GridSelectRow)
        {
            List<string> indexVenta = new List<string>();
            List<Ventas> returnThese = new List<Ventas>();
            SqlConnection connection = new SqlConnection(conexionString);
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("select * from ventas Where id_evento = @GridSelectRow", connection);
            sqlCommand.Parameters.AddWithValue("@GridSelectRow", GridSelectRow);
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    Ventas venta = new Ventas()
                    {
                        ID = reader.GetString(0),
                        ID_Evento = reader.GetInt32(1),
                        Fecha = reader.GetDateTime(2),
                        tipo_boleto = reader.GetString(3),
                        cantidad = reader.GetInt32(4),
                        total = reader.GetInt32(5)

                    };
                    returnThese.Add(venta);
                    indexVenta.Add(reader.GetString(0));
                }
                connection.Close();
                return (returnThese, indexVenta) ;
            }
        }
        public List<string> eventoData(int GridSelectRow)
        {
            List<string> Data = new List<string>(new string[6]);
            SqlConnection connection = new SqlConnection(conexionString);
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("select * from eventos where id_evento = @GridSelectRow", connection);
            sqlCommand.Parameters.AddWithValue("@GridSelectRow", GridSelectRow);



            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    Data[0] = Convert.ToString(reader.GetInt32(0));
                    Data[1] = reader.GetString(1);
                    Data[2] = Convert.ToString(reader.GetInt32(5));
                    Data[3] = Convert.ToString(reader.GetInt32(6));
                    Data[4] = Convert.ToString(reader.GetInt32(7));
                    DateTime fecha = (reader.GetDateTime(2));
                    Data[5] = fecha.ToString("dd/MM/yyyy");

                }
                connection.Close();
            }
            return Data;
        }
        public void insertarEvento(eventos evento)
        {
            List<string> Data = new List<string>(new string[5]);
            SqlConnection connection = new SqlConnection(conexionString);
            connection.Open();
            
            
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO eventos VALUES (@IdEvento, @Nombre, @Fecha, @Lugar, @Hora, @Precio_preventa, @Precio_taquilla, @Capacidad_personas);", connection);

                sqlCommand.Parameters.AddWithValue("@IdEvento", evento.id_evento);
                sqlCommand.Parameters.AddWithValue("@Nombre", evento.nombre);
                sqlCommand.Parameters.AddWithValue("@Fecha", evento.fecha);
                sqlCommand.Parameters.AddWithValue("@Lugar", evento.lugar);
                sqlCommand.Parameters.AddWithValue("@Hora", evento.hora);
                sqlCommand.Parameters.AddWithValue("@Precio_preventa", evento.precio_preventa);
                sqlCommand.Parameters.AddWithValue("@Precio_taquilla", evento.precio_taquilla);
                sqlCommand.Parameters.AddWithValue("@Capacidad_personas", evento.capacidad_personas);

                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Los datos se han insertado correctamente.", "Éxito");
                connection.Close();
        }
        public void insertarVenta(Ventas venta)
        {
            List<string> Data = new List<string>(new string[5]);
            SqlConnection connection = new SqlConnection(conexionString);
            string checkCapacityQuery = "SELECT capacidad_personas FROM eventos WHERE id_evento = @idPrincipal";
            connection.Open();

            SqlCommand sqlCommand = new SqlCommand(
                "INSERT INTO ventas VALUES (@ID, @ID_Evento, @Fecha, @tipo_boleto, @cantidad, @total);", connection);
            SqlCommand sqlCommandUpdate = new SqlCommand("UPDATE eventos SET capacidad_personas = capacidad_personas - @cantidad  WHERE id_evento = @idPrincipal", connection);

            // Agregar los parámetros con los valores del objeto 'venta'
            sqlCommand.Parameters.AddWithValue("@ID", venta.ID);
            sqlCommand.Parameters.AddWithValue("@ID_Evento", venta.ID_Evento);
            sqlCommand.Parameters.AddWithValue("@Fecha", venta.Fecha);
            sqlCommand.Parameters.AddWithValue("@tipo_boleto", venta.tipo_boleto);
            sqlCommand.Parameters.AddWithValue("@cantidad", venta.cantidad);
            sqlCommand.Parameters.AddWithValue("@total", venta.total);
            sqlCommandUpdate.Parameters.AddWithValue("@idPrincipal", venta.ID_Evento);
            sqlCommandUpdate.Parameters.AddWithValue("@cantidad", venta.cantidad);

            using (SqlCommand checkCommand = new SqlCommand(checkCapacityQuery, connection))
            {
                checkCommand.Parameters.AddWithValue("@idPrincipal", venta.ID_Evento);
                int capacidad = Convert.ToInt32(checkCommand.ExecuteScalar());

                if (capacidad >= venta.cantidad)
                {
                    sqlCommandUpdate.ExecuteNonQuery();
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Los datos se han insertado correctamente.", "Éxito");
                }
                else
                {
                    MessageBox.Show("ERROR: Capacidad insuficiente. No se puede generar la venta." + capacidad);
                }
            }



            connection.Close();
        }
        public String ObtenerIDVenta(string Id_evento)
        {

            string query = "SELECT MAX(id_venta) FROM ventas WHERE id_evento = @idPrincipal";
            SqlConnection connection = new SqlConnection(conexionString);



            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@idPrincipal", Id_evento);
                object result = command.ExecuteScalar();
                

                if (result == DBNull.Value)
                {
                    return Convert.ToString(Convert.ToInt32( Id_evento ) * 10000 + 1);  // El primer ID secundario para este ID principal
                }
                else
                {
                    // De lo contrario, sumamos 1 al ID secundario máximo encontrado
                    return Convert.ToString(Convert.ToInt32(result) + 1);
                }
                
            }
        }
        public void borrar_venta(string id_venta)
        {
            SqlConnection connection = new SqlConnection(conexionString);
            connection.Open();


            SqlCommand sqlCommand = new SqlCommand("DELETE FROM ventas WHERE id_venta = @idventa;", connection);

            // Agregar los parámetros con los valores del objeto 'venta'
            sqlCommand.Parameters.AddWithValue("@idventa", id_venta);
            MessageBox.Show("id_venta", "Éxito");

            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Los datos se han borrado correctamente.", "Éxito");
            connection.Close();
        }
        public void borrar_evento(int id_evento)
        {
            SqlConnection connection = new SqlConnection(conexionString);
            connection.Open();


            SqlCommand sqlCommand = new SqlCommand("DELETE FROM eventos WHERE id_evento = @id_evento;", connection);

            SqlCommand sqlCommandBorrarTabla = new SqlCommand("DELETE FROM ventas WHERE id_evento = @id_evento;", connection);

            // Agregar los parámetros con los valores del objeto 'venta'
            sqlCommand.Parameters.AddWithValue("@id_evento", id_evento);
            sqlCommandBorrarTabla.Parameters.AddWithValue("@id_evento", id_evento);

            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Los datos se han borrado correctamente.", "Éxito");
            sqlCommandBorrarTabla.ExecuteNonQuery();
            connection.Close();
        }
    }
}
