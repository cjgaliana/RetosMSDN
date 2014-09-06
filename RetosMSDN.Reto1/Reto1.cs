using System.Collections.Generic;
using System.Linq;

namespace RetosMSDN.Reto1
{
    public class Reto1
    {
        public static List<Persona> OrdenarLista(List<Persona> lista)
        {
            if (lista == null)
            {
                return null;
            }

            return lista.OrderByDescending(x => x.Edad).ThenBy(x => x.Nombre).ToList();
        }
    }
}