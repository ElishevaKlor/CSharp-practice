using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Part_Two___Algorithmics
{
    class ex3
    {

        public static void AnalyzeNumbers()
        {
            List<double> numbers = new List<double>();
            double number;
            Console.WriteLine("Enter numbers (stop with -1)");
            while(true)
            {
                string input = Console.ReadLine();
                if(!double.TryParse(input,out number))
                {
                    Console.WriteLine("Input not valid, try again.");
                    continue;
                }
                if (number == -1)
                    break;
                numbers.Add(number);
            }
            if(numbers.Count()==0)
            {
                Console.WriteLine("No numbers entered.");
                return;
            }
            double average = numbers.Average();
            int positiveCount = numbers.Count(n => n > 0);
            List<Double> sortedNumbers = numbers.OrderBy(n=>n).ToList();
            Console.WriteLine($"Average: {average}");
            Console.WriteLine($"Number of positive numbers {positiveCount}");
            Console.WriteLine($"sorted numbers:");
            sortedNumbers.ForEach(n => Console.Write(n+" "));
        }

        //private static void Main(string[] args)
        //{
        //    AnalyzeNumbers();
        //}
    }
}
