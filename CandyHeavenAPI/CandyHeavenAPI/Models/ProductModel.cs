﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyHeavenAPI.Models
{
    public class ProductModel
    {
        public string Name { get; set; }
        public string ImageURL { get; set; }
        public int Id { get; set; }
        public double Price { get; set; }
        public bool Featured { get; set; }
        public int StockQuantity { get; set; }
        public string ProductInfo { get; set; }
        public int cartQuantity { get; set; }

        public ProductModel(int id, string name, string description, bool featured, double price, string imageUrl, int stock)
        {
            Id = id;
            Name = name;
            Price = price;
            ImageURL = imageUrl;
            Featured = featured;
            StockQuantity = stock;
            ProductInfo = description;
        }
    }

}
