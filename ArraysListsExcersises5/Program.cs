
namespace ArraysListsExcersises5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] elements;
            while (true)
            {
                Console.WriteLine("Enter numbers separated by commas");
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    elements = input.Split(',');
                    if (elements.Length >= 5)
                        break;
                }
                Console.WriteLine("Invalid List");
            }

            List<int> numbers = new List<int>();
            foreach (string number in elements)
                numbers.Add(Convert.ToInt32(number));
            Console.WriteLine(elements);

            List<int> smallest = new List<int>();
            while(smallest.Count < 3)
            {
                int min = numbers[0];
                foreach(int number in numbers)
                {
                    if(number < min)
                        min = number;
                }
                smallest.Add(min);
                numbers.Remove(min);
            }
            Console.WriteLine("The 3 smallest numbers");
            foreach(int number in  smallest)
                Console.WriteLine(number);

            //string[] elements;
            //while (true)
            //{
            //    Console.Write("Enter a list of comma-separated numbers: ");
            //    var input = Console.ReadLine();

            //    if (!String.IsNullOrWhiteSpace(input))
            //    {
            //        elements = input.Split(',');
            //        if (elements.Length >= 5)
            //            break;
            //    }

            //    Console.WriteLine("Invalid List");
            //}

            //var numbers = new List<int>();
            //foreach (var number in elements)
            //    numbers.Add(Convert.ToInt32(number));

            //var smallests = new List<int>();
            //while (smallests.Count < 3)
            //{
            //    // Assume the first number is the smallest
            //    var min = numbers[0];
            //    foreach (var number in numbers)
            //    {
            //        if (number < min)
            //            min = number;
            //    }
            //    smallests.Add(min);

            //    numbers.Remove(min);
            //}

            //Console.WriteLine("The 3 smallest numbers are: ");
            //foreach (var number in smallests)
            //    Console.WriteLine(number);

        }
    }
}
