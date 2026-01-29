using API_Demo.Entities;

namespace API_Demo.Repositories
{
    public class ProductRepositories
    {
        //modify and save ng data

        private static List<Product> products = new List<Product>();

        public List<Product> GetAllProducts()
        {
            return products;    
        }
        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void DeleteProduct(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                products.Remove(product);
            }
        }   
    }
}
