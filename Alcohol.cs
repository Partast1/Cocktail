using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails
{

    public class Alcohol
    {

        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string TypeOfAlcohol { get; set; }
        public IList<Drink> Drinks { get; set; }




    }
}