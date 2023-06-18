namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repetir = false;
            while (repetir)
            {
                Console.WriteLine("Entrou no \"fluxo\" do 'while'");

            }
            do
            {
                Console.WriteLine("Entrou no fluxo Do-While");
            } while (repetir);
       
            Console.ReadKey();
        }
    }
}