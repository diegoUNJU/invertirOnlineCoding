using CodingChallenge.Data.Classes.Comun;
using System.Text;

namespace CodingChallenge.Data.Classes.Idiomas
{
    public class Frances : Idioma
    {

        public override StringBuilder Cabecera(int formasCount)
        {
            var sb = new StringBuilder();
            if (formasCount == 0)
            {
                return sb.Append("<h1>Liste vide de formes!</h1>");
            }
            return sb.Append("<h1>Rapport de formulaire</h1>");
        }

        public override string ObtenerLinea(int cantidad, decimal area, decimal perimetro, TipoFiguras tipoFiguras)
        {
            return cantidad != 0 ? $"{cantidad} {TraducirForma(tipoFiguras, cantidad)} | Aire {area:#.##} | Périmètre {perimetro:#.##} <br/>" : "";
        }

        public override string TraducirForma(TipoFiguras tipoFiguras, int cantidad)
        {
            switch (tipoFiguras)
            {
                case TipoFiguras.Cuadrado: return cantidad == 1 ? "Carré" : "Carrés";
                case TipoFiguras.Circulo: return cantidad == 1 ? "Cercle" : "Cercles";
                case TipoFiguras.TrianguloEquilatero: return cantidad == 1 ? "Triangle" : "Triangles";
                case TipoFiguras.Trapecio: return cantidad == 1 ? "Trapèze" : "Trapézoïdes";
                default: return string.Empty;

            }
        }

        public override StringBuilder TraducirTotal(int numeroCuadrados, int numeroCirculos, int numeroTriangulos, int numeroTrapecios, decimal areaCuadrados, decimal areaCirculos, decimal areaTriangulos, decimal areaTrapecios, decimal perimetroCuadrados, decimal perimetroCirculos, decimal perimetroTriangulos, decimal perimetroTrapecios)
        {
            var sb = new StringBuilder();
            sb.Append("TOTAL:<br/>");
            sb.Append(numeroCuadrados + numeroCirculos + numeroTriangulos + numeroTrapecios + " " + "formes" + " ");
            sb.Append("Périmètre " + (perimetroCuadrados + perimetroTriangulos + perimetroCirculos + perimetroTrapecios).ToString("#.##") + " ");
            sb.Append("Aire " + (areaCuadrados + areaCirculos + areaTriangulos + areaTrapecios).ToString("#.##"));
            return sb;
        }
    }
}
