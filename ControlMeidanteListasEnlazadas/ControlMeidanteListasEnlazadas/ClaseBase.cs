using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlMeidanteListasEnlazadas
{
    class ClaseBase
    {
        private string _producto;
        private string _alumno;
        private string _vehiculo;
        private int _contacto;
        private ClaseBase _siguiente;

        

        public ClaseBase(string p, string al, string vei, int cont)
        {
            _producto = p;
            _alumno = al;
            _vehiculo = vei;
            _contacto = cont;
        }

        public override string ToString()
        {
            return "Producto: " + _producto + " | " + " Alumno: " + _alumno  +" | " + " Vehiculo: " + _vehiculo  +" | " + " Contacto: " + _contacto;
        }
        public string Producto
        {
            get { return _producto; }
            set { _producto = value; }
        }

        public string Alumno
        {
            get { return _alumno; }
            set { _alumno = value; }
        }

        public string Vehiculo
        {
            get { return _vehiculo; }
            set { _vehiculo = value; }
        }

        public int Contacto
        {
            get { return _contacto; }
            set { _contacto = value; }
        }

        public ClaseBase Siguiente
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }
    }
}
