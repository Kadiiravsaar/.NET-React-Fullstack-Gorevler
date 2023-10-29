 
IPersonManager customerManager = new CustomerManager(); //  CustomerManager refreransını tutuyoruz
customerManager.Add();

// interface, onu implement eden sınıfın referansını tutabilir

IPersonManager employeeManager = new EmployeeManager(); //  EmployeeManager refreransını tutuyoruz
employeeManager.Add();

Console.WriteLine("-----------");
ProjectManager projectManager = new ProjectManager();
projectManager.Add(new CustomerManager());
projectManager.Add(new EmployeeManager());
projectManager.Add(new InternManager());



interface IPersonManager
{
    void Add();
    void Update();
}

class CustomerManager : IPersonManager
{
    public void Add()
    {
        // Müşteri ekleme kodları
        Console.WriteLine("Müşteri eklendi");
    }

    public void Update()
    {
        Console.WriteLine("Müşteri Güncellendi");
    }
}

// inherits - class -------------------- implements - interface
class EmployeeManager : IPersonManager
{
    public void Add()
    {
        // Personel ekleme kodları
        Console.WriteLine("Personel eklendi");
    }
    public void Update()
    {
        Console.WriteLine("Personel Güncellendi");
    }
}

class InternManager : IPersonManager
{
    public void Add()
    {
        // Personel ekleme kodları
        Console.WriteLine("Stajyer eklendi");
    }
    public void Update()
    {
        Console.WriteLine("Stajyer Güncellendi");
    }
}




class ProjectManager
{
    public void Add(IPersonManager personManager)
    {
        personManager.Add();
    }

}