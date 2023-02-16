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
        List<string> lista_de_palabras;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Form1 v_login) {
            InitializeComponent();
            ventana_login = v_login;
            lista_de_palabras = new List<string>();
            
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ventana_login.Show();
            this.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lista_de_palabras.Add(txt_elemento.Text);
            txt_elemento.Text = "";
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt_salida.Text = "";
            //Necesito mostrar el/los elementos de la lista
            foreach (string val_auxiliar in lista_de_palabras) {
                txt_salida.Text += val_auxiliar + "\n";
            }
        }
    }
}
