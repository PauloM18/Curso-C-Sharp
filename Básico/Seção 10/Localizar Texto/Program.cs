namespace Localizr_Texto
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "Olá amigo, estou muito feliz de esta aqui com voces.";
            string palavra = "feliz";

            Console.WriteLine("Tamanho do texto: " + texto.Length);
            Console.WriteLine("Localizar: " + texto.IndexOf(palavra));
            Console.WriteLine("Localizar último: " + texto.LastIndexOf(palavra));

            Console.ReadKey();
        }
    }
}