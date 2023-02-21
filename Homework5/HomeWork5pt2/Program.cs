namespace HomeWork5pt2;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter first integer: ");
        int first = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second integer: ");
        int second = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter third integer: ");
        int third = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter fourth integer: ");
        int fourth = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The largest number is: " + largest(first, second, third, fourth));
    }
    static int largest(int n1, int n2)
    {
        if (n1 > n2)
        {
            return n1;
        }
        else
        {
            return n2;
        }
    }
    
    public static int largest(int n1, int n2, int n3, int n4)
    {
        return largest(largest(n1, n2), largest(n3, n4));
    }
}
