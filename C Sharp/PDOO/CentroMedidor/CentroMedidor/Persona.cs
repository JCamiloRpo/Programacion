using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroMedidor
{
    public abstract class Persona
    {
        protected string Nombre;

        protected Persona(string nombre)
        {
            Nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
        }

        public string Nombre1 { get => Nombre; }
    }
}
