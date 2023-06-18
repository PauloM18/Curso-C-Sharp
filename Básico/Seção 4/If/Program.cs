namespace IfElseElseIf
{
    class Program
    {
        static void Main(string[] args) 
        {
            string valorPoupanaTexto;
            float valorPoupanca;
            Console.Write("Digite o valor que você possui na consta poupança: ");
            valorPoupanaTexto = Console.ReadLine();
            valorPoupanca = float.Parse(valorPoupanaTexto);

            if(valorPoupanca >= 100000)
            {
                Console.WriteLine("Vôcê é cliente VIP possui uma taxa de juros diferenciada.");

            }
            else if(valorPoupanca > 50000)
            {
                Console.WriteLine("Você é um cliente especial com tatxa de juros de 1.25% ao mês.");
            }
            else
            {
                Console.WriteLine("Você é um cliente especial. Mais sua taxa de juros é normal.");
            }
            Console.ReadKey();
        }
    }
}
