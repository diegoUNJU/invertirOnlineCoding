using CodingChallenge.Data.Classes.Comun;

namespace CodingChallenge.Data.Classes
{
    public interface IGeometrica
    {
        TipoFiguras TipoFiguras { get; set; }
        decimal Lado { get; set; }
        decimal CalcularArea(decimal lado);
        decimal CalcularPerimetro(decimal lado);
    }
}
