﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.Biblioteca
{
    internal class Veiculo
    {
        public string Marca;
        public string Modelo;
        public string Ano;

        public virtual void Mover()
        {
            Console.WriteLine("veiculo se movendo!!!");
        }

    }
}
