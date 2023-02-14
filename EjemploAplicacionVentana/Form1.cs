using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploAplicacionVentana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void evento_click_boton_login(object sender, EventArgs e)
        {
            string user = txt_usuario.Text;
            string password = txt_password.Text;
            if (user.Equals("pepe") && password.Equals("abc"))
                lbl_mensaje.Text = "Bienvenido Pepe";
            else
                lbl_mensaje.Text = "Error al ingresar sus datos";
        }
    }
}
