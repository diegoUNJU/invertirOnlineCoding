using System.Text;
using CodingChallenge.Data.Classes.Comun;

namespace CodingChallenge.Data.Classes.Idiomas
{
    public class Ingles: IIdioma
    {
        public StringBuilder Cabecera(int formasCount)
        {
            var sb = new StringBuilder();
            if (formasCount == 0)
            {
                return sb.Append("<h1>Empty list of shapes!</h1>");
            }
            return sb.Append("<h1>Shapes report</h1>");

        }

        public string ObtenerLinea(int cantidad, decimal area, decimal perimetro, TipoFiguras tipoFiguras)
        {
            return cantidad != 0 ?  $"{cantidad} {TraducirForma(tipoFiguras, cantidad)} | Area {area:#.##} | Perimeter {perimetro:#.##} <br/>": "";
        }

        public string TraducirForma(TipoFiguras tipoFiguras, int cantidad)
        {
            switch (tipoFiguras)
            {
                case TipoFiguras.Cuadrado: return cantidad == 1 ? "Square" : "Squares";
                case TipoFiguras.Circulo: return cantidad == 1 ? "Circle" : "Circles";
                case TipoFiguras.TrianguloEquilatero: return cantidad == 1 ? "Triangle" : "Triangles";
                default: return string.Empty;
            }
        }

        public StringBuilder TraducirTotal(int numeroCuadrados, int numeroCirculos, int numeroTriangulos, decimal areaCuadrados, decimal areaCirculos, decimal areaTriangulos, decimal perimetroCuadrados, decimal perimetroCirculos, decimal perimetroTriangulos)
        {
            var sb = new StringBuilder();
            sb.Append("TOTAL:<br/>");
            sb.Append(numeroCuadrados + numeroCirculos + numeroTriangulos + " " + "shapes" + " ");
            sb.Append("Perimeter " + (perimetroCuadrados + perimetroTriangulos + perimetroCirculos).ToString("#.##") + " ");
            sb.Append("Area " + (areaCuadrados + areaCirculos + areaTriangulos).ToString("#.##"));
            return sb;
        }
    }
}
