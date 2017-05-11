using System.Collections.Generic;

class TestaAgencia
{
    static void Main(string[] args)
    {
        Agencia a1 = new Agencia();
        a1.numero = 1;

        Agencia a2 = new Agencia();
        a2.numero = 2;

        var agencias = new List<Agencia>();
        agencias.Add(a1);
        agencias.Add(a2);

        foreach (var item in agencias)
        {
            System.Console.WriteLine("Numero das agencias");
            System.Console.WriteLine(item.numero);
            System.Console.WriteLine("----------------------------");
        }

        
    }
}