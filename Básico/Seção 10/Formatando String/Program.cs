class Program
{
    static void Main(string[] args)
    {
        string nome = "Elias Costa";
        string texto = "Bem vindo" + nome + "! feliz natal";

        string textoFormatado = string.Format("Bem vindo {0}! feliz natal {0} {1}!", nome, "feliz");
        Console.WriteLine(texto);
        Console.WriteLine(textoFormatado);
    }
}