namespace HomeWork5pt3;
class Program
{
    static void Main(string[] args)

        {
            createAccount();
            Console.ReadKey(true);
        }
        public static bool checkAge(int birth_yr)
        {
            
            int age=2022-birth_yr;
            
            if(age>=18)
                return true;
           
            else
                return false;
        }
        public static void createAccount()
        {            
            String userName,password,retypedPassword;           
            int birthYear;            
            Console.WriteLine("enter your username:");            
            userName=Console.ReadLine();           
            Console.WriteLine("enter your password:");          
            password=Console.ReadLine();            
            Console.WriteLine("enter your password Again:");           
            retypedPassword=Console.ReadLine();            
            Console.WriteLine("enter your birthyear:");            
            birthYear=Convert.ToInt32(Console.ReadLine());            
            if(checkAge(birthYear))
            {              
                if(password==retypedPassword)
                    Console.WriteLine("Account is created successfully");         
                else
                    Console.WriteLine("Wrong password");            
            }
            else
                Console.WriteLine("Could not create an account.");
        }
    }

