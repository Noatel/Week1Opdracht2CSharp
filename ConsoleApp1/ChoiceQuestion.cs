using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class ChoiceQuestion : Question
    {

        public bool Correct { get; set; }
        public List<string> Choices = new List<string>();

        public ChoiceQuestion(string Text, string Answer, int Difficulty, Category Category, bool Correct) : base(Text, Answer, Difficulty, Category)
        {
            this.Correct = Correct;
            Choices.Add(Answer.ToLower());
        }

        public void addChoice(string Choice, bool Correct) {

            Choice = Choice.ToLower();

            Choices.Add(Choice);

            if(Correct){
                this.Answer = Choice;
            }
        }

        public void display()
        {
            for (int i = 0; i < Choices.Count; i++)
            {
                Console.WriteLine(Choices[i]);
            }
        }
    }
}
