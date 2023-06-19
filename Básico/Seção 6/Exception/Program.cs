namespace exception
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            try
            {
                int numero = int.Parse(Console.ReadLine());
                int num = int.Parse(null);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Não foi digitado número!");
            }
            catch(Exception e)
            {
                Console.WriteLine("Tratado pela class Pai - Exeption");
            }
            finally
            {
                Console.WriteLine("Finally");
            }
            
            Console.ReadKey();
        }
    }
}