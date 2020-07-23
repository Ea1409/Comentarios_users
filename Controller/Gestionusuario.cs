using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;


namespace Controller
{
    public class Gestionusuario
    {
       

        public List<string> Mostrarusuarios()
        {
            GestionUser user = new GestionUser();
            List<string> usuario = new List<string>();
            usuario = user.Listaruser();

            return usuario;

        }

        public int obteneriduser(string nomuser)
        {
            GestionUser user = new GestionUser();
            int iduser = user.retornaridusuario(nomuser);
            return iduser;
        }

        public DataTable Publi_asociada_user(int iduser)
        {
            GestionUser user = new GestionUser();
            DataTable table = new DataTable();
            table = user.Mostrar_publica_usuarios(iduser);
            return table;
        }
    }
}
