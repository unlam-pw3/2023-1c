namespace Clase1.Bola8Magica;

public class Bola8Magica
{
    private string[] posiblesRespuestas;
    private Random random;
    public Bola8Magica()
    {
        this.posiblesRespuestas = new string[] { " Es cierto.", " Es decididamente así.", "Sin lugar a dudas.", "Sí, definitivamente.", "Puedes confiar en ello.", "Como yo lo veo, sí.", "Lo más probable.", "Perspectiva buena.", "Sí.", "Las señales apuntan a que sí.", "Respuesta confusa, vuelve a intentarlo.", "Vuelve a preguntar más tarde.", "Mejor no decirte ahora.", "No se puede predecir ahora.", "Concéntrate y vuelve a preguntar.", "No cuentes con ello.", "Mi respuesta es no.", "Mis fuentes dicen que no.", "Las perspectivas no son muy buenas.", "Muy dudoso." };
        this.random = new Random();
    }
    
    public string RespuestaMagica ()
    {
        if (this.posiblesRespuestas == null || this.posiblesRespuestas.Length == 0)
        {
            return null;
        }

        int index = this.random.Next(this.posiblesRespuestas.Length);

        return this.posiblesRespuestas[index];
    }

    public void agregarRespuesta(string newRespuesta)
    {
        //en c# no se puede agregar directamente un nuevo elemento
        string[] newArray = new string[this.posiblesRespuestas.Length + 1];

        //copia los elementos al nuevo array
        Array.Copy(this.posiblesRespuestas, newArray, this.posiblesRespuestas.Length);
        //sumo el nuevo elemento
        newArray[this.posiblesRespuestas.Length] = newRespuesta;
        //actualiza el array
        this.posiblesRespuestas = newArray;
    }

    public void sacarRespuesta(string respuestaASacar)
    {
        //nuevo array
        string[] newArray = new string[this.posiblesRespuestas.Length - 1];
        //sascamos el indice de la respuesta a sacar
        int indice = Array.IndexOf(this.posiblesRespuestas, respuestaASacar);
        // si el elemento a sacar se encuentra en el array
        if (indice > -1)  
        {
            // copia los elementos antes del elemento a sacar
            Array.Copy(this.posiblesRespuestas, 0, newArray, 0, indice);
            // copia los elementos después del elemento a sacar
            Array.Copy(this.posiblesRespuestas, indice + 1, newArray, indice, this.posiblesRespuestas.Length - indice - 1); 
            //actualiza el array
            this.posiblesRespuestas = newArray; 
        }
    }

}