using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EjemploAplicacionVentana
{
    public partial class Form2 : Form
    {
        Form1 ventana_login;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Form1 v_login) {
            InitializeComponent();
            ventana_login = v_login;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ventana_login.Show();
            this.Hide();
            
        }
    }
}
