using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04TrainersSalary
{
    class Program
    {
        static void Main(string[] args)
        {
            int lecturesCount = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            
            double jelevLecturesCount = 0.0;
            double roYalLecturesCount = 0.0;
            double roliLecturesCount = 0.0;
            double trofonLecturesCount = 0.0;
            double sinoLecturesCount = 0.0;
            double othersLecturesCount = 0.0;

            double lecturePrice = budget / lecturesCount;
            for (int i = 0; i < lecturesCount; i++)
            {
                string trainer = Console.ReadLine();
                switch (trainer)
                {
                    case "Jelev":
                        jelevLecturesCount++;
                        break;
                    case "RoYaL":
                        roYalLecturesCount++;
                        break;
                    case "Roli":
                        roliLecturesCount++;
                        break;
                    case "Trofon":
                        trofonLecturesCount++;
                        break;
                    case "Sino":
                        sinoLecturesCount++;
                        break;
                    default:
                        othersLecturesCount++;
                        break;
                }
            }

            double salaryJelev = lecturePrice * jelevLecturesCount;
            double salaryRoYal = lecturePrice * roYalLecturesCount;
            double salaryRoli = lecturePrice * roliLecturesCount;
            double salaryTrofon = lecturePrice * trofonLecturesCount;
            double salarySino = lecturePrice * sinoLecturesCount;
            double salaryOthers = lecturePrice * othersLecturesCount;

            Console.WriteLine("Jelev salary: {0:f2} lv", salaryJelev);
            Console.WriteLine("RoYaL salary: {0:f2} lv", salaryRoYal);
            Console.WriteLine("Roli salary: {0:f2} lv", salaryRoli);
            Console.WriteLine("Trofon salary: {0:f2} lv", salaryTrofon);
            Console.WriteLine("Sino salary: {0:f2} lv", salarySino);
            Console.WriteLine("Others salary: {0:f2} lv", salaryOthers);
        }
    }
}
