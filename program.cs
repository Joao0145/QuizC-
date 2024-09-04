using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Lista de perguntas e respostas
        var questions = new List<Question>
        {
            new Question("Qual é a capital da França?", "Paris"),
            new Question("Qual é a maior planeta do sistema solar?", "Júpiter"),
            new Question("Quem escreveu 'Dom Quixote'?", "Miguel de Cervantes")
        };

        int score = 0;

        foreach (var question in questions)
        {
            Console.WriteLine(question.Text);
            string userAnswer = Console.ReadLine();
            
            if (userAnswer.Equals(question.Answer, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Correto!");
                score++;
            }
            else
            {
                Console.WriteLine($"Incorreto! A resposta correta é {question.Answer}.");
            }

            Console.WriteLine(); // Adiciona uma linha em branco para separar as perguntas
        }

        Console.WriteLine($"Você acertou {score} de {questions.Count} perguntas.");
    }
}

public class Question
{
    public string Text { get; }
    public string Answer { get; }

    public Question(string text, string answer)
    {
        Text = text;
        Answer = answer;
    }
}
