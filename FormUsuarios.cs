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
    public partial class FormUsuarios : Form
    {
        bool editar; string ci;
        public FormUsuarios(Boolean editar_ = false, string ci_ = "0")
        {
            editar = editar_;
            ci = ci_;
            InitializeComponent();
        }
        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            if (editar)
            {
                foreach (Usuario item in PaginaPrincipal.listaUsuarios)
                {
                    if (item.ci == ci)
                    {
                        textBox1.Text = item.ci;
                        textBox2.Text = item.nombre;
                        textBox3.Text = item.apellidos;
                        textBox4.Text = item.celular;
                        textBox5.Text = item.correo;
                        comboBox2.SelectedItem = item.departamento;
                        if (item.sexo == "Hombre")
                        {
                            Hombre.Checked = true;
                            Mujer.Checked = false;
                        }
                        else
                        {
                            Hombre.Checked = false;
                            Mujer.Checked = true;
                        }
                        break;
                    }
                }
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

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (editar)
            {
                foreach(Usuario item in PaginaPrincipal.listaUsuarios)
                {
                    if(item.ci == ci)
                    {
                        item.ci = textBox1.Text;
                        item.nombre = textBox2.Text;
                        item.apellidos = textBox3.Text;
                        item.celular = textBox4.Text;
                        item.correo = textBox5.Text;
                        item.departamento = comboBox2.SelectedItem.ToString();
                        if (Hombre.Checked) item.sexo = "Hombre";
                        else item.sexo = "Mujer";
                        GuardarUsuario();
                        break;
                    }
                }
            }
            else
            {
                Usuario usuario = new Usuario();
                usuario.ci = textBox1.Text;
                usuario.nombre = textBox2.Text;
                usuario.apellidos = textBox3.Text;
                usuario.celular = textBox4.Text;
                usuario.correo = textBox5.Text;
                usuario.departamento = comboBox2.SelectedItem.ToString();
                if (Hombre.Checked) usuario.sexo = "Hombre";
                else usuario.sexo = "Mujer";
                PaginaPrincipal.listaUsuarios.Add(usuario);
                GuardarUsuario();
            }
        }
    }
}
