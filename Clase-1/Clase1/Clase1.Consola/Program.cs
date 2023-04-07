// See https://aka.ms/new-console-template for more information


//CalculadoraEjercicio.Ejecutar();
//await ChatGPTEjercicio.Ejecutar();
//Bola8Magica.Ejecutar();

var api = new OpenAI_API.OpenAIAPI("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");
var chat = api.Chat.CreateConversation();
chat.AppendUserInput("crea una clase llamada perrro que tenga tres metodos en el leguaje java");
var response = await chat.GetResponseFromChatbotAsync();
//var result = await api.Completions.CreateCompletionAsync("crea una clase llamada perrro que tenga tres metodos");
Console.WriteLine(response);