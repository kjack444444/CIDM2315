namespace HomeWork7;
class Program
{
    static void Main(string[] args)
    {
        Customer c1=new Customer(110,"Alice",28);
  Customer c2=new Customer(111,"Bob",30);
  c1.PrintCustInfo();
  c2.PrintCustInfo();
  Console.WriteLine();
  c1.ChangeID(220);
  c2.ChangeID(221);
/*This is where we will print the info of the cust*/
  c1.PrintCustInfo();
  c2.PrintCustInfo();
  Console.WriteLine("Bob is older");
    }
    class Customer{

private int cust_id;
public string cust_name;
public int cust_age;

public Customer(int id,string name,int age)
{
  cust_id=id;
  cust_name=name;
  cust_age=age;
}
public void ChangeID(int new_id)
{
  cust_id=new_id;
}
public void PrintCustInfo()
{
  Console.WriteLine("Customer's ID: {0}, Customer's Name:{1}, Customer's Age:{2}",cust_id,cust_name,cust_age);
}
    }
   
}


