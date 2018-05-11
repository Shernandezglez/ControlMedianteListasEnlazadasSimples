using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlMeidanteListasEnlazadas
{
    class Catalogo_estructura_
    {
        ClaseBase inicio = null;

        public void agregarInicio(ClaseBase nuevo)
        {
            if(inicio == null)
            {
                inicio = nuevo;
            }
            
            else
            {
                ClaseBase temp = inicio;

                while(temp.Siguiente != null)
                {
                    temp = temp.Siguiente;
                }
                temp.Siguiente = nuevo;
            }
        }

        public void eliminarPrimero()
        {
            inicio = inicio.Siguiente;
        }

        public void eliminarUltimo()
        {
            ClaseBase temp = inicio.Siguiente;
            temp.Siguiente = null;
        }

        public string reporte()
        {
            string cdn = "";
            ClaseBase temp = inicio;

            while (temp != null)
            {
                cdn += temp.ToString() + "\r\n";
                temp = temp.Siguiente;
            }
            return cdn;
        }

        public string reporteInverso()
        {
            string cdn = "";
            ClaseBase temp = inicio;


            while (temp != null)
            {

                cdn = temp.ToString() + "\r\n" + cdn;
                temp = temp.Siguiente;

            }
            return cdn;
        }
        public void invertirLista()
        {
            ClaseBase p = null;
            ClaseBase c = inicio;
            ClaseBase n;

            while (c != null)
            {
                n = c.Siguiente;
                c.Siguiente = p;
                p = c;
                c = n;
            }
            inicio = p;
        }
    }
}
