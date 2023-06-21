class Program
{
    static void Main(string[] args)
    {
        string texto = "Olá amigos do joão!";

        Console.WriteLine(texto);
        string textosub = texto.Replace("joão", "Paulo");
        Console.WriteLine(textosub);
        Console.WriteLine(texto);

    }
}
