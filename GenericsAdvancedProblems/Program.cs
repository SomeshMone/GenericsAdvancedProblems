using System;
namespace GenericsAdvancedProblems
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //int type
            Console.WriteLine("Integer Calucaltor");
            GenericCalculator<int> intcalculator = new GenericCalculator<int>();
            Console.WriteLine("Addition: " + intcalculator.Add(5, 3));
            Console.WriteLine("Subtraction: " + intcalculator.Sub(5, 3));
            Console.WriteLine("Multuplication: " + intcalculator.Mul(5, 3));
            Console.WriteLine("Division: " + intcalculator.Div(5, 3));


            //float type
            Console.WriteLine("Float Calculator");
            GenericCalculator<float>floatcalculator = new GenericCalculator<float>();
            Console.WriteLine("Addition: "+floatcalculator.Add(5.44f, 3.33f));
            Console.WriteLine("Addition: " + floatcalculator.Sub(5.44f, 3.33f));
            Console.WriteLine("Addition: " + floatcalculator.Mul(5.44f, 3.33f));
            Console.WriteLine("Addition: " + floatcalculator.Div(5.44f, 3.33f));

            //GenericSorting

            List<int> numbers = new List<int> { 3, 1, 4, 1, 5, 9, 2, 6 };
            GenericSort<int>.Sort(numbers, (a, b) => a.CompareTo(b));
            // after sorting numbers are
            Console.WriteLine("after sorting numbers are");
            foreach(int i in numbers)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();

            //searching an element in numbers
            

            int index = GenericSearch.Search(numbers, x => x == 3);
            Console.WriteLine("The number 3 is found at index :" + index);

            //GenericFiltering
            List<int> evenNumbers = GenericFilter.Filter(numbers, x => x % 2 == 0);
            Console.WriteLine("Filtering even numbers");
            foreach(int i in evenNumbers)
            {
                Console.Write(i+ " ");
            }
            Console.ReadKey();

            Console.WriteLine("Generic Dictionary Implementation");
            GenericDictionary<string, int> dictionary = new GenericDictionary<string, int>();
            dictionary.Add("Somesh", 1);
            dictionary.Add("Lokesh", 2);
            dictionary.Add("Nandu", 3);
            foreach(var item in dictionary)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }


            // Stack LIFO
            Console.WriteLine("Generic Stack Implementation");
            GenericStack<int> stack = new GenericStack<int>();
            stack.Push(7);
            stack.Push(10);
            stack.Push(12);
            Console.WriteLine("Top Element in stack is " + stack.Pop());
            foreach(var item in stack)
            {
                Console.Write(item+ " ");
            }

        }

    }
}
