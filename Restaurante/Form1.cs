using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante
{
    public partial class Frm_Ingreso : Form
    {
        public Frm_Ingreso()
        {
            InitializeComponent();
        }

        private void btn_gerente_Click(object sender, EventArgs e)
        {
            Frm_IniciarSesion frm_IniciarSesion = new Frm_IniciarSesion();
            frm_IniciarSesion.ShowDialog();
        }
    }
}
