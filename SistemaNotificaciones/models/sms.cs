namespace SistemaNotificaciones.Models;
public class Sms : Notificacion
{
    public string NumeroTelefono { get; set; }

    public Sms(string mensaje, string numeroTelefono) : base(mensaje)
    {
        NumeroTelefono = numeroTelefono;
    }

    public override void Enviar()
    {
        Console.WriteLine($"Enviando SMS a {NumeroTelefono}: {Mensaje}");
    }
}