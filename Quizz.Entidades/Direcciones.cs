using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz.Entidades
{
    public class Direcciones
    {

        private int _ID;
        private string _Pais;
        private string _Provincia;
        private string _Distrito;
        private string _Detalles1;
        private string _Detalles2;
        private int _TelefonoFijo;


      


      

        public Direcciones() { }

        public Direcciones(int iD, string pais, string provincia, string distrito, string detalles1, string detalles2, int telefonoFijo)
        {
            _ID = iD;
            _Pais = pais;
            _Provincia = provincia;
            _Distrito = distrito;
            _Detalles1 = detalles1;
            _Detalles2 = detalles2;
            _TelefonoFijo = telefonoFijo;
        }

        public int ID { get => _ID; set => _ID = value; }
        public string Pais { get => _Pais; set => _Pais = value; }
        public string Provincia { get => _Provincia; set => _Provincia = value; }
        public string Distrito { get => _Distrito; set => _Distrito = value; }
        public string Detalles1 { get => _Detalles1; set => _Detalles1 = value; }
        public string Detalles2 { get => _Detalles2; set => _Detalles2 = value; }
        public int TelefonoFijo { get => _TelefonoFijo; set => _TelefonoFijo = value; }

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
