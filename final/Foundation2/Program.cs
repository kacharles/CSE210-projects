using System;

class Program
{
    static void Main(string[] args)

    {
        Product productOne = new Product("Iphone", 0011, 500, 500);
        Product productTwo = new Product("Samsung", 0022, 450, 500);
        Product productThree = new Product("Android", 0033, 350, 1000);

        Address addressOne = new Address("streetAddress1", "city1", "stateProvince1", "America");
        Address addressTwo = new Address("streetAddress2", "city2", "stateProvince2", "Liberia");

        Customer customerOne = new Customer("Ali", addressOne);
        Customer customerTwo = new Customer("Amir", addressTwo);

        List<Product> _products = new List<Product>();
        List<Customer> _customers = new List<Customer>();

        _products.Add(productOne);
        _products.Add(productTwo);
        _products.Add(productThree);



        // _customers.Add(customerOne);
        // _customers.Add(customerTwo);


        Order orderOne = new Order(_products, customerOne); 
        Order orderTwo = new Order(_products, customerTwo);

        List<Order> _orders = new List<Order>(); 
        _orders.Add(orderOne);
        _orders.Add(orderTwo);
        foreach(Order order in _orders) { 
            order.GetPackLBL();
            Console.WriteLine("==================");
            Console.WriteLine($"{order.GetShippingLBL()}");
            Console.WriteLine("==================");
            order.ComputeOrder();
            Console.WriteLine();

        }

        // orders.GetPackLBL();
        // Console.WriteLine("======================");
        // Console.WriteLine(orders.GetShippingLBL()); 
        // Console.WriteLine("======================");
        // orders.ComputeOrder();
        
        

    }
}