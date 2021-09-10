using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica100921
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btngetnames_Click(object sender, EventArgs e)
        {
            //llamado al metodo selectProductName
            selectProductName();
        }

        private void selectProductName()
        {
            //querry 
            List<string> productList = (
                from product in Product.GetProducts()
                select product.productName
                ).ToList();

            //recorrer la coleccion y llenar el ListBox
            foreach (var product in productList)
                ltsProductsNames.Items.Add(product);
        }

        private void btngetdata_Click(object sender, EventArgs e)
        {
            dgAllProducts.Columns.Add("codProduct","CODIGO PRODUCTO");
            dgAllProducts.Columns.Add("name", "NOMBRE");
            dgAllProducts.Columns.Add("description", "DESCRIPCION");
            dgAllProducts.Columns.Add("Category", "CATEGORIA DEL PRODUCTO");
            dgAllProducts.Columns.Add("price", "PRECIO DE COMPRA");

            foreach (var product in selectAllProducts())
            {
                dgAllProducts.Rows.Add(product.cdProduct, product.productName, product.productDescription,product.productCategoria,
                    product.buyPrice);
            }
        }

        private List<Product> selectAllProducts()
        {
            List<Product> getAllProducts = (
                from product in Product.GetProducts()
                    select new Product()
                    {
                        cdProduct = product.cdProduct, 
                        productName = product.productName,
                        productDescription = product.productDescription,
                        productCategoria = product.productCategoria,
                        buyPrice = product.buyPrice
                    }
                ).ToList();


            return getAllProducts;
        }
    }
}
