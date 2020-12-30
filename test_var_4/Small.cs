using System;
using System.Collections.Generic;
using System.Text;

namespace test_var_4
{
    class Small : Rows
    {
        private double length;
        private object ch;

        public override double Length
        {
            get
            {
                return length;
            }
            set
            {
                if (value > 1000)
                {
                    length = value;
                }
            }
        }

        public Small(char ch)
        {
            this.ch = ch;
        }

        public string Symbol { get; set; }
        public Small(string symbol)
        {
            Symbol = symbol;
            string[] words = symbol.Split(new char[] { '/' });
        }

        public virtual void Symb()
        {
            Console.WriteLine(Symbol);
        }

        public virtual void Display()
        {
            Console.WriteLine(Length);
        }
    }
}
