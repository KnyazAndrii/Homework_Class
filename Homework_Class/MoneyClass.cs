using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Class
{
    public interface ICalcPennies
    {
        
    }

    class MoneyClass
    {
        private int _grivnas = 0;
        private int _pennies = 0;

        public MoneyClass()
        {
            Grivnas = 0;
            Pennies = 0;
        }

        public MoneyClass(int grivnas, int pennies)
        {
            Grivnas = grivnas;
            Pennies = pennies;
        }

        public int Grivnas
        {
            get => _grivnas;
            set
            {
                if(value >= 0)
                {
                    _grivnas = value;
                }
                else
                {
                    throw new ArgumentException("Enter non-zero value!");
                }
            }
        }

        public int Pennies
        {
            get => _pennies;
            set
            {
                if(value >= 100)
                {
                    while(value >= 100)
                    {
                        _grivnas++;
                        value -= 100;
                    }

                    _pennies = value;
                }
                else if (value >= 0)
                {
                    _pennies = value;
                }
                else
                {
                    throw new ArgumentException("Enter non-zero value!");
                }
            }
        }

        public static MoneyClass operator + (MoneyClass firstValue, MoneyClass secondValue)
        {
            MoneyClass thirdValue = new MoneyClass(0, 0);

            thirdValue._grivnas = firstValue._grivnas + secondValue._grivnas;
            thirdValue._pennies = firstValue._pennies + secondValue._pennies;

            return thirdValue;
        }

        public static MoneyClass operator -(MoneyClass firstValue, MoneyClass secondValue)
        {
            MoneyClass thirdValue = new MoneyClass(0, 0);

            thirdValue._grivnas = firstValue._grivnas - secondValue._grivnas;
            thirdValue._pennies = firstValue._pennies - secondValue._pennies;

            return thirdValue;
        }

        public void Result()
        {
            Console.WriteLine("{0} grivnas, {1} pennies", _grivnas, _pennies);
        }
    }
}
