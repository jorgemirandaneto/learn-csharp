using System.Collections.Generic;

class TestaCartaoDeCredito
{
    static void Main(string[] args)
    {
        CartaoDeCredito c1 = new CartaoDeCredito();
        c1.numero = 111111;
        c1.dataDeValidade = "06/2020";

        CartaoDeCredito c2 = new CartaoDeCredito();
        c2.numero = 222222;
        c2.dataDeValidade = "06/2020";

        var cartoes = new List<CartaoDeCredito>();
        cartoes.Add(c1);
        cartoes.Add(c2);

        foreach (var item in cartoes)
        {
            System.Console.WriteLine(item.numero);
            System.Console.WriteLine(item.dataDeValidade);
            System.Console.WriteLine("------------------------------");
        }

    }
}