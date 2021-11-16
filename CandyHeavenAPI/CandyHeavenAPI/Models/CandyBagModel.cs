using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyHeavenAPI.Models
{
    public class CandyBagModel :ProductModel
    {
        public int Weight { get; set; }
        public CandyBagModel(int id, string name, string description, bool featured, double price, string imageUrl, int stock, int weightInGrams) : base(id, name, description, featured, price, imageUrl, stock)
        {
            Weight = weightInGrams;
        }

    }
}
