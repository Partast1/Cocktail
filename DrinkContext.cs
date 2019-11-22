using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails
{
    public class DrinkContext : DbContext
    {
        public DrinkContext() : base("CocktailDataBase")
        {
        }

        public DbSet<Drink> Drink { get; set; }
        public DbSet<Alcohol> Alcohol { get; set; }
        public DbSet<Ingredient> Ingredient { get; set; }

    }
}
