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
    public partial class Frm_IniciarSesion : Form
    {
        public Frm_IniciarSesion()
        {
            InitializeComponent();
        }

        private void Frm_IniciarSesion_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cuenta = txt_cuenta.Text;
            string password = txt_password.Text;
            if (cuenta == "juan" && password == "7350917")
            {
                Frm_MenuGerente frm_MenuGerente = new Frm_MenuGerente();
                frm_MenuGerente.ShowDialog();
            }
            else 
                MessageBox.Show("Error! Este usuario no existe");
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Frm_Ingreso frm_Ingreso = new Frm_Ingreso();
            frm_Ingreso.ShowDialog();
        }
    }
}
