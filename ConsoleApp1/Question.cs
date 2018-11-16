using System;
namespace ConsoleApp1
{
    public class Question {

        public string text { get; set; }
        public string answer { get; set; }

        public Question(string text, string answer)
        {
            this.text = text;
            this.answer = answer;
        }

        public bool checkAnswer(string response)
        {
            return response.Equals(answer);
        }
        
    }
}
