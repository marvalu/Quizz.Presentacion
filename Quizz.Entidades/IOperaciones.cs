using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz.Entidades
{
    public interface IOperaciones <T>
    {

        
        T Buscar(int id);

        void Insertar(T item);

        void Eliminar(int id);

        void Modificar(T item);

    }
}
