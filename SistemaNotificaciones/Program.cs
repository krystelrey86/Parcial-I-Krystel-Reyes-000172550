namespace SistemaNotificaciones;
class Program 
{
    static void Main(string[] args)
    {
        List<Models.Notificacion> notificaciones = new List<Models.Notificacion>
        {
            new Models.CorreoElectronico("Hola, este es un correo electrónico.", "juan@ejemplo.com"),
            new Models.Sms("Hola, este es un mensaje de texto.", "1234567890")
        };

        foreach (var notificacion in notificaciones)
        {
            notificacion.Enviar();
        }
    }
}