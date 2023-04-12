using Clase2.Logica;
using Xunit;

namespace Clase2.Tests;

public class DibujadorPalabraTest
{
    [Fact]
    public void DibujarPalabra_DibujaPalabraConGuiones()
    {
        // Arrange
        var letrasAdivinadas = new List<string>();
        var dibujadorPalabra = new DibujadorPalabra(letrasAdivinadas);
        var palabraElegida = "hola";
        var palabraEsperada = "_ _ _ _";

        // Act
        var palabraADibujar = dibujadorPalabra.ObtenerDibujoPalabra(palabraElegida);

        // Assert
        Assert.Equal(palabraEsperada, palabraADibujar);
    }
    [Fact]
    public void DibujarPalabra_DibujaPalabraConGuionesYLetras()
    {
        // Arrange
        var letrasAdivinadas = new List<string> { "h", "o", "a" };
        var dibujadorPalabra = new DibujadorPalabra(letrasAdivinadas);
        var palabraElegida = "hola";
        var palabraEsperada = "h o _ a";

        // Act
        var palabraADibujar = dibujadorPalabra.ObtenerDibujoPalabra(palabraElegida);

        // Assert
        Assert.Equal(palabraEsperada, palabraADibujar);
    }

    [Fact]
    public void DibujarPalabra_DibujaPalabraConGuionesYLetrasRepetidas()
    {
        // Arrange
        var letrasAdivinadas = new List<string> { "e", "o" };
        var dibujadorPalabra = new DibujadorPalabra(letrasAdivinadas);
        var palabraElegida = "tenedor";
        var palabraEsperada = "_ e _ e _ o _";

        // Act
        var palabraADibujar = dibujadorPalabra.ObtenerDibujoPalabra(palabraElegida);

        // Assert
        Assert.Equal(palabraEsperada, palabraADibujar);
    }
}