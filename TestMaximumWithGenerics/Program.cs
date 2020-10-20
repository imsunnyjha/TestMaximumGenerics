using System;

namespace TestMaximumWithGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Maximum Test Using Generics!");
            MaximumValue maximumNumber = new MaximumValue();
            Console.WriteLine("\nMaximum Integer>>>>>>>>>");
            Console.WriteLine("\nFirst Value: ");
            int firstIntValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nSecond Value: ");
            int secondIntValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nThird Value: ");
            int thirdIntValue = Convert.ToInt32(Console.ReadLine());
            int maxIntNumer = MaximumValue.GetMaximumIntegerNumber(firstIntValue, secondIntValue, thirdIntValue);
            Console.WriteLine("Maximum :" + maxIntNumer);
        }
    }
}
