using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSystem.CLASSES
{
    public class ComboBoxItem
    {
        public int Id { get; set; }
        public string Value { get; set; }

        public ComboBoxItem(int id, string value)
        {
            Id = id;
            Value = value;
        }

        public override string ToString()
        {
            return Value;
        }
    }

}
