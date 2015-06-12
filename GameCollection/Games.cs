using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GameCollection
{

    public class Games
    {
        private IList<Product> products;



        public Games()
        {
            products = new List<Product>
             {
                new Product("MW2", 20.00m),
                new Product("God of War", 40.00m)
            };
        }



        public IEnumerable<Product> AllProducts()
        {
            return products;
        }

       
 }
   
}
