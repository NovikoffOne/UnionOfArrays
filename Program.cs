using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnionOfArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] numbers1 = { "1", "2", "1" };
            string[] numbers2 = { "3", "2", "4", "6"};
            List<string> unionNumbers = new List<string>();

            MergeArrays(unionNumbers, numbers1, numbers2);

            Draw(unionNumbers);
        }

        static void MergeArrays(List<string> unionNumbers, string[] array1, string[] array2)
        {
            List<string> tempNumbers1 = new List<string>(array1);
            List<string> tempNumbers2 = new List<string>(array2);

            TryAddNumber(tempNumbers1, tempNumbers2);
            TryAddNumber(unionNumbers, tempNumbers1);
        }

        static void TryAddNumber(List<string> numbers, List<string> iterable)
        {
            foreach (var number in iterable)
            {
                if (numbers.Contains(number) == false)
                {
                    numbers.Add(number);
                }
            }
        }

        static void Draw(List<string> numbers)
        {
            foreach (string number in numbers)
            {
                Console.Write(number + ' ');
            }
        }
    }
}
