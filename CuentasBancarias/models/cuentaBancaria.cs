namespace CuentasBancarias.Models;
public class CuentaBancaria
{
    public decimal Saldo { get; set; }
    public CuentaBancaria(decimal saldoInicial)
    {
        Saldo = saldoInicial;
    }


public virtual decimal CalcularInteresesMensual()
{
    return Saldo * 0.01m; 
}
}