using CodingChallenge.Data.Classes.Comun;
using System.Text;

namespace CodingChallenge.Data.Classes.Idiomas
{
    public class Castellano : IIdioma
    {

        public StringBuilder Cabecera(int formasCount)
        {
            var sb = new StringBuilder();
            if (formasCount == 0)
            {
                return sb.Append("<h1>Lista vacía de formas!</h1>");
            }
            return sb.Append("<h1>Reporte de Formas</h1>");
        }

        public string ObtenerLinea(int cantidad, decimal area, decimal perimetro, TipoFiguras tipoFiguras)
        {
            return cantidad != 0 ? $"{cantidad} {TraducirForma(tipoFiguras, cantidad)} | Area {area:#.##} | Perimetro {perimetro:#.##} <br/>" : "";
        }

        public string TraducirForma(TipoFiguras tipoFiguras, int cantidad)
        {
            switch (tipoFiguras)
            {
                case TipoFiguras.Cuadrado: return cantidad == 1 ? "Cuadrado" : "Cuadrados";
                case TipoFiguras.Circulo: return cantidad == 1 ? "Círculo" : "Círculos";
                case TipoFiguras.TrianguloEquilatero: return cantidad == 1 ? "Triángulo" : "Triángulos";
                default: return string.Empty;

            }
        }

        public StringBuilder TraducirTotal(int numeroCuadrados, int numeroCirculos, int numeroTriangulos, decimal areaCuadrados, decimal areaCirculos, decimal areaTriangulos, decimal perimetroCuadrados, decimal perimetroCirculos, decimal perimetroTriangulos)
        {
            var sb = new StringBuilder();
            sb.Append("TOTAL:<br/>");
            sb.Append(numeroCuadrados + numeroCirculos + numeroTriangulos + " " + "formas" + " ");
            sb.Append("Perimetro " + (perimetroCuadrados + perimetroTriangulos + perimetroCirculos).ToString("#.##") + " ");
            sb.Append("Area " + (areaCuadrados + areaCirculos + areaTriangulos).ToString("#.##"));
            return sb;
        }
    }
}
