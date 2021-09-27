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

            Console.WriteLine(QuestionClass.TESTModule(1));
            Console.WriteLine(QuestionClass.TESTModule(4));
            Console.WriteLine(QuestionClass.TESTModule(6));
            Console.WriteLine(QuestionClass.TESTModule(1.0f));
            Console.WriteLine(QuestionClass.TESTModule(2.0f));
            Console.WriteLine(QuestionClass.TESTModule(5.0f));
            Console.WriteLine(QuestionClass.TESTModule("samuel"));
            Console.WriteLine(QuestionClass.TESTModule("#"));
        }
    }
}
