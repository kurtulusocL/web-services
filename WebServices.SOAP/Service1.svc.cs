using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WebServices.SOAP
{   
    public class Service1 : IService1
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

        public bool AddProduct(string name)
        {
            products.Add(name);
            return true;
        }

        public List<string> GetAllProducts()
        {
            return products;
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }
    }
}
