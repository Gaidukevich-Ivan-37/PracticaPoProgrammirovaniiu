using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlTaskWPF.Models
{
    public class Country
    {
        public string Name { get; set; }
        public double Area { get; set; }
        public double Population { get; set; }
        public override string ToString()
        {
            return new StringBuilder()
                .AppendLine($"--->Страна: {Name}")
                .AppendLine($"\t--->Площадь: {Area} км^2")
                .AppendLine($"--->Население: {Population} миллион человек")
                .ToString();
        }
    }
}