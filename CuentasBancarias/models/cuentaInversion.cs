namespace CuentasBancarias.Models;
public class CuentaInversion : CuentaBancaria
{
    public double FactorRiesgo { get; set; }

    public CuentaInversion(decimal saldoInicial, double factorRiesgo) : base(saldoInicial)
    {
        FactorRiesgo = factorRiesgo;
    }

    public override decimal CalcularInteresesMensual()
    {
        decimal tasaDinamica = Saldo > 10000 ? 0.02m : 0.015m;
        return Saldo * tasaDinamica * (decimal)FactorRiesgo;
    }
}