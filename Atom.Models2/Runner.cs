using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Atom.Models2
{
    public class Runner
    {
        public void Run(Project project)
        {
            while (true)
            {
                var Timetables = new List<Timetable>();
                var t = project.CreteTimetable();
                Timetables.Add(t);


                var solver = new Solver(); //создаем решатель


                


                var res = solver.Solve(t, new DateTime(2020, 6, 5));
                Console.ReadLine();
            }
        }



    }

  
}
