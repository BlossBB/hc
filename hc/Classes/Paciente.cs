using System;

namespace hc.Classes
{
    public class Paciente
    {
        public int Id { get; set; }
        public string NumeroExpediente { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaAlta { get; set; }
    }
}
