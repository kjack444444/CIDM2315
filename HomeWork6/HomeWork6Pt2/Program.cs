namespace HomeWork6Pt2;
class Program
{
    static void Main(string[] args)
    {
string professor1, professor2, student1,student2;
string class1,class2;
int salary1, salary2;
int grade1, grade2;

Console.WriteLine("Enter Professor1's name, class and salary: ");
professor1 = Console.ReadLine();
class1 = Console .ReadLine();
salary1 = Convert.ToInt32(Console.ReadLine());
  
Console.WriteLine("Enter Professor2's name, class and salary: ");
professor2 = Console.ReadLine();
class2 = Console.ReadLine();
salary2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Student1's name and grade: ");
student1 = Console.ReadLine();
grade1 = Convert.ToInt32(Console .ReadLine());

Console.WriteLine("Enter Student2's name and grade: ");
student2 = Console.ReadLine();
grade2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\n-----------------------------------------\n");

Console.WriteLine("Professor "+professor1 +" teaches "+class1 + ", and the salary is "+salary1 );
Console.WriteLine("Professor " + professor2 + " teaches " + class2 + ", and the salary is " + salary2);
Console.WriteLine("Student "+student1 +" enrolls "+class1+", and the grade is "+grade1 );
Console.WriteLine("Student " + student2 + " enrolls " + class2 + ", and the grade is " + grade2);
Console.WriteLine("The salary difference between " + professor1 + " and " + professor2 + " is: " + (salary1 - salary2));
Console.WriteLine("The total grade of " + student1 + " and " + student2 + " is: " + (grade1 + grade2));


Console.ReadKey();
    }
  }

