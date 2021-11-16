using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyHeavenAPI.Models
{
    public class BulkCandyModel : ProductModel
    {
        public string CandySort { get; set; }
        public BulkCandyModel(int id, string name, string description, bool featured, double price, string imageUrl, int stock, string candySort) : base(id, name, description, featured, price, imageUrl, stock)
        {
            CandySort = candySort;
        }
    }
}
