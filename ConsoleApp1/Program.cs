using System;

namespace ConsoleApp1
{
    class Program
    {
        public static int counter = 1;

        static void Main(string[] args)
        {
            //Add Categories
            Category Algemeen = new Category("Algemeen");
            Category Muziek = new Category("Muziek");
            Category Dieren = new Category("Dieren");

            Question Question1 = new Question("Wie had een hit met het nummer Relax, take it easy?", "Mika" , 3 , Muziek);

          
            ChoiceQuestion Question2 = new ChoiceQuestion("Wat voor vorm heeft de aarde", "Donut", 2, Algemeen, false);
            Question2.addChoice("Kubus", false);
            Question2.addChoice("Rond", true);
            Question2.addChoice("Plat", false);

            Question Question3 = new Question("Hebben Giraffen een blauwe tong?", "Ja", 1, Algemeen);


            askQuestion(Question1);
            askQuestion(Question2);
            askQuestion(Question3);
        }

        public static void askQuestion(Question question)
        {
            Console.WriteLine("Vraag "+ counter + ":");
            Console.WriteLine(question.Text);

            if (question.GetType() == typeof(ChoiceQuestion)){
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
