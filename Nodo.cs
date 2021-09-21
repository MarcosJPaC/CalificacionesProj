using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calificaciones
{
    class Nodo
    {
        private int numero;
        private string nombre;
        private string apellidopaterno;
        private string apellidomaterno;
        private string carrera;
        private Nodo siguiente;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }


        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        public string Apellidopaterno
        {
            get { return apellidopaterno; }
            set { apellidopaterno = value; }
        }


        public string Apellidomaterno
        {
            get { return apellidomaterno; }
            set { apellidomaterno = value; }
        }
        public string Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }
        public Nodo Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
        public Nodo()
        {
            numero = 0;
            nombre = "";
            apellidopaterno = "";
            apellidomaterno = "";
            carrera = "";
            siguiente = null;
        }
        public Nodo(int num, string nom, string app, string apm, string car, Lista l)
        {
            numero = num;
            nombre = nom;
            apellidopaterno = app;
            apellidomaterno = apm;
            carrera = car;
            siguiente = null;
        }
        public override string ToString()
        {
            return numero + " - " + nombre + " - " + apellidopaterno + " - " + apellidomaterno + " - " + carrera;
        }
    }
}
