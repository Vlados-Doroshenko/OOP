using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    [Serializable]
    public class Toy
    {
        private string name_toy;
        private string manufacturer;
        private Classification ToyType;
        public enum Classification
        {
            Мяка_іграшка,
            Лялька,
            Модель_техніки,
            Конструктор
        }

        public string Name
        {
            set
            {
                name_toy = value;
            }
            get
            {
                return name_toy;
            }
        }

        public string Manufacturer
        {
            set
            {
                manufacturer = value;
            }
            get
            {
                return manufacturer;
            }
        }

        public Classification ToyClass
        {
            set
            {
                ToyType = value;
            }
            get
            {
                return ToyType;
            }
        }

        public override string ToString()
        {
            return name_toy + " " + manufacturer;
        }
    }
}
