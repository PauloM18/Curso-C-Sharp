class Program
{
    static void Main(string[] args)
    {
        string nomes = "joão, Maria, josé, Jesus, Felipe, Tiago e Paulo.";
        string[] separador = { ", ", " e " };//espaços fazem a diferença
        string[] nomesArray = nomes.Split(separador, StringSplitOptions.None);
        foreach (string nome in nomesArray)
        {
            Console.WriteLine(nome);

        }
        Console.ReadKey();
    }
}