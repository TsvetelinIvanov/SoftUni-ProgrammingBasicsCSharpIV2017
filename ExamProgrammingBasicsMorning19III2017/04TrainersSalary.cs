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
            int lectures = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double jelev = 0.0;
            double roYal = 0.0;
            double roli = 0.0;
            double trofon = 0.0;
            double sino = 0.0;
            double others = 0.0;

            double lecturePrice = budget / lectures;
            for (int i = 0; i < lectures; i++)
            {
                string lecture = Console.ReadLine();
                switch (lecture)
                {
                    case "Jelev": jelev++; break;
                    case "RoYaL": roYal++; break;
                    case "Roli": roli++; break;
                    case "Trofon": trofon++; break;
                    case "Sino": sino++; break;
                    default: others++; break;
                }
            }

            double salaryJelev = lecturePrice * jelev;
            double salaryRoYal = lecturePrice * roYal;
            double salaryRoli = lecturePrice * roli;
            double salaryTrofon = lecturePrice * trofon;
            double salarySino = lecturePrice * sino;
            double salaryOthers = lecturePrice * others;

            Console.WriteLine("Jelev salary: {0:f2} lv", salaryJelev);
            Console.WriteLine("RoYaL salary: {0:f2} lv", salaryRoYal);
            Console.WriteLine("Roli salary: {0:f2} lv", salaryRoli);
            Console.WriteLine("Trofon salary: {0:f2} lv", salaryTrofon);
            Console.WriteLine("Sino salary: {0:f2} lv", salarySino);
            Console.WriteLine("Others salary: {0:f2} lv", salaryOthers);
        }
    }
}
