using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Model
{
   public class Gestion_publicacion
    {
        ConexionBD conexion = new ConexionBD(); //creamos un objeto de tipo ConexionBD
        SqlCommand command;//este objeto nos permitira realizar diferentes acciones (si queremos ejecutar una query  , un store procedure ...etc)
        SqlDataReader reader;// este obejto me permite leer los datos que retorne la base de datos
     
        public List<string> ListarPublicacion()
        {
            var sqlcon = conexion.Conectar();// esta variable me almacena la conexión;

            List<string> publi = new List<string>(); //creamos la lista

            command = new SqlCommand("listaridpublica", sqlcon);//le decimos que vamos a ejecutar un comando llamado listaruser y le pasamos la conexión
            command.CommandType = CommandType.StoredProcedure;//le decimos que el tipo d ecomando que va a ejecutar es un procedimeinto almacenado
            reader = command.ExecuteReader();//ejecute una lectura de los datos
            while (reader.Read())//miestras se lea algo
            {
                publi.Add(reader.GetString(0));//a la lista agregamos lo que lea en la posicion 0
            }
            if (publi != null)
            {
                return publi;
            }
            else
            {
                publi.Add("No hay publicaciones realizadas en la base de datos");
            }
            return publi;
        }

        public DataTable Mostrar_publica(string idpubli)
        {
            var sqlcon = conexion.Conectar();
            DataTable tabla = new DataTable();
            command = new SqlCommand("listarpubliasociadas", sqlcon);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idpublicacion", idpubli);
            reader = command.ExecuteReader();
            tabla.Load(reader);
            if (tabla != null)
            {
                return tabla;
            }
            else
            {
                tabla = null;

            }
            conexion.cerrar();
            return tabla;
        }

    }
}
