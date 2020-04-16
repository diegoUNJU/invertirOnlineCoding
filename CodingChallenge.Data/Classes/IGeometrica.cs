using CodingChallenge.Data.Classes.Comun;

namespace CodingChallenge.Data.Classes
{
    public interface IGeometrica
    {
        TipoFiguras TipoFiguras { get; }
        decimal Lado { get; }
        decimal CalcularArea(decimal lado);
        decimal CalcularPerimetro(decimal lado);
    }
}
