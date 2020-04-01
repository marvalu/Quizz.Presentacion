using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quizz.AccesoDatos;
using System.Data.SqlClient;




namespace Quizz.Entidades
{
    public class operacionesCorreo : IOperaciones<Direcciones>
    {

      Coneccion coneccion = new Coneccion();



      

        public Direcciones Buscar(int id)
        {
            string Sqlstring = string.Format("select * from correo where id={0}", id);


            SqlDataReader SQLTemporal = coneccion.QueryUsing(Sqlstring);
            if (SQLTemporal != null && SQLTemporal.HasRows)
            {

                while (SQLTemporal.Read())
                {

                    return new Direcciones(SQLTemporal.GetInt32(0), SQLTemporal.GetString(1).Trim(), SQLTemporal.GetString(2).Trim(), SQLTemporal.GetString(3).Trim(), SQLTemporal.GetString(3).Trim(), SQLTemporal.GetString(3).Trim(), SQLTemporal.GetInt32(0));

                }


            }

            coneccion.nonQueryUsing(Sqlstring);
            return null;
        }

        public void Eliminar(int Id)
        {
            string Sqlstring = string.Format("delete * from correo where id={0}", Id);

            coneccion.nonQueryUsing(Sqlstring);
        }

      

        public void Insertar(Direcciones item)
        {
            string Sqlstring = string.Format("INSERT INTO[dbo].[correo]([id],[pais],[provicia],[detalles1],[detalles2],[telefono]) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')", item.ID,item.Pais, item.Provincia, item.Detalles1,item.Detalles2,item.TelefonoFijo);
            coneccion.nonQueryUsing(Sqlstring);
        }

        public void Modificar(Direcciones item)

            

        {
            string Sqlstring = string.Format("UPDATE[dbo].[correo]([id],[pais],[provicia],[detalles1],[detalles2],[telefono]) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')", item.ID, item.Pais, item.Provincia, item.Detalles1, item.Detalles2, item.TelefonoFijo);
            coneccion.nonQueryUsing(Sqlstring);
        }

        public SqlDataReader MostrarTodo()
        {

            string SQLstring = string.Format("select * from [dbo].[correo]");
            return coneccion.QueryUsing(SQLstring);
        }
    }
}
