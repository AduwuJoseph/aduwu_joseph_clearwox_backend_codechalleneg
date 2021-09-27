using System;

namespace ClearwoxCodeChallenge.Consol
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Clearwox Code Challenge Question 6!");

            string lines = string.Join(Environment.NewLine, QuestionClass.NameList);
            Console.WriteLine(lines);
        }
    }
}
