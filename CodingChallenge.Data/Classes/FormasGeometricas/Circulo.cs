using CodingChallenge.Data.Classes.Comun;
using System;

namespace CodingChallenge.Data.Classes.FormasGeometricas
{
    public class Circulo: IGeometrica
    {
        public TipoFiguras TipoFiguras { get; set; }
        public decimal Lado { get; set; }

        public Circulo(decimal lado)
        {
            Lado = lado;
            TipoFiguras = TipoFiguras.Circulo;
        }

        public decimal CalcularArea(decimal lado)
        {
            return (decimal)Math.PI * (lado / 2) * (lado / 2); //lado es diametro.
        }

        public decimal CalcularPerimetro(decimal lado)
        {
            return (decimal)Math.PI * lado; // lado es diametro.
        }
    }
}
