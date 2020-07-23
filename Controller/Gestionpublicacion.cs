using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller
{
    public class Gestionpublicacion
    {
        public List<string> Listaridpublic()
        {
          List<string> idpubli = new List<string>();
          Gestion_publicacion publi = new Gestion_publicacion();
            idpubli = publi.ListarPublicacion();
            return idpubli;
        }
         
        public DataTable publicacionesasociadas(string publi)
        {
            DataTable table = new DataTable();
            Gestion_publicacion publica = new Gestion_publicacion();
            table = publica.Mostrar_publica(publi);
            return table;
        }

    }
}
