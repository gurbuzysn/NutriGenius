using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriGenius.Data.Entities.Classes
{
    public class FoodCategory
    {
        public int Id { get; set; }

        public string CategoryName { get; set; } = null!;


        public override string ToString()
        {
            return $"{CategoryName}";
        }
    }
}
