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
            {
                Form2 ventanaGrande = new Form2(this);
                ventanaGrande.Show();
                this.Hide();
            }
            else
                lbl_mensaje.Text = admin +": Error al ingresar sus datos";
        }
    }
}
