using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Check
{
    public class EmpWage
    {
        const int Is_present = 1;
        public void Attendence()
        {
            Random random = new Random();
            int Empcheck = random.Next(0, 2);
            if (Empcheck == Is_present)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is absent");
            Console.ReadLine();
        }
    }
}

