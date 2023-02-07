namespace Homework3pt3;
class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("Assign an int value to N:");
		int N=Convert.ToInt16(Console.ReadLine());
		for(int i=0;i<N;i++) {
			for(int j=0;j<N;j++) {
				if(i<j)
					Console.Write(" ");
				else
					Console.Write("*");
			}
			Console.Write("\n");
		}
	}
}