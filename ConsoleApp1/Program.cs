using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        public static IList<Question> AllQuestions = new List<Question>();


        static void Main(string[] args)
        {
            //Add Categories
            Category Algemeen = new Category("Algemeen");
            Category Muziek = new Category("Muziek");
            Category Dieren = new Category("Dieren");

            //Add 4 Questions, 2 with Multiple choice answers
            Question Question1 = new Question() { Text = "Wie had een hit met het nummer Relax, take it easy?", Answer = "mika", Difficulty = 3, Category = Muziek };
            Question Question2 = new Question() { Text = "Hebben Giraffen een blauwe tong?", Answer = "ja", Difficulty = 2, Category = Dieren };

            ChoiceQuestion Question3 = new ChoiceQuestion() { Text = "Wat voor vorm heeft de aarde", Difficulty = 1, Category = Algemeen };
            Question3.addChoice("kubus", false);
            Question3.addChoice("rond", true);
            Question3.addChoice("plat", false);

            ChoiceQuestion Question4 = new ChoiceQuestion() { Text = "Bij welke temperatuur kookt water?", Difficulty = 3, Category = Algemeen };
            Question4.addChoice("25", false);
            Question4.addChoice("50", false);
            Question4.addChoice("75", false);
            Question4.addChoice("100", true);

            //Add Questions to the array
            AllQuestions.Add(Question1);
            AllQuestions.Add(Question2);
            AllQuestions.Add(Question3);
            AllQuestions.Add(Question4);

            //LINQ Sort
            var result = from s in AllQuestions
                         orderby s.Difficulty
                         select s;

            //Foreach sorted question in the var Result
            foreach(Question question in result)
            {
                //Ask a question
                Question.askQuestion(question);
            }
        }
    }
}
