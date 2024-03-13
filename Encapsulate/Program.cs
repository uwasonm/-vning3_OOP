namespace Encapsulate
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Person person1 = new Person();
                /*Person person2 = new Person(30, "Sol", "SMKSMK", 175, 75);*/

                person1.Age = 25;
                person1.FName = "Sol45678910";
                person1.LName = "NKGN";
                person1.Height = 180;
                person1.Weight = 90;
                Console.WriteLine(person1.Age);
                Console.WriteLine(person1.FName);
                Console.WriteLine(person1.LName);
                Console.WriteLine(person1.Height);
                Console.WriteLine(person1.Weight);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                //throw;  
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);

            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally
            {
            }
        }


        //abstract class PersonHandler()
        //{

        //}
    }


}
