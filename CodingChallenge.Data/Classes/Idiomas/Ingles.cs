using CodingChallenge.Data.Classes.Comun;
using System.Text;

namespace CodingChallenge.Data.Classes.Idiomas
{
    public class Ingles : Idioma
    {
        public override StringBuilder Cabecera(int formasCount)
        {
            var sb = new StringBuilder();
            if (formasCount == 0)
            {
                return sb.Append("<h1>Empty list of shapes!</h1>");
            }
            return sb.Append("<h1>Shapes report</h1>");

        }

        public override string ObtenerLinea(int cantidad, decimal area, decimal perimetro, TipoFiguras tipoFiguras)
        {
            return cantidad != 0 ? $"{cantidad} {TraducirForma(tipoFiguras, cantidad)} | Area {area:#.##} | Perimeter {perimetro:#.##} <br/>" : "";
        }

        public override string TraducirForma(TipoFiguras tipoFiguras, int cantidad)
        {
            switch (tipoFiguras)
            {
                case TipoFiguras.Cuadrado: return cantidad == 1 ? "Square" : "Squares";
                case TipoFiguras.Circulo: return cantidad == 1 ? "Circle" : "Circles";
                case TipoFiguras.TrianguloEquilatero: return cantidad == 1 ? "Triangle" : "Triangles";
                case TipoFiguras.Trapecio: return cantidad == 1 ? "Trapeze" : "Trapezoids";
                default: return string.Empty;
            }
        }

        public override StringBuilder TraducirTotal(int numeroCuadrados, int numeroCirculos, int numeroTriangulos, int numeroTrapecios, decimal areaCuadrados, decimal areaCirculos, decimal areaTriangulos, decimal areaTrapecios, decimal perimetroCuadrados, decimal perimetroCirculos, decimal perimetroTriangulos, decimal perimetroTrapecios)
        {
            var sb = new StringBuilder();
            sb.Append("TOTAL:<br/>");
            sb.Append(numeroCuadrados + numeroCirculos + numeroTriangulos + numeroTrapecios + " " + "shapes" + " ");
            sb.Append("Perimeter " + (perimetroCuadrados + perimetroTriangulos + perimetroCirculos + perimetroTrapecios).ToString("#.##") + " ");
            sb.Append("Area " + (areaCuadrados + areaCirculos + areaTriangulos + areaTrapecios).ToString("#.##"));
            return sb;
        }
    }
}
