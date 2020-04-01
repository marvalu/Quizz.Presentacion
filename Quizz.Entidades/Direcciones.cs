using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz.Entidades
{
    public class Direcciones
    {

        private int ID;
        private string Pais;
        private string Provincia;
        private string Distrito;
        private string Detalles1;
        private string Detalles2;
        private int TelefonoFijo;

    
        public int ID1 { get => ID; set => ID = value; }
        public string Pais1 { get => Pais; set => Pais = value; }
        public string Provincia1 { get => Provincia; set => Provincia = value; }
        public string Distrito1 { get => Distrito; set => Distrito = value; }
        public string Detalles11 { get => Detalles1; set => Detalles1 = value; }
        public string Detalles21 { get => Detalles2; set => Detalles2 = value; }
        public int TelefonoFijo1 { get => TelefonoFijo; set => TelefonoFijo = value; }


        public Direcciones(int iD, string pais, string provincia, string distrito, string detalles1, string detalles2, int telefonoFijo)
        {
            ID = iD;
            Pais = pais;
            Provincia = provincia;
            Distrito = distrito;
            Detalles1 = detalles1;
            Detalles2 = detalles2;
            TelefonoFijo = telefonoFijo;
        }

        public Direcciones() { }



        public void Insertar()
        {

            operacionesCorreo operacionesPersona = new operacionesCorreo();

            operacionesPersona.Insertar(this);

        }

        //public void Eliminar()
        //{

        //    operacionesCorreo operacionesPersona = new operacionesCorreo();

        //    operacionesPersona.Eliminar(int id);

        //}

        public void Modificar()
        {

            operacionesCorreo operacionesPersona = new operacionesCorreo();
            operacionesPersona.Modificar(this);

        }
    }
}
