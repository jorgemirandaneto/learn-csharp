class TestaMetodosConta
{
    static void Main(string[] args)
    {
        Conta c = new Conta();

        System.Console.WriteLine("Chamada do metodo Deposita");
        c.Deposita(1000);
        c.ImprimeExtrato();
        System.Console.WriteLine("-------------------------------------------------");

        System.Console.WriteLine("Chamada do metodo Saca");
        c.Saca(100);
        c.ImprimeExtrato();
        System.Console.WriteLine("-------------------------------------------------");

        double saldoDisponivel = c.SaldoDisponivel();
        System.Console.WriteLine("Seu saldo disponivel é: " + saldoDisponivel);


    }
}