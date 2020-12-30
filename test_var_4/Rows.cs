using System;
using System.Collections.Generic;
using System.Text;

namespace test_var_4
{
   public class Rows
    {
        private int length;
        private string ch;

        public virtual double Length { get; set; }

        public virtual string Char { get; set; }

        public virtual void Symb()
        {
            Console.WriteLine(Char);
        }

        public virtual void Display()
        {
            Console.WriteLine(Length);
        }

    }
}
