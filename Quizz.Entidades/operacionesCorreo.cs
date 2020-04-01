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
            string Sqlstring = string.Format("select * from Persona where id={0}", id);


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
            string Sqlstring = string.Format("INSERT INTO[dbo].[correo]([Pais],[Provicia],[Detalles1],[Detalles2],[TelefonoFijo]) VALUES ('{0}','{1}','{2}','{3}','{4}')", item.Pais1, item.Provincia1, item.Detalles11,item.Detalles21,item.TelefonoFijo1);
            coneccion.nonQueryUsing(Sqlstring);
        }

        public void Modificar(Direcciones item)

            // posible error despues de prbar validar

        {
            string Sqlstring = string.Format("UPDATE INTO[dbo].[correo]([Pais],[Provicia],[Detalles1],[Detalles2],[TelefonoFijo]) VALUES ('{0}','{1}','{2}','{3}','{4}')", item.Pais1, item.Provincia1, item.Detalles11, item.Detalles21, item.TelefonoFijo1);
            coneccion.nonQueryUsing(Sqlstring);
        }
    }
}
