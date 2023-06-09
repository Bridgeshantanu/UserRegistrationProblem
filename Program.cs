using System.Text.RegularExpressions;
namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();
            Console.WriteLine(name);

            //string namepattern = "^[A-Z]{1}[a-z]{2,}$";
            //string namepattern = "^[a-z]{3,}[ ][A-Z]{1}[a-z]{2,}$";
            //string namepattern = "^[0-9a-zA-Z]+[.][0-9a-zA_z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}$";
            string namepattern = "^[0-9]{2}[ ][0-9]{10}$";
            Regex regex = new Regex(namepattern);
            if (regex.IsMatch(name))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Valid");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("invald");
                Console.ResetColor();
            }
        }
    }
}