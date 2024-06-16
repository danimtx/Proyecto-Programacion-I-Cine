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
    public partial class ConfiPeliculas : Form
    {
        public ConfiPeliculas()
        {
            InitializeComponent();
            listar();
        }

        private void Inicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void GuardarPelicula()
        {
            TextWriter escribir = new StreamWriter(PaginaPrincipal.PeliculasURL);
            escribir.Close();
            foreach (Peliculas item in PaginaPrincipal.listaPeliculas)
            {
                StreamWriter agregar = File.AppendText(PaginaPrincipal.PeliculasURL);
                agregar.WriteLine(item.codigo + "|" + item.nombre + "|" + item.genero + "|" + item.duracion + "|" + item.protagonista + "|" + item.director + "|" + item.imagen + "|"+ item.precio + "|" +item.mostrar);
                agregar.Close();
            }
        }

        void listar()
        {
            dataGridView1.Rows.Clear();
            foreach (Peliculas item in PaginaPrincipal.listaPeliculas)
            {
                dataGridView1.Rows.Add(item.codigo,
                                       item.nombre,
                                       item.genero,
                                       item.duracion,
                                       item.protagonista,
                                       item.director,
                                       item.precio);
            }
        }

        private void Agregar_Pelicula_Click(object sender, EventArgs e)
        {
            FormPeliculas fr = new FormPeliculas();
            if(fr.ShowDialog() == DialogResult.OK)
            {
                listar();
            }
        }

        private void Editar_Pelicula_Click(object sender, EventArgs e)
        {
            string codigo = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            FormPeliculas fr = new FormPeliculas(true, codigo);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                listar();
            }
        }

        private void Eliminar_Pelicula_Click(object sender, EventArgs e)
        {
            string codigo = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            DialogResult dialogo = MessageBox.Show("Esta seguro de eliminar esta Pelicula", "Eliminando. . .", MessageBoxButtons.YesNo);
            if (dialogo == DialogResult.Yes)
            {
                foreach (Peliculas item in PaginaPrincipal.listaPeliculas)
                {
                    if (item.codigo == codigo)
                    {
                        PaginaPrincipal.listaPeliculas.Remove(item);
                        GuardarPelicula();
                        listar();
                        break;
                    }
                }
            }
        }
    }
}
