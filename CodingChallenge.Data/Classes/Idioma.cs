using CodingChallenge.Data.Classes.Comun;
using System.Text;

namespace CodingChallenge.Data.Classes
{
    public abstract class Idioma
    {
        public abstract StringBuilder Cabecera(int formasCount);

        public abstract string ObtenerLinea(int cantidad, decimal area, decimal perimetro, TipoFiguras tipoFiguras);

        public abstract string TraducirForma(TipoFiguras tipoFiguras, int cantidad);

        public abstract StringBuilder TraducirTotal(int numeroCuadrados, int numeroCirculos, int numeroTriangulos, int numeroTrapecios, decimal areaCuadrados, decimal areaCirculos, decimal areaTriangulos, decimal areaTrapecios, decimal perimetroCuadrados, decimal perimetroCirculos, decimal perimetroTriangulos, decimal perimetroTrapecios);
    }
}
