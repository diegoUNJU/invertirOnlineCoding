using CodingChallenge.Data.Classes.Comun;
using System;

namespace CodingChallenge.Data.Classes.FormasGeometricas
{
    public class Circulo : Geometrica
    {

        public Circulo(decimal lado) : base(TipoFiguras.Circulo, lado)
        {
        }

        public override decimal CalcularArea()
        {
            return (decimal)Math.PI * (Lado / 2) * (Lado / 2); //lado es diametro.
        }

        public override decimal CalcularPerimetro()
        {
            return (decimal)Math.PI * Lado; // lado es diametro.
        }
    }
}
