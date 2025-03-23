using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

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
            sqlCommand.CommandText = "select * from eventos where id_evento Like @busqueda";

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
        public List<Ventas> obtenerVenta(int GridSelectRow)
        {
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
                        ID = reader.GetInt32(0),
                        ID_Evento = reader.GetInt32(1),
                        Fecha = reader.GetDateTime(2),
                        tipo_boleto = reader.GetString(3),
                        cantidad = reader.GetInt32(4),
                        total = reader.GetInt32(5)
                    };
                    returnThese.Add(venta);
                }
                connection.Close();
                return returnThese;
            }
        }
        public List<string> eventoData(int GridSelectRow)
        {
            List<string> Data = new List<string>(new string[5]);
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
    }
}
