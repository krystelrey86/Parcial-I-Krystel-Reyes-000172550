namespace SistemaNotificaciones.Models;
public class Notificacion
{
    public string Mensaje { get; set; }
    public Notificacion(string mensaje)
    {
        Mensaje = mensaje;
    }

    public virtual void Enviar()
    {
        Console.WriteLine($"Enviando notificación: {Mensaje}");
    }
}