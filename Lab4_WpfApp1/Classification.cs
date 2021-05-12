using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WpfApp1
{
    [XmlType("Classification")]
    [Serializable]
    public class Classification
    {
        public enum ClassificationValue {[XmlEnum(Name = "Мяка_іграшка")] Мяка_іграшка, [XmlEnum(Name = "Лялька")] Лялька, [XmlEnum(Name = "Модель_техніки")] Модель_техніки, [XmlEnum(Name = "Конструктор")] Конструктор }
        [XmlElement("classificationValue")]
        ClassificationValue classificationValue;

        public Classification() 
        {
            classificationValue = new ClassificationValue();
        }
        public Classification(ClassificationValue v)
        {
            this.classificationValue = v;
        }
        public override String ToString()
        {
            return "Класифікація: " + classificationValue.ToString();
        }
    }
}
