using Sobrescrita.Biblioteca;

namespace Sobrescrita
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

            carro.Mover();
            carro.Mover();
            carro.MOver();

            console.ReadKey();
        }
    }
}
