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

            string namepattern = "^[A-Z]{1}[a-z]{2,}$";
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