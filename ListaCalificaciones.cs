using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calificaciones
{
    class ListaCalificaciones
    {
        private NodoCalificaciones head;

        public NodoCalificaciones Head
        {
            get { return head; }
            set { head = value; }
        }
        public ListaCalificaciones()
        {
            head = null;
        }
        public void AgregarCalificaciones(NodoCalificaciones n)
        {
            if (head == null)
            {
                head = n;
                return;
            }
            if (n.Numero < head.Numero)
            {
                n.Siguientecal = head;
                head = n;
                return;
            }
            NodoCalificaciones h = head;
            while (h.Siguientecal != null)
            {
                if (n.Numero < h.Siguientecal.Numero)
                {
                    break;
                }
                h = h.Siguientecal;
            }
            n.Siguientecal = h.Siguientecal;
            h.Siguientecal = n;
        }
        public void MostrarCalificaciones(ListView caja)
        {
            NodoCalificaciones h = head;
            caja.Items.Clear();
            while (h != null)
            {
                ListViewItem lista = new ListViewItem(h.Numero.ToString());
                lista.SubItems.Add(h.Materia);
                lista.SubItems.Add(h.Calificacion);
                caja.Items.Add(lista);
                h = h.Siguientecal;
            }
        }
        public void EliminarCalificaciones(int d)
        {
            if (head == null)
            {
                return;
            }
            if (head.Numero == d)
            {
                head = head.Siguientecal;
                return;
            }
            NodoCalificaciones h = Head;
            while (h.Siguientecal != null)
            {
                if (h.Siguientecal.Numero == d)
                {
                    break;
                }
                h = h.Siguientecal;
            }
            if (h.Siguientecal != null)
            {
                h.Siguientecal = h.Siguientecal.Siguientecal;
            }
        }
    }
}
