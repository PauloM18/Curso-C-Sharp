class Program
{
    static void Main(String[] args)
    {

        string texto = "Olá amigos!";

        Console.WriteLine("Verificar existencia do inicio: " + texto.StartsWith("Olá"));
        Console.WriteLine("Verificar existencia no final: " + texto.EndsWith("!"));
        Console.WriteLine("Verificar existencia no meio: " + texto.Contains("amigos"));

    }
}
