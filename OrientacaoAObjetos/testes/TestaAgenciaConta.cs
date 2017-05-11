using System.Collections.Generic;

class TestaAgenciaConta
{
    static void Main(string[] args)
    {
        Agencia a = new Agencia(1234);
        Conta c = new Conta(a);

        c.numero = 123;
        c.limite = 1000;
        c.saldo = 2000;


        var contas = new List<Conta>();
        contas.Add(c);

        foreach (var item in contas)
        {

            System.Console.WriteLine(item.agencia.numero);
            System.Console.WriteLine(item.numero);
            System.Console.WriteLine(item.limite);
            System.Console.WriteLine(item.saldo);
            System.Console.WriteLine("------------------------------------------");
        }
     }
}