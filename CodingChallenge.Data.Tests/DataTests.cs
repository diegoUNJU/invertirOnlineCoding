using CodingChallenge.Data.Classes;
using CodingChallenge.Data.Classes.FormasGeometricas;
using CodingChallenge.Data.Classes.Idiomas;
using NUnit.Framework;
using System.Collections.Generic;


namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                Reporte.Imprimir(new List<Geometrica>(), new Castellano()));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                Reporte.Imprimir(new List<Geometrica>(), new Ingles()));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnFrances()
        {
            Assert.AreEqual("<h1>Liste vide de formes!</h1>",
                Reporte.Imprimir(new List<Geometrica>(), new Frances()));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<Geometrica> { new Cuadrado(5) };

            var resumen = Reporte.Imprimir(cuadrados, new Castellano());

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<Geometrica>
            {
                new Cuadrado(5),
                new  Cuadrado(1),
                new  Cuadrado(3)
            };

            var resumen = Reporte.Imprimir(cuadrados, new Ingles());

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var formas = new List<Geometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new  Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m),
                new Trapecio(2, 1, 1)
            };

            var resumen = Reporte.Imprimir(formas, new Ingles());

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>1 Trapeze | Area 1,5 | Perimeter 5 <br/>TOTAL:<br/>8 shapes Perimeter 102,66 Area 93,15",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<Geometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new  Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m),
                new Trapecio(2, 1, 1)
            };

            var resumen = Reporte.Imprimir(formas, new Castellano());

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>1 Trapecio | Area 1,5 | Perimetro 5 <br/>TOTAL:<br/>8 formas Perimetro 102,66 Area 93,15",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnFrances()
        {
            var formas = new List<Geometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new  Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m),
                new Trapecio(2, 1, 1)
            };

            var resumen = Reporte.Imprimir(formas, new Frances());

            Assert.AreEqual(
                "<h1>Rapport de formulaire</h1>2 Carrés | Aire 29 | Périmètre 28 <br/>2 Cercles | Aire 13,01 | Périmètre 18,06 <br/>3 Triangles | Aire 49,64 | Périmètre 51,6 <br/>1 Trapèze | Aire 1,5 | Périmètre 5 <br/>TOTAL:<br/>8 formes Périmètre 102,66 Aire 93,15",
                resumen);
        }
    }
}
