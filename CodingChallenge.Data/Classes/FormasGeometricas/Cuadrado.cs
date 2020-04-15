using CodingChallenge.Data.Classes.Comun;

namespace CodingChallenge.Data.Classes.FormasGeometricas
{
    public class Cuadrado : IGeometrica
    {
        public TipoFiguras TipoFiguras { get; set; }
        public decimal Lado { get; set; }

        public Cuadrado(decimal lado)
        {
            Lado = lado;
            TipoFiguras = TipoFiguras.Cuadrado;
        }
        public decimal CalcularArea(decimal lado)
        {
            return lado * lado;
        }

        public decimal CalcularPerimetro(decimal lado)
        {
            return 2 * (lado + lado);
        }
    }
}
