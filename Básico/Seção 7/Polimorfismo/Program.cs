using Polimorfismo.Biblioteca;
using Polimorfismo.Biblioteca.Derivada;//chamada para as outras class = carro, moto, onibus
namespace polimorfismo
{
    class Program
    {
        static void Main()
        {
            //instacia
            Moto moto = new Moto();
            MoverVeiculo(moto);
            Carro carro = new Carro();
            MoverVeiculo(carro);
            Console.ReadKey();
        }
        //exemplo de sobrecarga metodos com mesmo nome mais com estradas diferentes
        /*public static void MoverVeiculo(Carro veiculo) 
        {
            veiculo.Mover();
        }
        public static void MoverVeiculo(Moto veiculo)
        {
            veiculo.Mover();
        }
        public static void MoverVeiculo(Onibus veiculo)
        {
            veiculo.Mover();
        }*/
        public static void MoverVeiculo(Veiculo veiculo)
        {
            veiculo.Mover();
        }

    }
}
