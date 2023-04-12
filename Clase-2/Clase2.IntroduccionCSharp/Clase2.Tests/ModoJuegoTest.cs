using Clase2.Logica;
using Xunit;

namespace Clase2.Tests
{
	public class ModoJuegoTest
    {
        [Fact]
        public void ModoJuego_ObtenerPalabraModoDeJuegoPrincipiante()
        {
            // Arrange
            var obtenerPalabra = new JuegoAhorcado();
            int tamMinPalabra = 1;
            int tamMaxPalabra = 6;
            int modoJuegoPrincipiante = 1;
            // Act
            string palabraObtenida = obtenerPalabra.ObtenerPalabraSegunModoDeJuego(modoJuegoPrincipiante);
            // Assert
            Assert.InRange(palabraObtenida.Length, tamMinPalabra, tamMaxPalabra);
        }

        [Fact]
        public void ModoJuego_ObtenerPalabraModoDeJuegoAvanzado()
        {
            // Arrange
            var obtenerPalabra = new JuegoAhorcado();
            int tamMinPalabra = 7;
            int modoJuegoAvanzado = 2;
            // Act
            string palabraObtenida = obtenerPalabra.ObtenerPalabraSegunModoDeJuego(modoJuegoAvanzado);
            // Assert
            Assert.True(tamMinPalabra <= palabraObtenida.Length);
        }

    }
}
