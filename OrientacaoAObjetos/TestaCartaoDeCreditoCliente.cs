using System.Collections.Generic;

class TestaCartaoDeCreditoCliente
{
    static void Main(string[] args)
    {
        Cliente c1 = new Cliente();
        CartaoDeCredito cc = new CartaoDeCredito();
        CartaoDeCredito cc1 = new CartaoDeCredito();

        c1.nome = "Jorge";
        c1.codigo = 1;

        cc.numero = 111111;
        cc.dataDeValidade = "06/2020";
        cc.cliente = c1;

        cc1.numero = 222222;
        cc1.dataDeValidade = "07/2018";
        cc1.cliente = c1;

        var cartoes = new List<CartaoDeCredito>();
        cartoes.Add(cc);
        cartoes.Add(cc1);

        foreach (var item in cartoes)
        {
            System.Console.WriteLine(item.numero);
            System.Console.WriteLine(item.dataDeValidade);
            System.Console.WriteLine(item.cliente.nome);
            System.Console.WriteLine("----------------------------------------------");
        } 
    }
}