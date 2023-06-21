class Program
{
    static void Main(string[] args)
    {
        string texto = "       Olá amigos do Elias       ";
        Console.WriteLine( texto.TrimStart() );// inicio
        Console.WriteLine( texto.TrimEnd() );//final
        Console.WriteLine( texto.Trim() );// tudo

        Console.ReadKey();
    }
}
