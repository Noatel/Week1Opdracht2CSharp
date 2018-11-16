using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Question q = new Question("Wat voor vorm heeft de aarde","Rond");

            Console.WriteLine(q.text);
            Console.WriteLine("Your answer: ");

            string response = Console.ReadLine();

            Console.WriteLine(q.checkAnswer(response));

            ChoiceQuestion first = new ChoiceQuestion("Wat voor vorm heeft de aarde","Donut",false);
            first.addChoice("Kubus", false);
            first.addChoice("Rond", true);
            first.addChoice("Plat", false);

            askQuestion(first);
        }

        public static void askQuestion(ChoiceQuestion q)
        {
            q.display();
            Console.WriteLine("Your answer: ");

            string response = Console.ReadLine();

            Console.WriteLine(q.checkAnswer(response));
        }
    }
}
