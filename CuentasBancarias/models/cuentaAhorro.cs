namespace CuentasBancarias.Models;
public class CuentaAhorro : CuentaBancaria
{
    public decimal TasaPromocional { get; set; }

    public CuentaAhorro(decimal saldoInicial, decimal tasaPromocional) : base(saldoInicial)
    {
        TasaPromocional = tasaPromocional;
    }

    public override decimal CalcularInteresesMensual()
    {
        return Saldo * TasaPromocional;
    }
}