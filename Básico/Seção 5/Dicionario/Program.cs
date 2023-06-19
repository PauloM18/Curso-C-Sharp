namespace Dicionario
{
    class Program
    {
        static void Main(string[] args) 
        {
            Dictionary<string, int> dicionario = new Dictionary<string, int>();
            dicionario.Add("T1", 128);
            dicionario.Add("t2", 121);
            Console.WriteLine(dicionario["t2"]);
        }
    }
}
