namespace ArraysListExcersices3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<int> numbers = new List<int>();
            Console.WriteLine("Enter 5 non-repeating numbers");
            while (numbers.Count < 5)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                if(numbers.Contains(input))
                {
                    Console.WriteLine("Number was already entered");
                    continue;
                }
                numbers.Add(input);
            }
            Console.WriteLine("Numbers Entered");
            foreach (int number in numbers)
                Console.WriteLine(number);

            Console.WriteLine("Numbers Sorted");
            numbers.Sort();
            foreach (int number in numbers)
                Console.WriteLine(number);












































            //List<int> numbers = new List<int>();
            //    Console.WriteLine("Enter 5 numbers");
            //while (numbers.Count < 5)
            //{
            //    int input = Convert.ToInt32(Console.ReadLine());
            //    if (numbers.Contains(input))
            //    {
            //        Console.WriteLine("Number was already entered");
            //        continue;
            //    }
            //        numbers.Add(input);
            //}
            //    Console.WriteLine("Numbers Entered");
            //    foreach (int number in numbers)
            //    {
            //        Console.WriteLine(number);
            //    }
            //    numbers.Sort();
            //    Console.WriteLine("Sorted Numbers");
            //    foreach (int number in numbers)
            //        Console.WriteLine(number);
        }
    }
}
