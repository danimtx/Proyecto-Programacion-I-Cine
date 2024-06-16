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
    public partial class ConfiUsuarios : Form
    {
        public ConfiUsuarios()
        {
            InitializeComponent();
            listarUsuarios();
        }

        private void Inicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void listarUsuarios()
        {
            dataGridView1.Rows.Clear();
            foreach (Usuario item in PaginaPrincipal.listaUsuarios)
            {
                dataGridView1.Rows.Add(item.ci,
                                       item.nombre,
                                       item.apellidos,
                                       item.celular,
                                       item.correo,
                                       item.departamento,
                                       item.sexo);
            }
        }
        void GuardarUsuario()
        {
            TextWriter escribir = new StreamWriter(PaginaPrincipal.UsuariosURL);
            escribir.Close();
            foreach (Usuario item in PaginaPrincipal.listaUsuarios)
            {
                StreamWriter agregar = File.AppendText(PaginaPrincipal.UsuariosURL);
                agregar.WriteLine(item.ci + "|" + item.nombre + "|" + item.apellidos + "|" + item.celular + "|" + item.correo + "|" + item.departamento + "|" + item.sexo);
                agregar.Close();
            }
        }
        private void Agregar_Usuario_Click(object sender, EventArgs e)
        {
            FormUsuarios fr = new FormUsuarios();
            if(fr.ShowDialog() == DialogResult.OK)
            {
                listarUsuarios();
            }
        }

        private void Editar_Usuario_Click(object sender, EventArgs e)
        {
            string ci = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            FormUsuarios fr = new FormUsuarios(true, ci);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                listarUsuarios();
            }
        }

        private void Eliminar_Usuario_Click(object sender, EventArgs e)
        {
            string ci = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            foreach (Usuario item in PaginaPrincipal.listaUsuarios)
            {
                if(item.ci == ci)
                {
                    PaginaPrincipal.listaUsuarios.Remove(item);
                    GuardarUsuario();
                    listarUsuarios();
                    break;
                }
            }
        }

        public static bool botonselec;
        private void Seleccionar_Click(object sender, EventArgs e)
        {
            Vender.ci = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Seleccionar.Visible = false;
        }

        private void ConfiUsuarios_Load(object sender, EventArgs e)
        {
            Seleccionar.Visible = botonselec;
        }
    }
}
