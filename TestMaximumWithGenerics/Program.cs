using System;

namespace TestMaximumWithGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Maximum Test Using Generics!");
            MaximumValue maximumNumber = new MaximumValue();

            ///<summary>
            ///Integer Calling
            ///</summary>
            Console.WriteLine("\nMaximum Integer>>>>>>>>>");
            Console.WriteLine("\nFirst Value: ");
            int firstIntValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nSecond Value: ");
            int secondIntValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nThird Value: ");
            int thirdIntValue = Convert.ToInt32(Console.ReadLine());
            int maxIntNumber = MaximumValue.GetMaximumIntegerNumber(firstIntValue, secondIntValue, thirdIntValue);
            Console.WriteLine("Maximum :" + maxIntNumber);

            ///<summary>
            ///Double Calling
            ///</summary>
            Console.WriteLine("\nMaximum Double>>>>>>>>>");
            Console.WriteLine("\nFirst Value: ");
            double firstDoubleValue = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nSecond Value: ");
            double secondDoubleValue = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nThird Value: ");
            double thirdDoubleValue = Convert.ToDouble(Console.ReadLine());
            double maxDoubleNumber = maximumNumber.GetMaximumDoubleNumber(firstDoubleValue, secondDoubleValue, thirdDoubleValue);
            Console.WriteLine("Maximum :" + maxDoubleNumber);
        }
    }
}
