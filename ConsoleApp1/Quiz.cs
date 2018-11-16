using System;
namespace ConsoleApp1
{
    public class Quiz
    {

        public Question()
        {
            text = "";
            answer = "";
        }

        public boolean checkAnswer(String response)
        {
            return response.equals(answer);
        }

    }
}
