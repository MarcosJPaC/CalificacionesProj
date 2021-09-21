using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calificaciones
{
    class NodoCalificaciones
    {
        private int numero;
        private string materia;
        private string calificacion;
        private NodoCalificaciones siguientecal;
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public string Materia
        {
            get { return materia; }
            set { materia = value; }
        }
        public string Calificacion
        {
            get { return calificacion; }
            set { calificacion = value; }
        }
        public NodoCalificaciones Siguientecal
        {
            get { return siguientecal; }
            set { siguientecal = value; }
        }
        public NodoCalificaciones()
        {
            numero = 0;
            materia = "";
            calificacion = "";
            siguientecal = null;
        }
        public NodoCalificaciones(int num, string m, string c)
        {
            numero = num;
            materia = m;
            calificacion = c;
            siguientecal = null;
        }
        public override string ToString()
        {
            return numero + materia + calificacion;
        }
    }
}
