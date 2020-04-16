using CodingChallenge.Data.Classes.Comun;
using System;

namespace CodingChallenge.Data.Classes
{
    public abstract class Geometrica
    {
        public readonly TipoFiguras TipoFigura;
        public readonly decimal Lado;

        public Geometrica(TipoFiguras tipoFigura, decimal lado)
        {
            TipoFigura = tipoFigura;
            Lado = lado;
        }
        public virtual decimal CalcularArea()
        {
            throw new ArgumentOutOfRangeException(@"Forma geometrica inexistente");
        }

        public virtual decimal CalcularPerimetro()
        {
            throw new ArgumentOutOfRangeException(@"Forma geometrica inexistente");
        }
    }
}
