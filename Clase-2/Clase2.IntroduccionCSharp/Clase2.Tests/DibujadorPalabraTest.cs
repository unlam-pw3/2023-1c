using Clase2.Logica;
using Xunit;

namespace Clase2.Tests
{
    public class DibujadorPalabraTest
    {
        [Fact]
        public void DibujarPalabra_DibujaPalabraConGuiones()
        {
            // Arrange
            var dibujadorPalabra = new DibujadorPalabra();
            var palabraElegida = "hola";
            var letrasAdivinadas = new List<string>();
            var palabraEsperada = "_ _ _ _";
            // Act
            var palabraADibujar = dibujadorPalabra.ObtenerDibujoPalabra(palabraElegida, letrasAdivinadas);
            // Assert
            Assert.Equal(palabraEsperada, palabraADibujar);
        }
        [Fact]
        public void DibujarPalabra_DibujaPalabraConGuionesYLetras()
        {
            // Arrange
            var dibujadorPalabra = new DibujadorPalabra();
            var palabraElegida = "hola";
            var letrasAdivinadas = new List<string> { "h", "o", "a" };
            var palabraEsperada = "h o _ a";
            // Act
            var palabraADibujar = dibujadorPalabra.ObtenerDibujoPalabra(palabraElegida, letrasAdivinadas);
            // Assert
            Assert.Equal(palabraEsperada, palabraADibujar);
        }

        [Fact]
        public void DibujarPalabra_DibujaPalabraConGuionesYLetrasRepetidas()
        {
            // Arrange
            var dibujadorPalabra = new DibujadorPalabra();
            var palabraElegida = "tenedor";
            var letrasAdivinadas = new List<string> { "e", "o" };
            var palabraEsperada = "_ e _ e _ o _";
            // Act
            var palabraADibujar = dibujadorPalabra.ObtenerDibujoPalabra(palabraElegida, letrasAdivinadas);
            // Assert
            Assert.Equal(palabraEsperada, palabraADibujar);
        }

        [Fact]
        public void ObtenerPalabraParaPrincipiantes()
        {
            // Arrange 
            var dibujadorPalabra = new DibujadorPalabra();
            var letrasAdivinadas = new List<string> {};
            // Act
            var palabraADibujar = JuegoAhorcado.SelectorDeNivel("P", letrasAdivinadas);
            //var palabraADibujar = dibujadorPalabra.ObtenerDibujoPalabra(palabraElegida, letrasAdivinadas);
            // Assert
            Assert.NotEmpty(letrasAdivinadas[0]);
            Assert.True(palabraADibujar.Length<=6);
        }

        [Fact]
        public void ObtenerPalabraParaAvanzado()
        {
            // Arrange 
            
            var letrasAdivinadas = new List<string> { };
         
            // Act
            var palabraADibujar = JuegoAhorcado.SelectorDeNivel("A", letrasAdivinadas);
            //var palabraADibujar = dibujadorPalabra.ObtenerDibujoPalabra(palabraElegida, letrasAdivinadas);
            // Assert
            Assert.Empty(letrasAdivinadas);
            Assert.True(palabraADibujar.Length >6);
        }
    }
}