using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calificaciones
{
    public partial class Form1 : Form
    {
        Lista miLista;
        ListaCalificaciones listas;
        public Form1()
        {
            InitializeComponent();
            miLista = new Lista();
            listas = new ListaCalificaciones();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = int.Parse(txtNumero.Text);
                string nombre = txtNombre.Text;
                string apellidoP = txtApellidoP.Text;
                string apellidoM = txtApellidoM.Text;
                string carrera = txtCarrera.Text;
                Nodo n = new Nodo(numero, nombre, apellidoP, apellidoM, carrera, null);
                miLista.Agregar(n);
                txtNombre.Clear();
                txtApellidoP.Clear();
                txtApellidoM.Clear();
                txtCarrera.Clear();
                txtNumero.Focus();
                miLista.Mostrar(lstLista);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = int.Parse(txtNumero.Text);
                miLista.Eliminar(numero);
                listas.EliminarCalificaciones(numero);
                txtNombre.Clear();
                txtApellidoP.Clear();
                txtApellidoM.Clear();
                txtCarrera.Clear();
                txtNumero.Focus();
                miLista.Mostrar(lstLista);
                listas.MostrarCalificaciones(lsvLista);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = int.Parse(txtNumero.Text);
                Nodo b = new Nodo();
                if (miLista.Buscar(numero, ref b))
                {
                    txtNombre.Text = b.Nombre;
                    txtApellidoP.Text = b.Apellidopaterno;
                    txtApellidoM.Text = b.Apellidomaterno;
                    txtCarrera.Text = b.Carrera;
                }
                else
                {
                    txtNumero.Clear();
                    txtNombre.Clear();
                    txtApellidoP.Clear();
                    txtApellidoM.Clear();
                    txtCarrera.Clear();
                    MessageBox.Show("NO Existe ");
                }
                txtNumero.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = int.Parse(txtNumero.Text);
                miLista.Modificar(numero, txtNombre.Text, txtApellidoP.Text, txtApellidoM.Text, txtCarrera.Text);
                txtNumero.Clear();
                txtNombre.Clear();
                txtApellidoP.Clear();
                txtApellidoM.Clear();
                txtCarrera.Clear();
                txtNumero.Focus();
                miLista.Mostrar(lstLista);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            int numero = int.Parse(txtNumero.Text);
            string materia = txtMateria.Text;
            string calificacion = txtCalificacion.Text;
            NodoCalificaciones n = new NodoCalificaciones(numero, materia, calificacion);
            listas.AgregarCalificaciones(n);
            txtNumero.Focus();
            txtMateria.Clear();
            txtCalificacion.Clear();
            listas.MostrarCalificaciones(lsvLista);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }
    }
}
