using API_Demo.Entities;
using API_Demo.Repositories;

namespace API_Demo.Services
{
    public class ProductServices
    {
        public ProductRepositories _productRepositories = new ProductRepositories();

            // nawala na
            public List<Product> GetAllProducts()
            {
                return _productRepositories.GetAllProducts();
            }

            public void AddProduct(Product product)
            {
                _productRepositories.AddProduct(product);
            }
        

        //public void AddProduct(Product product)
        //{
        //    //logic dito
        //    product.Print();
        //}

        public void DeleteProduct(int id) 
        {
            //logic
            Console.WriteLine("deleted na");
        }
    }
}
