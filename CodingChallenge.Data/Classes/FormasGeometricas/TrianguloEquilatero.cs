using CodingChallenge.Data.Classes.Comun;
using System;

namespace CodingChallenge.Data.Classes.FormasGeometricas
{
    public class TrianguloEquilatero : IGeometrica
    {
        public TipoFiguras TipoFiguras { get; }
        public decimal Lado { get; }

        public TrianguloEquilatero(decimal lado)
        {
            Lado = lado;
            TipoFiguras = TipoFiguras.TrianguloEquilatero;
        }

        public decimal CalcularArea(decimal lado)
        {
            return ((decimal)Math.Sqrt(3) / 4) * lado * lado;
        }

        public decimal CalcularPerimetro(decimal lado)
        {
            return lado * 3;
        }
    }
}
