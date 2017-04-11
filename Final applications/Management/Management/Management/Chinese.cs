﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management
{
    class Chinese:ClassRestaurant
    {
        
        public decimal Price { get; set; }
        public string StallName { get; set; }
        public int StockSelected { get; set; }
        public int CountSelect { get; set; }

        public Chinese(string name, string stallName, decimal price, int stock)
            :base(name)
        {
            
            this.Price = price;
            this.StallName = stallName;
            this.CountSelect = stock;
            
        }

        public int CountInStock(int count)
        {
            this.StockSelected = StockSelected - count;
            return StockSelected;
        }

        public decimal Totalprice(decimal price,int countIterms)
        {
            this.Price = Price * countIterms;
            return Price;
        }

        public override string ToString()
        {
            string inf = base.Name;
            inf += " FROM : " + this.StallName + " PRICE: " + this.Price + " euro";
            return inf;
        }

    }
}
