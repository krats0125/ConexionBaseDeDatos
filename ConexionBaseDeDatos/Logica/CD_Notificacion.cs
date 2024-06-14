using ConexionBaseDeDatos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tomapedidos.Modelos;

namespace Tomapedidos.Logica
{
    public class CD_Notificacion
    {
        // para usar este repositorio es necesario que se use el id del asesor.

        // esto se va a usar con el fin de que cada asesor cuando ingrese reciba la misma informacion que todos. y garantiza su lectura



        //Cargar Notificaciones No Leídas
        public List<Notificacion> TraerNotificaciones(int idCliente)
        {
            List<Notificacion> notifications = new List<Notificacion>();

            CONEXION conexion = new CONEXION();

            using (var connection = new SqlConnection(conexion.ConexionAzure()))
            {
                connection.Open();
                string query = @"
                                SELECT n.IdNotification, n.Mensaje, n.FechaCreacion
                                FROM Notificacion n
                                WHERE n.IdNotificacion NOT IN (
                                    SELECT rn.IdNotificacion
                                    FROM NotificacionLeida nl
                                    WHERE nl.IdCliente = @IdCliente
                                )";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdCliente", idCliente);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            notifications.Add(new Notificacion
                            {
                                IdNotifcacion = reader.GetInt32(0),
                                Mensaje = reader.GetString(1),
                                FechaCreacion = reader.GetDateTime(2)
                            });
                        }
                    }
                }
            }
            return notifications;
        }


        public void MarcarNotificacionLeida(int IdUsuario, int idNotificacion)
        {

            CONEXION conexion = new CONEXION();

            using (var connection = new SqlConnection(conexion.ConexionAzure()))
            {
                connection.Open();
                string query = @"
                    INSERT INTO NotificacionLeida (IdUsuario, IdNotificacion, FechaLeido)
                    VALUES (@IdUsuario, @IdNotificacion, @FechaLeido)";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdUsuario", IdUsuario);
                    command.Parameters.AddWithValue("@IdNotificacion", idNotificacion);
                    command.Parameters.AddWithValue("@FechaLeido", DateTime.Now);

                    command.ExecuteNonQuery();
                }
            }
        }

        /*
         Uso dentro de la aplicacion

                public void DisplayUnreadNotifications(int userId)
                {
                    var notifications = TraerNotificaciones(userId);

                    foreach (var notification in notifications)
                    {
                        Console.WriteLine($"{notification.Message} (Received on: {notification.CreatedDate})");
                    }
                }
        //________________________________
                public void ReadNotification(int userId, int notificationId)
                {
                    MarkNotificationAsRead(userId, notificationId);
                    Console.WriteLine("Notification marked as read.");
                }
         
         */

    }
}
