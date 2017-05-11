class Gerente
{
    public string nome;
    public double salario;

    public void AumentaSalario()
    {
        this.AumentaSalario(0.1);
    }

    public void AumentaSalario(double taxa)
    {
        this.salario += this.salario * taxa;
    }

}