using Cocktail;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails
{

    public class Drink : Drinkable 
    {
        

        [Key]
        public int ID { get; set; }
        //public IList<Ingredient>  Ingredient { get; set; }
        //public IList<Drink> Alcohol { get; set; }

        public int AlcoholID { get; set; }
        public Alcohol Alcohol { get; set; }
        public int IngredientID { get; set; }
        public Ingredient Ingredient { get; set; }

    }
}
