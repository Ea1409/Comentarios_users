using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_view
{
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }
        private void Abrirform(object formulario)
        {
            if (panelconten.Controls.Count > 0)
            {
                this.panelconten.Controls.RemoveAt(0);
            }
            Form fh = formulario as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelconten.Controls.Add(fh);
            this.panelconten.Tag = fh;
            fh.Show();
        }

        private void btnuser_Click(object sender, EventArgs e)
        {
            Abrirform(new frmusuario());
        }

        private void btnpubli_Click(object sender, EventArgs e)
        {
            Abrirform(new frmpublicacion());
        }
    }
}
