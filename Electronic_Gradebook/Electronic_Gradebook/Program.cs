using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Electronic_Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Electronic GradeBook");
            Console.WriteLine("Enter the Name  : ");
            String name = Console.ReadLine();
            Console.WriteLine("Enter the Rollno : ");
            String Rollno = Console.ReadLine();
            Console.WriteLine("Enter the Class : ");
            int Class = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Section : ");
            String Section = Console.ReadLine();
            Gradebook gb = new Gradebook(name, Rollno, Class, Section);
            String Cont = "Y";
            int count = 0;
            while (Cont == "Y" || Cont == "y")
            {

                Console.Write("Enter the Subject Name : ");
                String Subject = Console.ReadLine();
                Console.Write("Enter the Marks : ");
                float Mark = float.Parse(Console.ReadLine());
                Console.WriteLine("A - Add | R - Remove | E - EditGrade ");
                String Option = Console.ReadLine();
                if (Option == "A" || Option == "a")
                {
                    if (gb.Addgrade(Subject, Mark))
                    {
                        count++;
                        Console.WriteLine("Details Added Successfully !!!");
                    }
                }
                else if (Option == "R" || Option == "r")
                {
                    if (gb.Removegrade(Subject))
                    {
                        count--;
                        Console.WriteLine("Details Removed Successfully !!!");
                    }
                    else
                    {
                        Console.WriteLine("Details Not Found");
                    }
                }
                else if (Option == "E" || Option == "e")
                {
                    if (gb.Updategrade(Subject, Mark))
                    {
                        Console.WriteLine("Marks Updated Successfully !!! ");
                    }
                    else
                    {
                        Console.WriteLine("Subject Not Found");
                    }
                }
                else
                {
                    Console.WriteLine("Enter Valid Choice");
                    continue;
                }
                if (count == 10)
                {
                    Console.WriteLine("Maximum Limit Reached ");
                    break;
                }
                Console.WriteLine("____Press y to enter next Subject Marks ____");
                Cont = Console.ReadLine();
                if (Cont != "Y" && Cont != "y" && count < 3)
                {
                    Console.WriteLine("Enter " + (3 - count) + "more Details");
                    Cont = "y";
                }

            }
            Console.WriteLine(gb);
            Gradestatistics gds = gb.Calculatestatistics();
            Console.WriteLine(gds);
            

        }
        //public static void GetStudentdetails()
        //{
           
        //}
        //public static void GetMarkdetails()
        //{
            
        //}
    }
}
