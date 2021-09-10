using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica100921
{
    class Product
    {
        public int cdProduct { get; set; }

        public string productName { get; set; }

        public string productDescription { get; set; }
        public string productCategoria { get; set; }

        public double buyPrice { get; set; }

        public static List<Product> GetProducts()
        {
            List<Product> products = new List<Product>
            {
             new Product{ cdProduct= 12001, productName="Coca Cola", productDescription= "Bebida carbonatada distribuida por ILC", productCategoria="Bebida", buyPrice=0.55d},
             new Product{ cdProduct= 12002, productName="Hershey", productDescription= "Chocolate, distribuido por The Hershey Company",productCategoria="Snacks", buyPrice=1.56d},
             new Product{ cdProduct= 12003, productName="Pilsener", productDescription= "Cerveza, distribuida por ILC",productCategoria="Bebida", buyPrice=1.75d},
             new Product{ cdProduct= 12004, productName="Oreo", productDescription= "Galleta tipo sándwich, distribuida por Mondelēz International; Kraft Foods",productCategoria="Snacks", buyPrice=0.25d},
             new Product{ cdProduct= 12005, productName="Pingüinos", productDescription= "Pastelitos de chocolate rellenos de vainilla distribuida por Marinela",productCategoria="Snacks", buyPrice=0.65d},
            };
            return products;
        }
    }
}
