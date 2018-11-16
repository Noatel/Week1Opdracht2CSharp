using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class ChoiceQuestion : Question
    {

        public bool correct { get; set; }
        public List<string> choices = new List<string>();

        public ChoiceQuestion(string text, string answer, bool correct) : base(text, answer)
        {
            this.correct = correct;
            choices.Add(answer);
        }

        public void addChoice(string choice, bool correct) {
           
            choices.Add(choice);

            if(correct){
                this.answer = choice;
            }
        }

        public void display()
        {
            Console.WriteLine(text);

            for (int i = 0; i < choices.Count; i++)
            {
                int choiceNumber = i + 1;
                Console.WriteLine(choiceNumber + ": " + choices[i]);
            }
        }
    }
}
