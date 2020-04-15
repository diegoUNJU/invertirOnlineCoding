/*
 * Refactorear la clase para respetar principios de programación orientada a objetos. Qué pasa si debemos soportar un nuevo idioma para los reportes, o
 * agregar más formas geométricas?
 *
 * Se puede hacer cualquier cambio que se crea necesario tanto en el código como en los tests. La única condición es que los tests pasen OK.
 *
 * TODO: Implementar Trapecio/Rectangulo, agregar otro idioma a reporting.
 * */

using CodingChallenge.Data.Classes.Comun;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenge.Data.Classes
{
    public class Reporte
    {

        public static string Imprimir(List<IGeometrica> formas, IIdioma idioma)
        {
            var sb = new StringBuilder();
            sb.Append(idioma.Cabecera(formas.Count));
            if (formas.Any())
            {
                sb.Append(Informe(formas, idioma));
            }

            return sb.ToString();
        }

        private static StringBuilder Informe(List<IGeometrica> formas, IIdioma idioma)
        {
            //TODO se debe mejorar este metodo.
            var sb = new StringBuilder();
            var numeroCuadrados = 0;
            var numeroCirculos = 0;
            var numeroTriangulos = 0;

            var areaCuadrados = 0m;
            var areaCirculos = 0m;
            var areaTriangulos = 0m;

            var perimetroCuadrados = 0m;
            var perimetroCirculos = 0m;
            var perimetroTriangulos = 0m;

            for (var i = 0; i < formas.Count; i++)
            {
                if (formas[i].TipoFiguras == TipoFiguras.Cuadrado)
                {
                    numeroCuadrados++;
                    areaCuadrados += formas[i].CalcularArea(formas[i].Lado);
                    perimetroCuadrados += formas[i].CalcularPerimetro(formas[i].Lado);
                }
                if (formas[i].TipoFiguras == TipoFiguras.Circulo)
                {
                    numeroCirculos++;
                    areaCirculos += formas[i].CalcularArea(formas[i].Lado);
                    perimetroCirculos += formas[i].CalcularPerimetro(formas[i].Lado);
                }
                if (formas[i].TipoFiguras == TipoFiguras.TrianguloEquilatero)
                {
                    numeroTriangulos++;
                    areaTriangulos += formas[i].CalcularArea(formas[i].Lado);
                    perimetroTriangulos += formas[i].CalcularPerimetro(formas[i].Lado);
                }
            }

            sb.Append(idioma.ObtenerLinea(numeroCuadrados, areaCuadrados, perimetroCuadrados, TipoFiguras.Cuadrado));
            sb.Append(idioma.ObtenerLinea(numeroCirculos, areaCirculos, perimetroCirculos, TipoFiguras.Circulo));
            sb.Append(idioma.ObtenerLinea(numeroTriangulos, areaTriangulos, perimetroTriangulos, TipoFiguras.TrianguloEquilatero));

            // FOOTER
            sb.Append(idioma.TraducirTotal(numeroCuadrados, numeroCirculos, numeroTriangulos, areaCuadrados, areaCirculos, areaTriangulos, perimetroCuadrados, perimetroCirculos, perimetroTriangulos));

            return sb;
        }
    }
}
