using System;

namespace Homework_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            MoneyClass firstValue = new MoneyClass(20, 350);
            MoneyClass secondValue = new MoneyClass(10, 10);
            MoneyClass thirdValue = new MoneyClass(0, 0);
            thirdValue = firstValue - secondValue;

            thirdValue.Result();
        }
    }
}
