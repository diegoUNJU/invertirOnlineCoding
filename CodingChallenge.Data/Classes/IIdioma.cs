using System.Text;
using CodingChallenge.Data.Classes.Comun;

namespace CodingChallenge.Data.Classes
{
    public interface IIdioma
    {
       StringBuilder Cabecera(int formasCount);
       string ObtenerLinea(int cantidad, decimal area, decimal perimetro, TipoFiguras tipoFiguras);
       string TraducirForma(TipoFiguras tipoFiguras, int cantidad);
       StringBuilder TraducirTotal(int numeroCuadrados, int numeroCirculos, int numeroTriangulos, decimal areaCuadrados,
           decimal areaCirculos, decimal areaTriangulos, decimal perimetroCuadrados, decimal perimetroCirculos,
           decimal perimetroTriangulos);
    }
}
