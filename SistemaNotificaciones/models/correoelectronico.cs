namespace SistemaNotificaciones.Models;
public class CorreoElectronico : Notificacion
{
    public string Destinatario { get; set; }

    public CorreoElectronico(string mensaje, string destinatario) : base(mensaje)
    {
        Destinatario = destinatario;
    }

    public override void Enviar()
    {
        Console.WriteLine($"Enviando correo electrónico a {Destinatario}: {Mensaje}");
    }
}