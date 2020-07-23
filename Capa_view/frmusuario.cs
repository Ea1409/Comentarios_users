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
    public partial class frmusuario : Form
    {
        
        public frmusuario()
        {
            InitializeComponent();
            Gestionusuario usuario = new Gestionusuario();
            cbnomuser.DataSource = usuario.Mostrarusuarios();
            dtusuario.Visible = false;
           
        }

        private void cbnomuser_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nomuser = cbnomuser.SelectedItem.ToString();
            Gestionusuario user = new Gestionusuario();
            int iduser = user.obteneriduser(nomuser);
            Gestionusuario user2 = new Gestionusuario();
            dtusuario.DataSource = user2.Publi_asociada_user(iduser);
            if (dtusuario == null)
            {
                dtusuario.Visible = false;
            }
            else
            {
                dtusuario.Visible = true;
            }
        }
    }
}
