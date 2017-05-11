class TesteGerente
{
    static void Main(string[] args)
    {
        Gerente g = new Gerente();
        g.nome = "Jorge";
        g.salario = 1000;

        System.Console.WriteLine("Aumentando o salario para 10%");
        g.AumentaSalario();
        System.Console.WriteLine(g.salario);

        System.Console.WriteLine("------------------------------------------");

        System.Console.WriteLine("Aumentando o salario para 30%");
        g.AumentaSalario(0.3);
        System.Console.WriteLine(g.salario);

    }
}