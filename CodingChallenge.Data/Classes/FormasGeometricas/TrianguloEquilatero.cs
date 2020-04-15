using System;
using CodingChallenge.Data.Classes.Comun;

namespace CodingChallenge.Data.Classes.FormasGeometricas
{
   public class TrianguloEquilatero: IGeometrica
    {
        public TipoFiguras TipoFiguras { get; set; }
        public decimal Lado { get; set; }

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
