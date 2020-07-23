using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;

namespace Capa_view
{
    public partial class frmpublicacion : Form
    {
        public frmpublicacion()
        {
            InitializeComponent();
            Gestionpublicacion publi = new Gestionpublicacion();
            cbidpubli.DataSource = publi.Listaridpublic();
            dtpubli.Visible = false;
        }

        private void cbidpubli_SelectedIndexChanged(object sender, EventArgs e)
        {
            Gestionpublicacion publi = new Gestionpublicacion();
            string idpubli = cbidpubli.SelectedItem.ToString();
            dtpubli.DataSource = publi.publicacionesasociadas(idpubli);
            if(dtpubli != null)
            {
                dtpubli.Visible = true;
            }
            else
            {
                dtpubli.Visible = false;
            }
            
        }
    }
}
