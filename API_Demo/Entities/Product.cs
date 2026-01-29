namespace API_Demo.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public void Print()
        {
            Console.WriteLine($"ID : {Id}");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Price : {Price}");
        }
    }
       

   
}
