using CodingChallenge.Data.Classes.Comun;

namespace CodingChallenge.Data.Classes.FormasGeometricas
{
    public class Trapecio : Geometrica
    {
        public decimal LadoMenor { get; }
        public decimal Altura { get; }

        public Trapecio(decimal lado, decimal ladoMenor, decimal altura) : base(TipoFiguras.Trapecio, lado)
        {
            LadoMenor = ladoMenor;
            Altura = altura;
        }
        public override decimal CalcularArea()
        {
            return (Lado + LadoMenor) * Altura / 2;
        }

        public override decimal CalcularPerimetro()
        {
            return Lado + LadoMenor + 2 * Altura;
        }
    }
}
