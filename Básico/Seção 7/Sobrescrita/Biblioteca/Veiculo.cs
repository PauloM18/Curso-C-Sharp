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

        public void Mover()
        {
            Console.WhiteLine("Mover chamado dentro de: Veiculo.mover");
           
        }
    }
}
