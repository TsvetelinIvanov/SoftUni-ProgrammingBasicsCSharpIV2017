using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int doctors = 7;
            int treatedPatiens = 0;
            int untreatedPatiens = 0;
            
            for (int i = 1; i <= days; i++)
            {
                if (i % 3 == 0)
                {
                    if (treatedPatiens < untreatedPatiens)
                    {
                        doctors++;
                    }
                }
                
                int patiens = int.Parse(Console.ReadLine());
                if (patiens >= doctors)
                {
                    treatedPatiens += doctors;
                    untreatedPatiens += patiens - doctors;
                }
                else
                {
                    treatedPatiens += patiens;
                }
            }
            
            Console.WriteLine("Treated patients: {0}.", treatedPatiens);
            Console.WriteLine("Untreated patients: {0}.", untreatedPatiens);
        }
    }
}
