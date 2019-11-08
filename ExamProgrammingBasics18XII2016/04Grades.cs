using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            double top = 0.0;
            double almostTop = 0.0;
            double almostFail = 0.0;
            double fail = 0.0;
            double all = 0.0;            
            double average = 0.0;

            for (int i = 0; i < students; i++)
            {
                double student = double.Parse(Console.ReadLine());
                if(student >= 5.00)
                {
                    top += 1;                    
                }
                else if (student >= 4.00)
                {
                    almostTop += 1;                    
                }
                else if (student >= 3.00)
                {
                    almostFail += 1;                    
                }
                else 
                {
                    fail += 1;                    
                }
                average += student;
                all++;
            }

            average /= all;
            double topPercent = top * 100 / all;
            double almosttopPercent = almostTop * 100 / all;
            double almostFailPercent = almostFail * 100 / all;
            double failPercent = fail * 100 / all;

            Console.WriteLine("Top students: {0:f2}%", topPercent);
            Console.WriteLine("Between 4.00 and 4.99: {0:f2}%", almosttopPercent);
            Console.WriteLine("Between 3.00 and 3.99: {0:f2}%", almostFailPercent);
            Console.WriteLine("Fail: {0:f2}%", failPercent);
            Console.WriteLine("Average: {0:f2}", average);
        }
    }
}
