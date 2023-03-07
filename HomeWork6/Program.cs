namespace HomeWork6;
class Program
{
    static void Main(string[] args)
    {
      professor p1=new professor();
    
      p1.prof_name = "Alice";
      p1.class_teach = "Java";
      p1.SetSalary(9000);
      professor p2 = new professor();
      p2.prof_name = "Bob";
      p2.class_teach = "Math";
      p2.SetSalary(8000);
      
      student ss1=new student();
    
      ss1.stu_name = "Lisa";
      ss1.class_enroll = "Java";
      ss1.SetGrade(90);
      
      student ss2 = new student();
    
      ss2.stu_name = "Tom";
      ss2.class_enroll = "Math";
      ss2.SetGrade(80);
      
      
    Console.WriteLine(p1.prof_name+" "+p1.class_teach+" "+p1.GetSalary());
    Console.WriteLine(p2.prof_name+" "+p2.class_teach+" "+p2.GetSalary());
    
    Console.WriteLine(ss1.stu_name+" "+ss1.class_enroll+" "+ss1.GetGrade());
    Console.WriteLine(ss2.stu_name+" "+ss2.class_enroll+" "+ss2.GetGrade());
    
  }
  class professor{
    public string prof_name;
    public string class_teach;
  
    private double salary;
    public void SetSalary(double salary_amount)
    {
        this.salary = salary_amount;
    }
    public double GetSalary()
    {
        return this.salary;
    }
}

class student{
    public string stu_name;
  
    public string class_enroll;
    private double grade;
    public void SetGrade(double grade_points)
    {
        this.grade = grade_points;
    }
    public double GetGrade()
    {
        return this.grade;
    }
}
}
