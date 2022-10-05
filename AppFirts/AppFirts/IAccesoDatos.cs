using System.Collections.Generic;

namespace AppFirst
{
    public interface IAccesoDatos
    {
        bool create(Persona persona);
        List read();
        bool update(Persona persona, int posicionPersona);
        bool delete(string documentoIdentidad);
    }
}
