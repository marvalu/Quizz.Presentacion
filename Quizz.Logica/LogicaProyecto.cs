using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quizz.AccesoDatos;
using Quizz.Entidades;

namespace Quizz.Logica
{
    public class LogicaProyecto
    {
        Coneccion coneccion = new Coneccion();
        Direcciones direcciones = new Direcciones();
        operacionesCorreo operacionesCorreo = new operacionesCorreo();


        public void InsertarDireccion(Direcciones direcciones) { 
            

            operacionesCorreo.Insertar(direcciones);
        
        }

        public void modificar(Direcciones direcciones) {

            operacionesCorreo.Modificar(direcciones);
        
        }

        public void Eliminar(int id) {


            operacionesCorreo.Eliminar(id);
        }

        public SqlDataReader mostrar() {


            return operacionesCorreo.MostrarTodo();
        }





    }
}
