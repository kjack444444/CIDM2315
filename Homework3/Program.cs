namespace Homework3;
class Program
{
    static void Main(string[] args)
    {
       bool flag = true;
    Console.WriteLine("Input an integer: ");
    string input = Console.ReadLine();
    int number = Convert.ToInt32(input);
    for(int i=2;i<number/2;i++)
    {
        if(number%i==0)
        {
               flag = false;
               break;
        }
    }
    if(flag)
    {
        Console.WriteLine( input +" is Prime ");
    }
    else{
        Console.WriteLine(input+" is non-prime ");
    }
    
  }
}
