using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class PartyToys
    {
        private Toy toy;
        private DateTime date;
        private int price;
        private int count;

        public Toy TheToy
        {
            set
            {
                toy = value;
            }
            get
            {
                return toy;
            }
        }

        public DateTime Date
        {
            set
            {
                date = value;
            }
            get
            {
                return date;
            }
        }

        public int Price
        {
            set
            {
                price = value;
            }
            get
            {
                return price;
            }
        }

        public int Count
        {
            set
            {
                count = value;
            }
            get
            {
                return count;
            }
        }


        public int GetAmount()
        {
            return count;
        }



        public void SellOneToy()
        {
            if(count != 0)
            {
                count -= 1;
            }
           
        }

        public override string ToString()
        {
            return toy.ToString() + " Цена: " + price + " , кiлькiсть: " + count;

        }
    }
}
