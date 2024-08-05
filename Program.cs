using Microsoft.VisualBasic;
using System.Xml.Schema;
using static System.Net.Mime.MediaTypeNames;

/*internal class Program
{
    private static void Main(string[] args)
    {
        Vehicle v1 = new Honda("Honda", "civic", 2021);
   Honda v2 = new Honda("Honda", "Accord", 2021);
        ILoader v3 = new Caterpillar ("Caterpillar", "ZXU", 2020);
   
        v3.Load();
      
    }
}
abstract class Vehicle //abstract type
{
    protected string Brand;
    protected string Model;
    protected int Year;
    public Vehicle(string brand, string model, int year)
    { 
        Brand = brand ;
        Model = model;
        Year = year;
     }
}
interface IDrivable
{
    void Move();
    void Stop();
}
interface ILoader
{
    void Load();
    void UnLoad();
}
class Honda : Vehicle, IDrivable //concrete
{
    public Honda(string brand, string model, int year) : base(brand, model, year)
    {

    }

    public void Move()
    {
        Console.WriteLine("Moving");
    }

    public void Stop()
    {
        Console.WriteLine("stopping");
    }
}


    class Caterpillar : Vehicle ,IDrivable, ILoader
    {
        public Caterpillar(string brand, string model, int year) : base(brand, model, year)
        { 

        }
        public void Move()
        {
            Console.WriteLine("Moving");
        }

        public void Stop()
        {
            Console.WriteLine("stopping");
        }
        public void Load()
        {
            Console.WriteLine("Loading");

        }

     public void UnLoad()
        {
            Console.WriteLine("UnLoading");
        }
    
}*/
/*internal class Program
{
    private static void Main(string[] args)
    {

        IMove m = new Vehical();
        m.Move();
        m.Turn();
    }
}
class Vehical : IMove, IDisplace
{
    void IMove.Move()
    {
        Console.WriteLine("IMove move");
    }

    void IDisplace.Move()
    {
        Console.WriteLine("IDisplace move");
    }
}
interface IMove
{
    void Turn()
    {
        Console.WriteLine("turning");
    }
    void Move();
}
interface IDisplace
{
    void Move();
}*/
internal class Program
{
    private static void Main(string[] args)
    {
        Cashier c = new Cashier(new Cash());
        c.Checkout(99999.99m);

       
    }
}
class Cashier
{
    private IPayment _payment;
    public Cashier(Cash payment)
    {
        _payment = payment;
    }
    public void Checkout (decimal amount)
    {
        _payment.Pay(amount);
    }
}
interface IPayment
{
    void Pay(decimal amount);
}
class Cash : IPayment
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"CashPayment : ${Math.Round(amount,2):N0}");//99,999,99
    }
}
class Debit
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"CashPayment : ${Math.Round(amount, 2):N0}");//99,999,99
    }

}
class Visa : IPayment
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"CashPayment : ${Math.Round(amount, 2):N0}");//99,999,99
    }

}
class Mastercard : IPayment
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"CashPayment : ${Math.Round(amount, 2):N0}");//99,999,99
    }
}