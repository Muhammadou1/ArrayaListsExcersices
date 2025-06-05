using System.Xml.Linq;

namespace ArraysListsExcersise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Numbers");
            string input = Console.ReadLine();
            char[] newNum = input.ToCharArray();
            Array.Reverse(newNum);
            Console.WriteLine(newNum);

            //Console.WriteLine("Enter your name");
            //string input = Console.ReadLine();
            //char[] newName = input.ToCharArray();
            //Array.Reverse(newName);
            //Console.WriteLine(newName);

        }
    }
}
