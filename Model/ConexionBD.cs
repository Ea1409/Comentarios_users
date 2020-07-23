using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Model
{
    public class ConexionBD
    {
        SqlConnection connection; // esta variable em almacena la conexion a la base de datos 
        string mensaje = "";//esta variable em alacena el mensaje si se produce uan excepción

        public SqlConnection Conectar()
        {
            string strConexion = "Data Source=TIAS-PC;Initial Catalog=BD_comentarios;Integrated Security=True"; //esta cadena de conexcion me almacena la información necesaria para la conexión a la base de datos
            try
            {
                connection = new SqlConnection(strConexion);//inicializamos el constructor con argumentos de la clase SQLconection y le pasamos la cadena de conexion
                connection.Open();//abrimos la conexion a la base de datos
            }
            catch (SqlException s) //si se produce un error
            {
                mensaje = "se ha producido un error por " + s.Message; //capturelo y almacenemelo en la variable mensaje

            }

            return connection; //retorne la conexión
        }

      public void cerrar()
      {
            connection.Close();
      }

        public override string ToString()
        {
            return mensaje;
        }

    }
}
