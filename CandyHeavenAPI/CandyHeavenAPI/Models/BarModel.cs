using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyHeavenAPI.Models
{
    public class BarModel : ProductModel
    {
        public string Taste { get; set; }
        public BarModel(int id, string name, string description, bool featured, double price, string imageUrl, int stock, string taste) : base(id, name, description, featured, price, imageUrl, stock)
        {
            Taste = taste;
        }
    }
}
