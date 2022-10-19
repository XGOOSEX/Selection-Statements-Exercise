using System.Reflection.Metadata.Ecma335;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            //var favNumber = 2; 

            var r = new Random();
            var favNumber = r.Next(1,10);

            Console.WriteLine("Try to guess my favorite number between 1 & 10."); 
            
            var userInput = int.Parse(Console.ReadLine());

            if (userInput == favNumber)
                Console.WriteLine("You got it!!!");

            if (userInput < favNumber)
                Console.WriteLine("Too low.");

            else if (userInput > favNumber)
                Console.WriteLine("Too high.");

            else Console.WriteLine("nevermind.");
        }
    }
}
