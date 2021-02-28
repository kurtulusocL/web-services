using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebServices.SOAP.ServiceReference1;

namespace WebServices.WebAPI.Controllers
{
    public class ProductsController : ApiController
    {
        private static List<string> _products { get; set; }
        private static List<string> products
        {
            get
            {
                if (products == null)
                    _products = new List<string>();
                return _products;
            }
        }
        public string GetMethod()
        {
            return "kurtulus ocal";
        }
        public string GetMethod(string name)
        {
            return "Hi" + name;
        }

        [HttpPost]
        public bool AddProduct(string name)
        {
            return new Service1Client().AddProduct(name);
        }

        [HttpGet]
        public string[] GetAllProducts()
        {
            return new Service1Client().GetAllProducts();
        }

        [HttpGet]
        public string Soap(int value)
        {
            return new Service1Client().GetData(value);
        }
    }
}
