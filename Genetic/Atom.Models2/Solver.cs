using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using static Atom.Models2.Timetable;

namespace Atom.Models2
{
    public class SolverOption
    {
        public int MaxIterations { get; set;} = 1000;     
    }
    public class Solver
    {
        SolverOption _solverOption;

        public List<Func<Timetable, double>> FitnessFunctions = new List<Func<Timetable, double>>();
        public Timetable Solve(Timetable Etalon, DateTime now, DateTime frozen, SolverOption solverOption = null)
        {
          
            if (solverOption == null)
            {
                _solverOption = new SolverOption();
            }
            else
            {
                _solverOption = solverOption;
            }

            bool flag = false;

            Population.Etalon = Etalon;
            var pop = new Population(Etalon, now);
            

            if (pop.Count == 0)
                throw new Exception("Can not create any plan");
            
            var count = _solverOption.MaxIterations;
            while (count-- > 0)
            {
                for (var i = 0; i < pop.Count; i++)
                {
                    pop[i].Cost = Timetable.Fitness(Population.Etalon, pop[i], frozen);
                    if (pop[i].Cost <= GeneticEnviroment.CostExtr)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"Найден оптимальный план: {pop[i].Cost}");
                        Console.ForegroundColor = ConsoleColor.White;
                        return pop[i];
                    }
                    if (pop[i].Cost == double.MaxValue)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Новый мутант: {pop[i].Cost} - невозможный по условиям бизнес логики");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.WriteLine($"Новый мутант: {pop[i].Cost}");
                    }

                }
                var neww = pop.OrderBy(x=>x.Cost).ToList();
                pop.Clear();
                pop.AddRange(neww);             
                if (flag)
                {
                    pop.RemoveAll(x => x.Cost == double.MaxValue);
                    pop.RemoveRange(5, pop.Count - 5);                   
                }
                flag = true;
                var d = pop.Count;
                for (int i = 0; i < d; i++)
                {
                    pop.AddChild(pop[i], now);
                    pop.AddChild(pop[i], now);
                    pop.AddChild(pop[i], now);            
                }
            }
            return pop[0];
        }

    }
    public class Population : List<Timetable>
    {
        public static Timetable Etalon { get; set; } = new Timetable();
        public Population(Timetable parent, DateTime now)
        {
            this.Add(new Timetable().Init(parent, now));
            this.Add(new Timetable().Init(parent, now));
            this.Add(new Timetable().Init(parent, now));
            this.Add(new Timetable().Init(parent, now));
            this.Add(new Timetable().Init(parent, now));
            this.Add(new Timetable().Init(parent, now));
            this.Add(new Timetable().Init(parent, now));
            this.Add(new Timetable().Init(parent, now));
        }

        public bool AddChild(Timetable parent, DateTime now)
        {
            int maxIterations = 10;
            do
            {
                var plan = new Timetable();
                plan.Init(parent, now);
                this.Add(plan);
            } while (maxIterations-- > 0);
            return false;
        }
    }

    
}
