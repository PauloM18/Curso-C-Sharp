using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.Biblioteca.Derivada
{
    internal class Moto : Veiculo //Herdando
    {
        public override void Mover() // Sobrescrita Override
        {
            Console.WriteLine("Moto se movendo!!!");
        }
    }
}
