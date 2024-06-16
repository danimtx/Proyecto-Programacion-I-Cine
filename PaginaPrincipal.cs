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
    public partial class PaginaPrincipal : Form
    {
        public PaginaPrincipal()
        {
            cargarPelisBD();
            cargarUsuariosBD();
            cargarVentas();
            cargarFacuras();
            InitializeComponent();
        }

        public static List<Peliculas> listaPeliculas = new List<Peliculas>();
        public static List<Usuario> listaUsuarios = new List<Usuario>();
        public static List<Ventas> listaVentas = new List<Ventas>();
        public static List<Facturas> listaFacturas = new List<Facturas>();
        public static string PeliculasURL = "C:\\ooo\\Peliculas.txt";
        public static string UsuariosURL = "C:\\ooo\\Usuarios.txt";
        public static string VentasURL = "C:\\ooo\\Ventas.txt";
        public static string FacturasURL = "C:\\ooo\\Facturas.txt";

        void cargarPelisBD()
        {
            StreamReader leer = new StreamReader(PeliculasURL);
            string linea;
            while ((linea = leer.ReadLine()) != null)
            {
                string[] datos = linea.Split('|');
                Peliculas peli = new Peliculas();
                peli.codigo = datos[0];
                peli.nombre = datos[1];
                peli.genero = datos[2];
                peli.duracion = datos[3];
                peli.protagonista = datos[4];
                peli.director = datos[5];
                peli.imagen = datos[6];
                peli.precio = float.Parse(datos[7]);
                if (datos[8] == "True") peli.mostrar = true;
                else peli.mostrar = false;
                listaPeliculas.Add(peli);
            }
            leer.Close();
        }

        void cargarUsuariosBD()
        {
            StreamReader leer = new StreamReader(UsuariosURL);
            string linea;
            while ((linea = leer.ReadLine()) != null)
            {
                string[] datos = linea.Split('|');
                Usuario usuario = new Usuario();
                usuario.ci = datos[0];
                usuario.nombre = datos[1];
                usuario.apellidos = datos[2];
                usuario.celular = datos[3];
                usuario.correo = datos[4];
                usuario.departamento = datos[5];
                usuario.sexo = datos[6];
                listaUsuarios.Add(usuario);
            }
            leer.Close();
        }
        void cargarVentas()
        {
            StreamReader leer = new StreamReader(VentasURL);
            string linea;
            while ((linea = leer.ReadLine()) != null)
            {
                string[] datos = linea.Split('|');
                Ventas venta = new Ventas();
                venta.codigo = int.Parse(datos[0]);
                venta.Peliculas = datos[1];
                venta.usuario = datos[2];
                venta.cantidadBoletos = datos[3];
                venta.Total = float.Parse(datos[4]);
                venta.departamento = datos[5];
                venta.fecha = datos[6];
                venta.hora = datos[7];
                venta.sala = datos[8];
                venta.butaca = datos[9];
                listaVentas.Add(venta);
            }
            leer.Close();
        }
        void cargarFacuras()
        {
            StreamReader leer = new StreamReader(FacturasURL);
            string linea;
            while ((linea = leer.ReadLine()) != null)
            {
                string[] datos = linea.Split('|');
                Facturas factura = new Facturas();
                factura.codigo = int.Parse(datos[0]);
                factura.fecha = datos[1];
                factura.ci = datos[2];
                factura.señores = datos[3];
                factura.pelicula = datos[4];
                factura.cantidad = datos[5];
                factura.Punitario = float.Parse(datos[6]);
                factura.total = datos[7];
                listaFacturas.Add(factura);
            }
            leer.Close();
        }

        private void PaginaPrincipal_Load(object sender, EventArgs e)
        {
            //ruta logo
            //pictureBox1.ImageLocation = "E:\\cine\\opcion22.png";
            //pictureBox2.ImageLocation = "E:\\cine\\opcion22.png";
        }

        private void Peliculas_Click(object sender, EventArgs e)
        {
            if (panelAdmin.Visible == false)
            {
                panelAdmin.Visible = true;
                panelConfiguracion.Visible = false;
            }
            else
                panelAdmin.Visible = false;
        }

        private void Ventas_Click(object sender, EventArgs e)
        {
            if (panelConfiguracion.Visible == false)
            {
                panelConfiguracion.Visible = true;
                panelAdmin.Visible = false;
            }
            else
                panelConfiguracion.Visible = false;
        }
        private void Ver_Cartelera_Click(object sender, EventArgs e)
        {
            Cartelera fr = new Cartelera();
            mostrarFormularioHijo(fr);
        }
        
        Form activarForm = null;
        void mostrarFormularioHijo(Form formHijo, bool borrar = true)
        {
            if (borrar) {
                if (activarForm != null)
                    activarForm.Close();
            }
            activarForm = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            panelFormularioHijo.Controls.Add(formHijo);
            panelFormularioHijo.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }

        private void Listar_Peliculas_Click(object sender, EventArgs e)
        {
            ConfiPeliculas fr = new ConfiPeliculas();
            mostrarFormularioHijo(fr);
        }

        private void Configuracion_Usuarios_Click(object sender, EventArgs e)
        {
            ConfiUsuarios fr = new ConfiUsuarios();
            ConfiUsuarios.botonselec = false;
            mostrarFormularioHijo(fr);
            panelAdmin.Visible = false;
            panelConfiguracion.Visible = false;
        }

        private void Vender_Click(object sender, EventArgs e)
        {
            Vender fr = new Vender();
            mostrarFormularioHijo(fr);
        }

        private void Listar_Ventas_Click(object sender, EventArgs e)
        {
            ConfiVentas fr = new ConfiVentas();
            mostrarFormularioHijo(fr);
        }
    }
}

