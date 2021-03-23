using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InMarAPI.Models
{
    public class Products
    {
        public Products()
        {

        }

        public string ProductName { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
    }
}