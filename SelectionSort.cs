using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[] { 999, 887, 776, 701, 651, 600, 566, 514, 439, 400, 369, 325, 204, 200, 167, 104, 99, 89, 71, 60, 50, 40, 30, 20, 10 };

            ShowNumbers(numbers);
            ShowNumbers(SelectionSort(numbers));
            Console.ReadKey();
        }

        public static int[] SelectionSort(int[] numbers)
        {
            int indexMin, temp;

            for (int i = 0; i < numbers.Length - 1; i++)
            {

                indexMin = i;

                for (int j = i + 1; j < numbers.Length; j++)
                {

                    if (numbers[j] < numbers[indexMin])
                    {
                        indexMin = j;
                    }

                }

                if (indexMin != i)
            {
                temp = numbers[i];
                    numbers[i] = numbers[indexMin];
                    numbers[indexMin] = temp;
            }

        }

            return numbers;


        }

        public static void ShowNumbers(int[] numbers)
            {

            foreach (int number in numbers)
            {
            Console.Write(number + " ");
            }
              Console.WriteLine();


            }
    }
}
