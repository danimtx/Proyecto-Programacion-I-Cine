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
    public partial class Factura : Form
    {
        int codigoFactura;
        public Factura(int codigoFactura_)
        {
            codigoFactura = codigoFactura_;
            InitializeComponent();
        }

        private void Factura_Load(object sender, EventArgs e)
        {
            foreach (Facturas item in PaginaPrincipal.listaFacturas)
            {
                if(item.codigo == codigoFactura)
                {
                    fecha.Text = item.fecha;
                    ci.Text = "CI: " + item.ci;
                    usuario.Text = "Señor(es): " + item.señores;
                    pelicula.Text = "Pelicula: " + item.pelicula;
                    cantidad.Text = "Cantidad boletos: " + item.cantidad;
                    Precio_Unitario.Text = "Precio Unitario: " + item.Punitario.ToString();
                    Total.Text = "Total: " + item.total;
                    codigo.Text = "Codigo: " + item.codigo.ToString();
                    break;
                }
            }
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
