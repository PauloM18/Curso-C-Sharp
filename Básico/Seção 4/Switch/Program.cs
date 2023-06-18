namespace Switch
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Qual é o seu estado civil?");
            Console.WriteLine("Opções: ");
            Console.WriteLine("S - Solteiro.");
            Console.WriteLine("C - Casado.");
            Console.WriteLine("V - Viuvo.");
            Console.WriteLine("D - Divorciado.");
            string valor = Console.ReadLine();
            switch (valor)
            {
                case "S":
                    Console.WriteLine("Solteiro.");
                    break;
                case "C":
                    Console.WriteLine("Casado.");
                    break;
                case "V":
                    Console.WriteLine("Viuvo.");
                    break;
                case "D":
                    Console.WriteLine("Divorciado.");
                    break;
                default:
                    Console.WriteLine("Comando não reconhecido!");
                    break;

            }
        }
    }
}
