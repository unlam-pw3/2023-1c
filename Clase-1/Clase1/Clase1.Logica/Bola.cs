using System.Collections;

namespace Clase1.Logica;

public class Bola{

    ArrayList answers = new ArrayList();

    public Bola() {
        fillAnswers();
    }

    private void fillAnswers() {
             
        answers.Add("Es cierto.");
        answers.Add("Es decididamente así.");
        answers.Add("Sin lugar a dudas.");
        answers.Add("Sí, definitivamente.");
        answers.Add("Puedes confiar en ello.");

        answers.Add("Como yo lo veo, sí.");
        answers.Add("Lo más probable.");
        answers.Add("Perspectiva buena.");
        answers.Add("Las señales apuntan a que sí.");
        
        answers.Add("Respuesta confusa, vuelve a intentarlo.");
        answers.Add("Vuelve a preguntar más tarde.");
        answers.Add("Mejor no decirte ahora.");
        answers.Add("No se puede predecir ahora.");
        answers.Add("Concéntrate y vuelve a preguntar.");
        
        answers.Add("No cuentes con ello.");
        answers.Add("Mi respuesta es no.");
        answers.Add("Mis fuentes dicen que no.");
        answers.Add("Las perspectivas no son muy buenas.");
        answers.Add("Muy dudoso.");
    }


    public void Agitar()
    {
       String resp = (String)answers[getRandomNumber()];
        Console.WriteLine(resp);
    }

    private int getRandomNumber(){
        Random r = new Random();
        int rInt = r.Next(0, answers.Count);
        return rInt;
    }
}
