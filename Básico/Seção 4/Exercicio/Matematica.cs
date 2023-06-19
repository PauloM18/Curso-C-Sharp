using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    class Matematica
    {
       public static int Exponenciacao(int Base, int Exp)
        {
            int resultado = Base;
            for (int i = 1; i < Exp; i++)
            {
                resultado = resultado * Base;
            }
            return resultado;
        }
        
    }
}
