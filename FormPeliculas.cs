using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProyectoCine
{
    public partial class FormPeliculas : Form
    {
        bool editar; string codigo;
        public FormPeliculas(bool editar_ = false, string codigo_ = "0")
        {
            editar = editar_;
            codigo = codigo_;
            InitializeComponent();
        }

        void Guardar()
        {
            TextWriter escribir = new StreamWriter(PaginaPrincipal.PeliculasURL);
            escribir.Close();
            foreach (Peliculas item in PaginaPrincipal.listaPeliculas)
            {
                StreamWriter agregar = File.AppendText(PaginaPrincipal.PeliculasURL);
                agregar.WriteLine(item.codigo + "|" + item.nombre + "|" + item.genero + "|" + item.duracion + "|" + item.protagonista + "|" + item.director + "|" + item.imagen + "|" + item.precio + "|" + item.mostrar);
                agregar.Close();
            }
        }

        int verificarEspacio()
        {
            int i = 0;
            foreach (Peliculas item in PaginaPrincipal.listaPeliculas)
            {
                if(item.mostrar )
                {
                    i++;
                }
            }
            return i;
        }

        private void FormPeliculas_Load(object sender, EventArgs e)
        {
            if (editar)
            {
                foreach (Peliculas item in PaginaPrincipal.listaPeliculas)
                {
                    if (item.codigo == codigo)
                    {
                        textBox1.Text = item.codigo;
                        textBox2.Text = item.nombre;
                        textBox3.Text = item.genero;
                        textBox4.Text = item.duracion;
                        textBox5.Text = item.protagonista;
                        textBox6.Text = item.director;
                        Seleccionar_Poster.Text = item.imagen;
                        textBox8.Text = item.precio.ToString();
                        if(item.mostrar == true)
                        {
                            radioButton1.Checked = true;
                            radioButton2.Checked = false;
                        }
                        else
                        {
                            radioButton2.Checked = true;
                            radioButton1 .Checked = false;
                        }
                        break;
                    }
                }
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (editar)
            {
                foreach (Peliculas item in PaginaPrincipal.listaPeliculas)
                {
                    if (item.codigo == codigo)
                    {
                        item.codigo = textBox1.Text;
                        item.nombre = textBox2.Text;
                        item.genero = textBox3.Text;
                        item.duracion = textBox4.Text;
                        item.protagonista = textBox5.Text;
                        item.director = textBox6.Text;
                        item.imagen = Seleccionar_Poster.Text;
                        item.precio = float.Parse(textBox8.Text);
                        if (radioButton1.Checked == false)
                        {
                            item.mostrar = false;
                        }
                        else
                        {
                            item.mostrar = true;
                        }
                        Guardar();
                        break;
                    }
                }
            }
            else
            {
                Peliculas peli = new Peliculas();
                peli.codigo = textBox1.Text;
                peli.nombre = textBox2.Text;
                peli.genero = textBox3.Text;
                peli.duracion = textBox4.Text;
                peli.protagonista = textBox5.Text;
                peli.director = textBox6.Text;
                peli.imagen = Seleccionar_Poster.Text;
                peli.precio = float.Parse(textBox8.Text);
                if (radioButton1.Checked == true) peli.mostrar = true;
                else peli.mostrar = false;
                PaginaPrincipal.listaPeliculas.Add(peli);
                Guardar();
            }
        }

        private void Seleccionar_Poster_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Seleccionar_Poster.Text = openFileDialog1.FileName;
            }
        }
    }
}
