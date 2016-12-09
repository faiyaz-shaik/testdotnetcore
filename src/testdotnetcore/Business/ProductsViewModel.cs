using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testdotnetcore.Business
{
    public class ProductsViewModel
    {
        private List<Product> m_Products = new List<Product>(); 

        public List<Product> Products {

            get { return m_Products; }

        }
        public string Name;

        public void AddProduct(Product p)
        {
            m_Products.Add(p);
        }

      

        
    }
}
