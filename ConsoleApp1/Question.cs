using System;
using System.Collections.Generic;

namespace ConsoleApp1
{

    public class Question {

        public static int counter = 1;
        public string Text { get; set; }
        public string Answer { get; set; }
        public int Difficulty { get; set; }
        public Category Category { get; set; }

        public void checkAnswer(string Response)
        {
            Response = Response.ToLower();
            if (Response.Equals(Answer))
            {
                Console.WriteLine("Correct!");
                Console.WriteLine("Het antwoord was " + Answer + " en jij gaf als antwoord: " + Response);
            } else
            {
                Console.WriteLine("Jammer!");
                Console.WriteLine("Het antwoord was " + Answer + " en jij gaf als antwoord: " + Response);
            }
            Console.WriteLine("");

        }
        public static void askQuestion(Question question)
        {
            Console.WriteLine("Vraag " + counter + ":");
            Console.WriteLine(question.Text);

            if (question.GetType() == typeof(ChoiceQuestion))
            {
                ChoiceQuestion choiceQuestion = question as ChoiceQuestion;
                choiceQuestion.display();
            }

            Console.WriteLine("Jouw antwoord: ");

            string response = Console.ReadLine();

            question.checkAnswer(response);
            counter++;
        }

    }
}
