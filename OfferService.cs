using InMarAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace InMarAPI.Services
{
    public class OfferService
    {
        private IList<Products> Inventory { get; set; }

        private  IList<Products> createProducts()
        {
            var prod = addProduct("PP1",1000, "desc");
            Inventory.Add(prod);
            return Inventory;
        }
        public  IEnumerable<Products> GetAllProducts()
        {
            return  createProducts();
        }

        public IEnumerable<Products> GetTodaysOffers()
        {
            return createProducts().Take(3);
        }

        public Products addProduct(string prodName, int price, string desc)
        {
            var obj = new Products();
            obj.Description = "P1 desc";
            obj.Price = 1000;
            obj.ProductName = "P1";
            return obj;

        }


        public IEnumerable<Customer> GetCustomer(string searchValue, DateTime dateT, string flag)
        {
            return GetAllCustomer().Where(e => e.Name.Contains(searchValue));
        }


        public IEnumerable<Customer> GetAllCustomer()
        {
            IList<Customer> objlist = new List<Customer>();
            Customer obj = new Customer();
            obj.CustomerId = 1;
            obj.Name = "Raju";
            objlist.Add(obj);
            return objlist;
        }
    }
}