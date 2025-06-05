namespace ArraysListsExcersises4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            while (true)
            {
                Console.Write("Enter a number or type quit to exit ");
                string input = Console.ReadLine();
                if(input.ToLower() == "quit")
                    break;
                numbers.Add(Convert.ToInt32(input));
            }
            Console.WriteLine("Numbers Entered");
            foreach(int num in numbers)
                Console.WriteLine(num);

            List<int> uniques = new List<int>();
            foreach (int num in numbers)
            {
                if(!uniques.Contains(num))
                    uniques.Add(num);
            }
            Console.WriteLine("Unique Numbers");
            foreach(int num in uniques)
                Console.WriteLine(num);
        }
    }
    
}
