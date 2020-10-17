using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Atom.Models2
{
    public class Runner
    {
        public Timetable Run(Project project)
        {
            var Timetables = new List<Timetable>();
            var t = project.CreteTimetable();
            Timetables.Add(t);

            // Создаем решатель (генетического алгоритм).
            var solver = new Solver(); 
            // Запуск генетического алгоритм.
            var res = solver.Solve(t, new DateTime(2020, 6, 5)); 

            return res;
        }



    }

  
}
