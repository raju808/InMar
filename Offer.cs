using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InMarAPI.Models
{
    public class Offer
    {
        public Offer()
        {

        }

        public string OfferName { get; set; }
        public Products ListOfProducts { get; set; }
    }
}