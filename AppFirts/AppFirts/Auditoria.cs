using System;

namespace AppFirst
{
    public abstract class Auditoria
    {
        public DateTime fechaRegistro { get; set; }
        public DateTime fechaModificacion { get; set; }
    }
}