namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 10) 
            {
                Console.WriteLine("O valor da variavel: " + i);
                i ++;

            }
            int x = 0;
            bool repetir = true;
            while (repetir)
            {
                Console.WriteLine("Valor da variavel X: " + x);
                if(x > 20)
                {
                    Console.WriteLine("Saindo do programa!");
                    repetir = false;
                }
                x++;   
            }
            Console.ReadLine();

        }
    }
}
