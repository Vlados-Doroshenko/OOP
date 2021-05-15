using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    [Serializable]
    public class ToyShop
    {
        static int count_shop = 0;
        private int serial_number;
        int toysAmount = 0;

        public List<PartyToys> supplies = new List<PartyToys>();

        public ToyShop()
        {
            count_shop += 1;
            serial_number = count_shop;

        }

        public void AddAPartyofToys(PartyToys toyParty)
        {
            supplies.Add(toyParty);
            CalculateToys();
        }

        public void CalculateToys()
        {
            toysAmount = 0;
            foreach (var i in supplies)
            {
                toysAmount += i.Count;
            }
        }
        public void SellToy(int i)
        {
            supplies[i].SellOneToy();
            CalculateToys();
        }

        public override string ToString()
        {
            return "Магазин № " + serial_number.ToString();
        }

        public string ToShortString()
        {
            CalculateToys();

            return "Магазин з серiйним номером: " + serial_number.ToString() + " , в магазинi залишилось iграшок: " + toysAmount;
        }
    }
}
