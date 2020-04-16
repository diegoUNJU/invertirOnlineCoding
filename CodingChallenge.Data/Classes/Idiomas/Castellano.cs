using CodingChallenge.Data.Classes.Comun;
using System.Text;

namespace CodingChallenge.Data.Classes.Idiomas
{
    public class Castellano : Idioma
    {

        public override StringBuilder Cabecera(int formasCount)
        {
            var sb = new StringBuilder();
            if (formasCount == 0)
            {
                return sb.Append("<h1>Lista vacía de formas!</h1>");
            }
            return sb.Append("<h1>Reporte de Formas</h1>");
        }

        public override string ObtenerLinea(int cantidad, decimal area, decimal perimetro, TipoFiguras tipoFiguras)
        {
            return cantidad != 0 ? $"{cantidad} {TraducirForma(tipoFiguras, cantidad)} | Area {area:#.##} | Perimetro {perimetro:#.##} <br/>" : "";
        }

        public override string TraducirForma(TipoFiguras tipoFiguras, int cantidad)
        {
            switch (tipoFiguras)
            {
                case TipoFiguras.Cuadrado: return cantidad == 1 ? "Cuadrado" : "Cuadrados";
                case TipoFiguras.Circulo: return cantidad == 1 ? "Círculo" : "Círculos";
                case TipoFiguras.TrianguloEquilatero: return cantidad == 1 ? "Triángulo" : "Triángulos";
                case TipoFiguras.Trapecio: return cantidad == 1 ? "Trapecio" : "Trapecios";
                default: return string.Empty;

            }
        }

        public override StringBuilder TraducirTotal(int numeroCuadrados, int numeroCirculos, int numeroTriangulos, int numeroTrapecios, decimal areaCuadrados, decimal areaCirculos, decimal areaTriangulos, decimal areaTrapecios, decimal perimetroCuadrados, decimal perimetroCirculos, decimal perimetroTriangulos, decimal perimetroTrapecios)
        {
            var sb = new StringBuilder();
            sb.Append("TOTAL:<br/>");
            sb.Append(numeroCuadrados + numeroCirculos + numeroTriangulos + numeroTrapecios + " " + "formas" + " ");
            sb.Append("Perimetro " + (perimetroCuadrados + perimetroTriangulos + perimetroCirculos + perimetroTrapecios).ToString("#.##") + " ");
            sb.Append("Area " + (areaCuadrados + areaCirculos + areaTriangulos + areaTrapecios).ToString("#.##"));
            return sb;
        }
    }
}
