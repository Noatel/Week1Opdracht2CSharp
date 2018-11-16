using System;
namespace ConsoleApp1
{
    public class Question {

        public string Text { get; set; }
        public string Answer { get; set; }
        public int Difficulty { get; set; }
        public Category Category { get; set; }

        public Question(string Text, string Answer, int Difficulty, Category Category)
        {
            this.Text = Text;
            this.Answer = Answer.ToLower();
            this.Difficulty = Difficulty;
            this.Category = Category;
        }

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


    }
}
