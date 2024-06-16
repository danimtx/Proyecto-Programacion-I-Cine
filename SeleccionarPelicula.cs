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
    public partial class SeleccionarPelicula : Form
    {
        public SeleccionarPelicula()
        {
            InitializeComponent();
        }

        private void SeleccionarPelicula_Load(object sender, EventArgs e)
        {
            foreach (Peliculas item in PaginaPrincipal.listaPeliculas)
            {
                if (item.mostrar)
                {
                    dataGridView1.Rows.Add(item.codigo,
                                           item.nombre);
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Vender.codigo = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
