namespace HomeWork4;
class Program
{
    static void Main(string[] args)
    {
       int num1 =3; int num2 =5;
       Console.WriteLine($"A={num1} B={num2}");
       int large = LargestNum(num1,num2);
       Console.Write("\nLargest Number is:"+large);
    }
    static int LargestNum(int num1, int num2){
        if(num1>num2){
            return num1;
        }
        else if(num2>num1){
            return num2;
        }
        else{
            return -1;}

    }
}
