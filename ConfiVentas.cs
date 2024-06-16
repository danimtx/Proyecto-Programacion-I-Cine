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
    public partial class ConfiVentas : Form
    {
        public ConfiVentas()
        {
            InitializeComponent();
            listarVentas();
        }

        void listarVentas()
        {
            dataGridView1.Rows.Clear();
            foreach (Ventas item in PaginaPrincipal.listaVentas)
            {
                dataGridView1.Rows.Add(item.codigo,
                                       item.usuario,
                                       item.Peliculas,
                                       item.cantidadBoletos,
                                       item.departamento,
                                       item.fecha,
                                       item.hora,
                                       item.sala,
                                       item.butaca,
                                       item.Total);
            }
        }
        void GuardarVenta()
        {
            TextWriter escribir = new StreamWriter(PaginaPrincipal.VentasURL);
            escribir.Close();
            foreach (Ventas item in PaginaPrincipal.listaVentas)
            {
                StreamWriter agregar = File.AppendText(PaginaPrincipal.VentasURL);
                agregar.WriteLine(item.codigo + "|" + item.Peliculas + "|" + item.usuario + "|" + item.cantidadBoletos + "|" + item.Total + "|" + item.departamento
                    + "|" + item.fecha + "|" + item.hora + "|" + item.sala + "|" + item.butaca);
                agregar.Close();
            }
        }
        void GuardarFactura()
        {
            TextWriter escribir = new StreamWriter(PaginaPrincipal.FacturasURL);
            escribir.Close();
            foreach (Facturas item in PaginaPrincipal.listaFacturas)
            {
                StreamWriter agregar = File.AppendText(PaginaPrincipal.FacturasURL);
                agregar.WriteLine(item.codigo + "|" + item.fecha + "|" + item.ci + "|" + item.señores + "|" + item.pelicula + "|" + item.cantidad
                    + "|" + item.Punitario + "|" + item.total);
                agregar.Close();
            }
        }

        private void Inicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            foreach (Ventas item in PaginaPrincipal.listaVentas)
            {
                if(item.codigo == codigo)
                {
                    PaginaPrincipal.listaVentas.Remove(item);
                    GuardarVenta();
                    listarVentas();
                    break;
                }
            }
            foreach (Facturas item in PaginaPrincipal.listaFacturas)
            {
                if(item.codigo == codigo)
                {
                    PaginaPrincipal.listaFacturas.Remove(item);
                    GuardarFactura();
                    break;
                }
            }
        }

        private void Factura_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Factura fr = new Factura(codigo);
            fr.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            var resultados = PaginaPrincipal.listaVentas.Where(x => x.fecha.Contains(textBox1.Text));
            foreach (Ventas item in resultados)
            {
                dataGridView1.Rows.Add(item.codigo,
                                           item.usuario,
                                           item.Peliculas,
                                           item.cantidadBoletos,
                                           item.departamento,
                                           item.fecha,
                                           item.hora,
                                           item.sala,
                                           item.butaca,
                                           item.Total);
            }
        }
    }
}
