﻿using System;
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
        public int PopulationCount { get; set; } = 100; //должно делиться на 4
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
                pop.ForEach(x =>
                {
                    x.Cost = Timetable.Fitness(Population.Etalon, x, frozen);
                });
                //считаем фитнесс функцию для всех планов
                var neww = pop.OrderBy(x=>x.Cost).ToList();
                //pop = neww.ToList();
                //pop.Sort(new TimetableComp());
                //сортруем популяцию по фитнесс функции
                if (neww[0].Cost == 0)
                    return pop[0];
                //отбираем 25% лучших планов
                if (flag)
                {
                    pop.RemoveAll(x => x.Cost == double.MaxValue);
                    pop.RemoveRange(pop.Count / 4, pop.Count - pop.Count / 4);                   
                }
                flag = true;
                //от каждого создаем трех потомков с мутациями
                var c = pop.Count;
                for (int i = 0; i < c; i++)
                {
                    pop.AddChildOfParent(pop[i], now);
                    pop.AddChildOfParent(pop[i], now);
                    pop.AddChildOfParent(pop[i], now);
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
            var t1 = new Timetable();
            this.Add(t1.Init(parent, now));
            var t2 = new Timetable();
            this.Add(t2.Init(parent, now)); 
            var t3 = new Timetable();
            this.Add(t3.Init(parent, now));
        }

        public bool AddChildOfParent(Timetable parent, DateTime now)
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