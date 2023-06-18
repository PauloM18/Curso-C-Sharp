namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = { "José", "João", "Pedro", "Tiago" };
            Console.WriteLine("----------Repetição de For-----------");
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine("Nomes: " + nomes[i]);
            }

            Console.WriteLine("----------Repetição de Foreach--------");
            foreach(string nome in nomes)
            {
                Console.WriteLine("Nomes: " + nome);
            }
            Console.ReadKey();
        }
    }
}
