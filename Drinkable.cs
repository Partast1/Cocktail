using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktail
{
    abstract public class Drinkable : IDrinkable
    {
        public string Name { get; set; }
        public float Volume { get; set; }
    }
}
