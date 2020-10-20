using System;

namespace TestMaximumWithGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Maximum Test Using Generics!");

            ///<summary>
            ///Integer Calling
            ///</summary>
            string[] values;
            int[] intValues = new int[100];
            Console.WriteLine("\nMaximum Integer>>>>>>>>>");
            Console.WriteLine("Enter integers...........");
            values = Console.ReadLine().Split(" ");
            for (int i = 0; i < values.Length; i++)
            {
                intValues[i] = Convert.ToInt32(values[i]);
            }
            MaximumValue<int> maximumInt = new MaximumValue<int>(intValues);
            maximumInt.PrintMaxValue();

            ///<summary>
            ///Double Calling
            ///</summary>
            double[] doubleValues = new double[100];
            Console.WriteLine("\nMaximum Double>>>>>>>>>");
            Console.WriteLine("Enter float numbers............");
            values = Console.ReadLine().Split(" ");
            for (int i = 0; i < values.Length; i++)
            {
                doubleValues[i] = Convert.ToDouble(values[i]);
            }
            MaximumValue<double> maximumDouble = new MaximumValue<double>(doubleValues);
            maximumDouble.PrintMaxValue();

            ///<summary>
            ///String Calling
            ///</summary>
            Console.WriteLine("\nMaximum String>>>>>>>>>");
            Console.WriteLine("Enter Strings..........");
            values = Console.ReadLine().Split(" ");
            MaximumValue<string> maximumString = new MaximumValue<string>(values);
            string maxStringValue = maximumString.GetMaximum();
            Console.WriteLine("Maximum :" + maxStringValue);
            maximumString.PrintMaxValue();
        }
    }
}
