using System.Reflection.Metadata.Ecma335;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            //var favNumber = 2; 

            //var r = new Random();
            //var favNumber = r.Next(1,10);

            //Console.WriteLine("Try to guess my favorite number between 1 & 10."); 

            //var userInput = int.Parse(Console.ReadLine());

            //if (userInput == favNumber)
            //    Console.WriteLine("You got it!!!");

            //if (userInput < favNumber)
            //    Console.WriteLine("Too low.");

            //else if (userInput > favNumber)
            //    Console.WriteLine("Too high.");

            //else Console.WriteLine("nevermind.");

            Console.WriteLine("What is your favorite school subject?");

            String favSubject = Console.ReadLine().ToLower();
            
            switch(favSubject)
            {
                case "history":
                    Console.WriteLine("Fun!!!");
                    break;
                case "math":
                    Console.WriteLine("Nerd....");
                    break;
                case "science":
                    Console.WriteLine("Bill Nye would be proud.");
                    break;
                case "english":
                    Console.WriteLine("Shakespear would be proud. ");
                    break;
                case "pe":
                    Console.WriteLine("You are a bro. ");
                    break;



            }
            
        }



    }
}
