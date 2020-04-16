using CodingChallenge.Data.Classes.Comun;
using System;
using System.Text;

namespace CodingChallenge.Data.Classes
{
    public abstract class Idioma
    {
        public virtual StringBuilder Cabecera(int formasCount)
        {
            throw new ArgumentOutOfRangeException(@"Idioma no soportado");
        }

        public virtual string ObtenerLinea(int cantidad, decimal area, decimal perimetro, TipoFiguras tipoFiguras)
        {
            throw new ArgumentOutOfRangeException(@"Idioma no soportado");
        }

        public virtual string TraducirForma(TipoFiguras tipoFiguras, int cantidad)
        {
            throw new ArgumentOutOfRangeException(@"Idioma no soportado");
        }

        public virtual StringBuilder TraducirTotal(int numeroCuadrados, int numeroCirculos, int numeroTriangulos, int numeroTrapecios, decimal areaCuadrados, decimal areaCirculos, decimal areaTriangulos, decimal areaTrapecios, decimal perimetroCuadrados, decimal perimetroCirculos, decimal perimetroTriangulos, decimal perimetroTrapecios)
        {
            throw new ArgumentOutOfRangeException(@"Idioma no soportado");
        }
    }
}
