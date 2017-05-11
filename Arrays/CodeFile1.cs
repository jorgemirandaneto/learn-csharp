class ExibeArgumentos
{
    static void Main(string[] args)
    {
        foreach (string arg in args)
        {
            System.Console.WriteLine(args);
        }
    }
}