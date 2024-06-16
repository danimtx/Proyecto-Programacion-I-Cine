using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCine
{
    public partial class Cartelera : Form
    {
        public Cartelera()
        {
            int i = 1;
            InitializeComponent();
            foreach(Peliculas item in PaginaPrincipal.listaPeliculas)
            {
                if (item.mostrar)
                {
                    mostrarCartelera(item.imagen, i);i++;
                }
            }
        }
        void mostrarCartelera(string direccion, int i)
        {
            if(i == 1)
            {
                pictureBox1.ImageLocation = direccion;
                pictureBox1.Visible = true;
            }
            else if(i == 2)
            {
                pictureBox2.ImageLocation = direccion;
                pictureBox2.Visible = true;
            }
            else if (i == 3)
            {
                pictureBox3.ImageLocation = direccion;
                pictureBox3.Visible = true;
            }
            else if (i == 4)
            {
                pictureBox4.ImageLocation = direccion;
                pictureBox4.Visible = true;
            }
            else if (i == 5)
            {
                pictureBox5.ImageLocation = direccion;
                pictureBox5.Visible = true;
            }
            else if (i == 6)
            {
                pictureBox6.ImageLocation = direccion;
                pictureBox6.Visible = true;
            }
            else if (i == 7)
            {
                pictureBox7.ImageLocation = direccion;
                pictureBox7.Visible = true;
            }
            else if (i == 8)
            {
                pictureBox8.ImageLocation = direccion;
                pictureBox8.Visible = true;
            }
            else if (i == 9)
            {
                pictureBox9.ImageLocation = direccion;
                pictureBox9.Visible = true;
            }
            else
            {
                pictureBox10.ImageLocation = direccion;
                pictureBox10.Visible = true;
            }
        }
    }
}
