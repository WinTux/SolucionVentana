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
        Stack<int> pila_numeros;
        Queue<Persona> cola_personas;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Form1 v_login) {
            InitializeComponent();
            ventana_login = v_login;
            lista_de_palabras = new List<string>();
            pila_numeros = new Stack<int>();// Last In, First Out (LIFO)
            cola_personas = new Queue<Persona>();
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

        private void button4_Click(object sender, EventArgs e)
        {
            pila_numeros.Push(int.Parse(txt_ingreso.Text));
            txt_ingreso.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lbl_elemento_pop.Text= pila_numeros.Pop().ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lbl_mostrar.Text = "";
            foreach (int elemento in pila_numeros)
                lbl_mostrar.Text += elemento + "\n";
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            cola_personas.Enqueue(
                new Persona(
                    txt_nombre.Text,
                    int.Parse(txt_edad.Text),
                    txt_direccion.Text)
            );
            mostrar_personas();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(cola_personas.Count > 0)
                lbl_mostrar_dequeue.Text = cola_personas.Dequeue() + "";
            mostrar_personas();
        }
        private void mostrar_personas() {
            lbl_mostrar_queue.Text = "";
            foreach (Persona elemento in cola_personas)
                lbl_mostrar_queue.Text += elemento + "\n";
        }
    }

    public class Persona {
        public string nombre, direccion;
        public int edad;
        public Persona(string nombre, int edad, string direccion) {
            this.nombre = nombre;
            this.edad = edad;
            this.direccion = direccion;
        }
        public override string ToString()
        {
            Math.Abs(123);
            Matematica.Absoluto(123);
            return $"Nombre: {nombre}; Edad: {edad}; Dir.: {direccion}";
        }
    }

    public class Matematica {
        public static Absoluto(int x) {
            if (x >= 0)
                return x;
            else
                return -x;
        }
    }

}
