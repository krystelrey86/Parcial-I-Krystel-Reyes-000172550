namespace CuentasBancarias.Models;

class Program
{
    static void Main(string[] args)
    {
        List<CuentaBancaria> cuentas = new List<CuentaBancaria>
        {
            new CuentaAhorro(5000, 0.02m),
            new CuentaInversion(15000, 1.5),
        };

        foreach (var cuenta in cuentas)
        {
            Console.WriteLine($"Saldo: {cuenta.Saldo}, Intereses Mensuales: {cuenta.CalcularInteresesMensual()}");
        }
    }
}
