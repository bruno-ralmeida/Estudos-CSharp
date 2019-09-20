public class ContaCorrente
{
    public string titular;
    public int agencia;
    public int conta;
    public double saldo;

    public string apresentacao()
    {
        return $" Titular:{titular}\n " +
                $"Ag:{agencia}\n Conta:{conta} \n Saldo:{saldo:C} ";
    }
}