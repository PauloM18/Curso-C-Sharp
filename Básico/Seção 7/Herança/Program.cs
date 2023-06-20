using Heranca.Biblioteca;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();

            Moto moto = new Moto();

            Veiculo vei = new Veiculo();

            carro.Marca = "FIAT";
            moto.Marca = "Triumph";
            vei.Marca = "Airbus";
        }
    }
}
