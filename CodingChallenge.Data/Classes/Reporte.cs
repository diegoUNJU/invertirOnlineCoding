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

        public static string Imprimir(List<Geometrica> formas, Idioma idioma)
        {
            var sb = new StringBuilder();
            sb.Append(idioma.Cabecera(formas.Count));
            if (formas.Any())
            {
                sb.Append(Informe(formas, idioma));
            }

            return sb.ToString();
        }

        private static StringBuilder Informe(List<Geometrica> formas, Idioma idioma)
        {
            //TODO se debe mejorar este metodo.
            var sb = new StringBuilder();
            var numeroCuadrados = 0;
            var numeroCirculos = 0;
            var numeroTriangulos = 0;
            var numeroTrapecios = 0;

            var areaCuadrados = 0m;
            var areaCirculos = 0m;
            var areaTriangulos = 0m;
            var areaTrapecios = 0m;

            var perimetroCuadrados = 0m;
            var perimetroCirculos = 0m;
            var perimetroTriangulos = 0m;
            var perimetroTrapecios = 0m;


            for (var i = 0; i < formas.Count; i++)
            {
                if (formas[i].TipoFigura == TipoFiguras.Cuadrado)
                {
                    numeroCuadrados++;
                    areaCuadrados += formas[i].CalcularArea();
                    perimetroCuadrados += formas[i].CalcularPerimetro();
                }
                if (formas[i].TipoFigura == TipoFiguras.Circulo)
                {
                    numeroCirculos++;
                    areaCirculos += formas[i].CalcularArea();
                    perimetroCirculos += formas[i].CalcularPerimetro();
                }
                if (formas[i].TipoFigura == TipoFiguras.TrianguloEquilatero)
                {
                    numeroTriangulos++;
                    areaTriangulos += formas[i].CalcularArea();
                    perimetroTriangulos += formas[i].CalcularPerimetro();
                }
                if (formas[i].TipoFigura == TipoFiguras.Trapecio)
                {
                    numeroTrapecios++;
                    areaTrapecios += formas[i].CalcularArea();
                    perimetroTrapecios += formas[i].CalcularPerimetro();
                }
            }

            sb.Append(idioma.ObtenerLinea(numeroCuadrados, areaCuadrados, perimetroCuadrados, TipoFiguras.Cuadrado));
            sb.Append(idioma.ObtenerLinea(numeroCirculos, areaCirculos, perimetroCirculos, TipoFiguras.Circulo));
            sb.Append(idioma.ObtenerLinea(numeroTriangulos, areaTriangulos, perimetroTriangulos, TipoFiguras.TrianguloEquilatero));
            sb.Append(idioma.ObtenerLinea(numeroTrapecios, areaTrapecios, perimetroTrapecios, TipoFiguras.Trapecio));

            // FOOTER
            sb.Append(idioma.TraducirTotal(numeroCuadrados, numeroCirculos, numeroTriangulos, numeroTrapecios, areaCuadrados, areaCirculos, areaTriangulos, areaTrapecios, perimetroCuadrados, perimetroCirculos, perimetroTriangulos, perimetroTrapecios));

            return sb;
        }
    }
}
