using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrescrita.Biblioteca
{
    class Veiculo
    {
        public string Marca;
        public string Modelo;
        public string QuantMaxPass;
        public string Ano;

        public override void Mover()
        {
            Console.WriteLine("Mover chamado dentro de: Veiculo.mover");

           
        }
    }
}
