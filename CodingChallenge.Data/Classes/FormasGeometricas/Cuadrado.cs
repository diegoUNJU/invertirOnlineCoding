using CodingChallenge.Data.Classes.Comun;

namespace CodingChallenge.Data.Classes.FormasGeometricas
{
    public class Cuadrado : Geometrica
    {

        public Cuadrado(decimal lado) : base(TipoFiguras.Cuadrado, lado)
        {
        }
        public override decimal CalcularArea()
        {
            return Lado * Lado;
        }

        public override decimal CalcularPerimetro()
        {
            return 4 * Lado;
        }
    }
}
