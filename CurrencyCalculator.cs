using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyCalculatorProject
{
    class CurrencyCalculator
    {
        private int _amount;
        public int Amount
        {
            get { return _amount; }

            set
            {
                if (value % 100 == 0 && value <= 50000)
                {
                    _amount = value;
                }
                else
                {
                    Console.WriteLine("Amount Exceeds 50000");
                }
            }
        }

        public void CountCurrency(int amount)
        {
            int[] valueOfNotes = { 2000, 500, 200, 100 };
            int temporaryVariable = amount;

            foreach (int note in valueOfNotes)
            {
                Console.WriteLine($"{note} Note : {temporaryVariable / note}");
                temporaryVariable = temporaryVariable % note;
            }
        }
    }
}
