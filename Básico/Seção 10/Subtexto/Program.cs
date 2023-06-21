namespace Subtexto 
{
    class Program
    {
        static void Main()
        {
            string texto = "Olá a todos! Desejo feliz ano novo!";
            string frase = texto.Substring(13);
            string palavra = texto.Substring(13, 6);

            Console.WriteLine("2 frase: " + frase);
            Console.WriteLine("Palavra: " + palavra);

            Console.ReadKey();
        }
    }
}
