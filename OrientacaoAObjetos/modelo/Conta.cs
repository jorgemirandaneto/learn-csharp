class Conta
{
    public int numero;
    public double saldo;
    public double limite;
    public Agencia agencia;
    
    public void Deposita(double valor)
    {
        this.saldo += valor;
    }

    public void Saca(double valor)
    {
        this.saldo -= valor;
    }

    public void ImprimeExtrato()
    {
        System.Console.WriteLine("Seu saldo é: " + this.saldo);
    }
    public double SaldoDisponivel()
    {
        return this.saldo + this.limite;
    }

}