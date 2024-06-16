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
    public partial class Vender : Form
    {
        public Vender()
        {
            InitializeComponent();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblHora.Text = DateTime.Now.ToString("HH:mm");
        }

        public static string ci = "";
        private void button7_Click(object sender, EventArgs e)
        {
            ConfiUsuarios fr = new ConfiUsuarios();
            ConfiUsuarios.botonselec = true;
            if (fr.ShowDialog() == DialogResult.OK)
            {
                foreach (Usuario item in PaginaPrincipal.listaUsuarios)
                {
                    if (item.ci == ci)
                    {
                        textBox1.Text = item.nombre + " " + item.apellidos;
                        recuperarCI = item.ci;
                        break;
                    }
                }
            }
        }

        public static string codigo = "";
        float precio = 1;
        private void button4_Click(object sender, EventArgs e)
        {
            SeleccionarPelicula fr = new SeleccionarPelicula();
            if(fr.ShowDialog() == DialogResult.OK)
            {
                foreach (Peliculas item in PaginaPrincipal.listaPeliculas)
                {
                    if(item.codigo == codigo)
                    {
                        button4.Text = item.nombre;
                        precio = item.precio;
                        costo.Text = item.precio.ToString();
                        comboBox1.Text = "1";
                        pictureBox1.ImageLocation = item.imagen;
                        pictureBox1.Visible = true;
                        RecuperarPrecioUnitario = item.precio;
                        break;
                    }
                }
            }
            if (Codigo.Text == "") {
                Random random = new Random();
                Codigo.Text = random.Next(0, 10000).ToString();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int d = int.Parse(comboBox1.SelectedItem.ToString());
            costo.Text = (d * precio).ToString();
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

        public static string recuperarCI = "No registrado";
        public static float RecuperarPrecioUnitario;

        private void button11_Click(object sender, EventArgs e)
        {
            Ventas venta = new Ventas();
            venta.codigo = int.Parse(Codigo.Text);
            venta.Peliculas = button4.Text;
            venta.usuario = textBox1.Text;
            venta.cantidadBoletos = comboBox1.SelectedItem.ToString();
            venta.Total = float.Parse(costo.Text);
            venta.departamento = comboBox2.SelectedItem.ToString();
            venta.fecha = lblfecha.Text;
            venta.hora = lblHora.Text;
            venta.sala = textBox2.Text;
            venta.butaca = textBox3.Text;
            PaginaPrincipal.listaVentas.Add(venta);
            GuardarVenta();

            Facturas facturas = new Facturas();
            facturas.codigo = int.Parse(Codigo.Text);
            facturas.fecha = "Fecha: " + lblfecha.Text + " - Hora: " + lblHora.Text;
            facturas.ci = recuperarCI;
            facturas.señores = textBox1.Text;
            facturas.pelicula = button4.Text;
            facturas.cantidad = comboBox1.SelectedItem.ToString();
            facturas.Punitario = RecuperarPrecioUnitario;
            facturas.total = costo.Text;
            PaginaPrincipal.listaFacturas.Add(facturas);
            GuardarFactura();

            Factura fr = new Factura(facturas.codigo);
            fr.Show();

            textBox1.Text = "";
            button4.Text = "Seleccionar pelicula";
            comboBox1.Text = "---";
            costo.Text = "";
            comboBox2.Text = "Tarija";
            textBox2.Text = "";
            textBox3.Text = "";
            Codigo.Text = "";
            pictureBox1.Visible = false;
            recuperarCI = "No registrado";
        }
    }
}
