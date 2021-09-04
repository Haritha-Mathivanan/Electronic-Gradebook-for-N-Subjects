using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gradebook
{
    class Program
    {
        static Student s = new Student();
        static void Main(string[] args)
        {
            String Cont="y";
            Console.WriteLine("Enter Student Name : ");
            s.Studentname = Console.ReadLine();
            Console.WriteLine("Enter Student Rollno : ");
            s.Studentrollno = Console.ReadLine();
            Dictionary<String, int> Marklist = new Dictionary<string, int>();
            int mark = 0;
            String subjectname = "";
            while (Cont == "Y" || Cont == "y")
            {
                Console.Write("Enter Subject Name : ");
                subjectname = Console.ReadLine();
                Console.Write("Enter Mark : ");
                mark = Convert.ToInt32(Console.ReadLine());
                Marklist.Add(subjectname,mark);
                Console.WriteLine("Press y to enter next Subject Mark");
                Cont = Console.ReadLine();

            }
            s.Marklist = Marklist;
            Statistics statistic = new Statistics(Marklist);
            float Mean = statistic.Mean;
            float Median = statistic.Median;
            double Variance = statistic.Variance(Mean);
            double Standarddeviation = statistic.Standarddeviation(Variance);
            float lowestgrade = statistic.Lowestgrade;
            float highestgrade = statistic.Highestgrade;
            float averagegrade = statistic.Averagegrade;
            Display(Mean,Median,Variance,Standarddeviation,lowestgrade,highestgrade,averagegrade);
            
            
            
        }
        public static void Display(float Mean,float Median,double Variance,double standarddeviaton,float lowg,float highg,float avgg)
        {
             Console.WriteLine("__________________Student Details__________________");
             Console.WriteLine("Student Name : "+s.Studentname);
             Console.WriteLine("Student Rollno : "+s.Studentrollno);
             Console.WriteLine("__________________Student Marklist_________________");
             foreach (KeyValuePair<String, int> x in s.Marklist)
             {
                 Console.WriteLine(x.Key+"\t:\t"+x.Value);
             }
             Console.WriteLine("__________________Mark Statistics__________________");
             Console.WriteLine("Mean\t:\t"+Math.Round(Mean,2));
             Console.WriteLine("Meadian\t:\t"+Median);
             Console.WriteLine("Varirance\t:\t" + Math.Round(Variance,2));
             Console.WriteLine("Standard deviation\t:\t" + Math.Round(standarddeviaton,2));
             Console.WriteLine("__________________Grades___________________________");
             Console.WriteLine("Lowest Grade\t:\t" + Math.Round(lowg,2));
             Console.WriteLine("Average Grade\t:\t" + Math.Round(avgg,2));
             Console.WriteLine("Highest Grade\t:\t"+Math.Round(highg,2));
             Console.WriteLine("____________________________________________________");

            
        }
    }
}
