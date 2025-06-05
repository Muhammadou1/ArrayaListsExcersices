namespace ArrayaListsExcersices
{
    internal class Program
    {
        static void Main(string[] args)
        {
          List<string> names = new List<string>();
            while (true)
            {
                Console.WriteLine("Type different names or press ENTER to exit");
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                break;
                names.Add(input);
            }
            if(names.Count == 0)
                Console.WriteLine();
            else if (names.Count == 1)
                Console.WriteLine("{0} liked your post", names[0]);
            else if (names.Count == 2)
                Console.WriteLine("{0} and {1} liked your post", names[0], names[1]);
            else if (names.Count > 2)
                Console.WriteLine("{0} {1} and {2} other liked your post", names[0], names[1], names.Count - 2);
        }
    }
}

