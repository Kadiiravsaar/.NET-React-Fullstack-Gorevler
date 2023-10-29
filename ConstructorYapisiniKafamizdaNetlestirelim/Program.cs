
Customer customer1 = new Customer
{
    Id = 1,
    FirstName = "Kadir",
    LastName = "Avşar"
};

Customer customer2 = new Customer(2, "Kadir", "Avşar","İstanbul");

Console.WriteLine(customer2.City); 

Customer customer3 = new Customer();

class Customer
{
    public Customer()
    {
        Console.WriteLine();
    }
    public Customer(int id,string firstName,string lastName,string city)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        City = city;
    }
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }


}