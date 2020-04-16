using CodingChallenge.Data.Classes.Comun;
using System;

namespace CodingChallenge.Data.Classes.FormasGeometricas
{
    public class TrianguloEquilatero : Geometrica
    {
        public TrianguloEquilatero(decimal lado) : base(TipoFiguras.TrianguloEquilatero, lado)
        {
        }

        public override decimal CalcularArea()
        {
            return ((decimal)Math.Sqrt(3) / 4) * Lado * Lado;
        }

        public override decimal CalcularPerimetro()
        {
            return Lado * 3;
        }
    }
}
