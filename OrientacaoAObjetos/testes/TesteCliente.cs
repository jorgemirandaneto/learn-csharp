using System.Collections.Generic;

class TesteCliente
{
    static void Main(string[] args)
    {
        Cliente c1 = new Cliente();
        c1.nome = "Jorge";
        c1.codigo = 1;

        Cliente c2 = new Cliente();
        c2.nome = "Raiza";
        c2.codigo = 2;

        var clientes = new List<Cliente>();

        clientes.Add(c1);
        clientes.Add(c2);

        foreach (var item in clientes)
        {
            System.Console.WriteLine(item.nome);
            System.Console.WriteLine(item.codigo);
            System.Console.WriteLine("-----------------------------------");
        }

        /*System.Console.WriteLine("Primeiro Cliente");
        System.Console.WriteLine("Nome: " + c1.nome);
        System.Console.WriteLine("Nome: " + c1.codigo);
        System.Console.WriteLine("------------------------------------");
        System.Console.WriteLine("Segundo Cliente Cliente");
        System.Console.WriteLine("Nome: " + c2.nome);
        System.Console.WriteLine("Nome: " + c2.codigo);*/
    }
}