int sayi1 = 10;
int sayi2 = 20;
sayi1 = sayi2;
sayi2 = 100;
Console.WriteLine(sayi1);

// değer tip =< int decimal float enum boolean  (stack)

int[] sayilar1 = new int[] { 1, 2, 3 };
int[] sayilar2 = new int[] { 10, 20, 30 };

sayilar1 = sayilar2;
sayilar2[0] = 1000;
Console.WriteLine(sayilar1[0]); ; // 100

// array class interdace => referans tip (heap)

Person person = new Person();
Person person2 = new Person();
person.FirstName = "Kadir";
person2 = person;
person.FirstName = "Keke";

Console.WriteLine(person2.FirstName);

Customer customer = new Customer();
Employee employee = new Employee();



PersonManager personManager = new PersonManager();
personManager.Add(person);
personManager.Add(employee);
personManager.Add(customer);


class Person // base class, ebeveyn
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

class Customer : Person
{
    public string CreditCardNumber { get; set; }
}

class Employee : Person
{
    public int EmployeeNumber { get; set; }
}

class PersonManager
{
    public void Add(Person person) // kalıtım aldığı için hepsini gönderirrim
    {
        Console.WriteLine(person.FirstName);

    }
}