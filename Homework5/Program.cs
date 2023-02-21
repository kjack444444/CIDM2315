namespace Homework5;
class Program
{
    static void Main(string[] args)
   {
        Console.Write("A= ");
        int first = Convert.ToInt32(Console.ReadLine());
        Console.Write("B= ");
        int second = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The largest number is: " + largeNum(first, second));
    }
    
    static int largeNum(int Num1, int Num2)
    {
        if (Num1 > Num2)
        {
            return Num1;
        }
        else
        {
            return Num2;
        }
    }
}
