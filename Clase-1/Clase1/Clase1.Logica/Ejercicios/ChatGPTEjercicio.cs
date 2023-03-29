using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using OpenAI.GPT3;
using OpenAI.GPT3.Managers;
using OpenAI.GPT3.ObjectModels;
using OpenAI.GPT3.ObjectModels.RequestModels;

namespace Clase1.Logica.Ejercicios;


public static class ChatGPTEjercicio
{
    public async static Task Ejecutar()
    {
        string apiKey = "";

        var openAiService = new OpenAIService(new OpenAiOptions()
        {
            ApiKey = apiKey
        });

        openAiService.SetDefaultModelId(Models.Davinci);

        var completionResult = await openAiService.ChatCompletion.CreateCompletion(new ChatCompletionCreateRequest
        {
            Messages = new List<ChatMessage>
            {
                ChatMessage.FromUser(Console.ReadLine()),
            },
            Model = Models.Davinci,
            MaxTokens = 50//optional
        });
        if (completionResult.Successful)
        {
            Console.WriteLine(completionResult.Choices.First().Message.Content);
        }
        else
        {
            Console.WriteLine(completionResult.Error?.Message ?? "");
            Console.ReadLine();
        }

    }
}
