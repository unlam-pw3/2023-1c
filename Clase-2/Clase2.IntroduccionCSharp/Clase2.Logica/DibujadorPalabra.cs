namespace Clase2.Logica;

public class DibujadorPalabra
{
    private readonly IList<string> letrasAdivinadas;

    public DibujadorPalabra(IList<string> letrasAdivinadas)
    {
        this.letrasAdivinadas = letrasAdivinadas;
    }

    public void DibujarPalabra(string palabraElegida)
    {
        string palabraADibujar = ObtenerDibujoPalabra(palabraElegida);
        Console.WriteLine(palabraADibujar);
    }

    public string ObtenerDibujoPalabra(string palabraElegida)
    {
        var palabraADibujar = palabraElegida.Select(letra => FueLetraAdivinada(letra) ? $"{letra} " : "_ ");

        return string.Concat(palabraADibujar).Trim();
    }

    private bool FueLetraAdivinada(char letra)
    {
        return letrasAdivinadas.Contains(letra.ToString(), StringComparer.OrdinalIgnoreCase);
    }

}
