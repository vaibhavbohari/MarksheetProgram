using System;
namespace Marksheet
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Your Roll Number");
            string roll_Number = Console.ReadLine();
            Console.WriteLine("Enter Your Class");
            string standard = Console.ReadLine();
            Console.WriteLine("Enter  Marathi Marks");
            int marathi = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter English Marks");
            int english = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Maths Marks");
            int maths = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Science Marks");
            int science = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter History Marks");
            int history = Convert.ToInt16(Console.ReadLine());
            int obt = marathi + english + maths + science + history;
            int totalmarks = 500;
            int per = obt * 100 / totalmarks;



            Console.WriteLine("---------Marksheet---------");
            Console.WriteLine("Your  Name  is :{0}", name);
            Console.WriteLine("Your  Roll  Number is :{0}", roll_Number);
            Console.WriteLine("Your  class is :{0}", standard);
            Console.WriteLine("Total Marks:{0}", totalmarks);

            Console.WriteLine("Your  Obtain Marks are :{0}", obt);

            Console.WriteLine("Your  Percentage are :{0}", per);

            if (per >= 80)
            {
                Console.WriteLine("Grade: A1");
            }
            else if (per >= 75)
            {
                Console.WriteLine("Grade: A");
            }
            else if (per >= 70)
            {
                Console.WriteLine("Grade : B");
            }
            else if (per >= 60)
            {
                Console.WriteLine("Grade:: C");
            }
            else if (per >= 50)
            {
                Console.WriteLine("Grade :D");
            }
            else
            {
                Console.WriteLine("Grade :F");
            }


        }
    }

}


