using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Entidades
{
     public static class PaqueteDAO
    {
        private static SqlCommand comando;
        private static SqlConnection conexion;

        public static bool Insertar(Paquete paquete)
        {
            comando.CommandText = "insert into dbo.Paquetes (direccionEntrega,trackingID,alumno) values ('" + paquete.DireccionEntrega + "','" + paquete.TrakingID + "','nicolas')";
            try
            {
                conexion.Open();
            }
            catch(Exception e)
            {
                throw new InvalidOperationException("error al conectarse a la base de datos");
            }
            
            try
            {
             comando.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                throw new InvalidCastException("Error al  insertar los datos");

            }
            finally
            {
                conexion.Close();
                
            }
            return true;
        }
          static PaqueteDAO()
        {
            conexion = new SqlConnection("Data Source=.\\MSSQLSERVER01;Initial Catalog=correo-sp-2017;Integrated Security=True");
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;

        }
    }
}
