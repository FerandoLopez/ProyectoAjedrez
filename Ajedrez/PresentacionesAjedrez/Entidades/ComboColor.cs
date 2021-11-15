using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ComboColor
    {
        public ComboColor(string color)
        {
            _Color = color;
        }

        public string _Color { get; set; }

        public ComboColor()
        {

        }
    }
}
