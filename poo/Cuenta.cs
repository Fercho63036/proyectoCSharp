namespace MiProyectoCSharp.POO;

public class Cuenta
{
    public string Titular { get; set; }
    private decimal saldo;
    
    public Cuenta(string titular, decimal saldoInicial)
    {
        Titular = titular;
        saldo = saldoInicial;
    }
    
    public void Depositar(decimal monto)
    {
        if (monto > 0)
        {
            saldo += monto;
            Console.WriteLine($"Depósito exitoso: ${monto:F2}");
        }
    }
    
    public void Retirar(decimal monto)
    {
        if (monto > 0 && monto <= saldo)
        {
            saldo -= monto;
            Console.WriteLine($"Retiro exitoso: ${monto:F2}");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente");
        }
    }
    
    public void MostrarSaldo()
    {
        Console.WriteLine($"Cuenta de {Titular} - Saldo: ${saldo:F2}");
    }
}