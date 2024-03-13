namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine();
        }
    }


    abstract class UserError
    {
        static string UEMessage()
        {
            string message="Error";
            return message;
        }
    }

    class NumericInputError : UserError
    {

    }

    class TextInptError : UserError
    {

    }
}

