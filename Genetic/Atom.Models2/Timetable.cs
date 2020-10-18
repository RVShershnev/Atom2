using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;

namespace Atom.Models2
{
    [Serializable]
    public class Timetable : IComparable<Timetable>
    {
        public static Timetable Etalon { get; set; } = new Timetable();
        public List<Work> Works { get; set; } = new List<Work>();
        public List<Stage> Stages { get; set; } = new List<Stage>();
        public Dictionary<Stage, Work> LinkStageWork { get; set; } = new Dictionary<Stage, Work>();
        public DateTime ActualDateTime { get; set; }
        public double Cost { get; set; } = double.MaxValue;
                
        Random Random = new Random();
          
        public static double Fitness(Timetable etalon, Timetable mutation, DateTime FrozenDate)
        {
            var sum = 0.0d;         
            for(var i=0; i< etalon.Works.Count(); i++)
            {
                var eta = etalon.Works[i];
                var muta = mutation.Works.SingleOrDefault(x=>x.Id == etalon.Works[i].Id);
                if(muta != null)
                {
                    // Штраф за сдвиг вперед
                    if(eta.Start < muta.Start)
                    {                       
                        if (eta.PriceEarlier <= -1)  // Штраф за невозможность действия
                        {
                            return double.MaxValue;
                        }
                        else
                        {
                            var count = (muta.Start - eta.Start).Days;
                            sum += Math.Abs(count * eta.PriceLate);
                        }                       
                    }
                    // Штраф за сдвиг назад
                    if (eta.Start > muta.Start)
                    {                                    
                        if (eta.PriceLate <= -1) // Штраф за невозможность действия
                        {
                            return double.MaxValue;
                        }
                        else
                        {
                            var count = (muta.Start - eta.Start).Days;
                            sum += Math.Abs(count * eta.PriceLate);
                        }
                    }
                    // Штраф за изменение времени
                    if (eta.Duration != muta.Duration)
                    {                        
                        if (eta.PriceDurationChanged <= -1)
                        {
                            return double.MaxValue;
                        }
                        if (eta.DurationMin > muta.Duration)
                        {
                            return double.MaxValue;
                        }
                        else
                        {
                            var count = Math.Abs(muta.Duration - eta.Duration);
                            sum += Math.Abs(count * eta.PriceDurationChanged);
                        }
                    }                       
                }
            }
            for (var i = 0; i < etalon.Stages.Count(); i++)
            {
                var eta = etalon.Stages[i];
                var muta = mutation.Stages.SingleOrDefault(x => x.Id == etalon.Stages[i].Id);
                if (muta != null)
                {
                    // Штраф за сдвиг вперед
                    if (eta.Start < muta.Start)
                    {
                        if (eta.PriceEarlier <= -1)  // Штраф за невозможность действия
                        {
                            return double.MaxValue;
                        }
                        else
                        {
                            var count = (muta.Start - eta.Start).Days;
                            sum += Math.Abs(count * eta.PriceLate);
                        }
                    }
                    // Штраф за сдвиг назад
                    if (eta.Start > muta.Start)
                    {
                        if (eta.PriceLate <= -1) // Штраф за невозможность действия
                        {
                            return double.MaxValue;
                        }
                        else
                        {
                            var count = (muta.Start - eta.Start).Days;
                            sum += Math.Abs(count * eta.PriceLate);
                        }
                    }
                    // Штраф за изменение времени
                    if (eta.Duration != muta.Duration)
                    {
                        if (eta.PriceDurationChanged <= -1)
                        {
                            return double.MaxValue;
                        }
                        if (eta.DurationMin > muta.Duration)
                        {
                            return double.MaxValue;
                        }
                        else
                        {
                            var count = Math.Abs(muta.Duration - eta.Duration);
                            sum += Math.Abs(count * eta.PriceDurationChanged);
                        }
                    }
                }
            }
            return sum;
        }

        /// <summary>
        /// Создание наследника с мутацией
        /// </summary>
        public Timetable Init(Timetable parent, DateTime dateTimeEnviroment)
        {
            //копируем предка
            for (int i = 0; i < parent.Works.Count; i++)                
                this.Works.Add((Work)parent.Works[i].Clone());

            for (int i = 0; i < parent.Stages.Count; i++)
                this.Stages.Add((Stage)parent.Stages[i].Clone());

            for (int i = 0; i < parent.LinkStageWork.Count; i++)
                this.LinkStageWork.Add(parent.LinkStageWork.Keys.ElementAt(i), parent.LinkStageWork.Values.ElementAt(i));

            var mutateWorks = this.Works.Where(x=>x.Finish != new DateTime() || x.Start > dateTimeEnviroment).ToList();

            var mutateStages = this.Stages.Where(x => x.Finish != new DateTime() || x.Start > dateTimeEnviroment).ToList();

            var randomWork = Random.Next(0, mutateWorks.Count());
            var randomStages = Random.Next(0, Stages.Count());
            var destvie = Random.Next(0, 6);
                       
            switch(destvie)
            {
                case 1:
                    mutateWorks[randomWork].Start = mutateWorks[randomWork].Start.AddDays(1);
                    break;
                case 2:
                    mutateWorks[randomWork].Start = mutateWorks[randomWork].Start - new TimeSpan(1,0,0,0);
                    break;
                case 3:
                    mutateWorks[randomWork].Duration -= 1;
                    break;
                case 4:
                    mutateStages[randomStages].Start = mutateStages[randomStages].Start.AddDays(1);
                    break;
                case 5:
                    mutateStages[randomStages].Start = mutateStages[randomStages].Start - new TimeSpan(1, 0, 0, 0);
                    break;
                case 6:
                    mutateStages[randomStages].Duration -= 1;
                    break;
            }
            return this;
        }

        public int CompareTo(Timetable other)
        {
            if(this.Cost < other.Cost)
            {
                return 1;
            }
            else
            {
                return -1;
            } 
        }

        public class TimetableComp : IComparer<Timetable>
        {           
            public int Compare(Timetable x, Timetable y)
            {
                if (x.Cost.CompareTo(y.Cost) != 0)
                {
                    return 1;
                }              
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>
        /// Стоимость всех сдвигов
        /// </summary>
        /// <param name="t1">старое расписание</param>
        /// <param name="t2">новое расписание</param>
        /// <returns></returns>
        public double GetCost(Timetable t1, Timetable t2)
        {
            double cost =0;
            for (var i = 0; i < t2.Stages.Count; i++)
            {
                var stage = t1.Stages.SingleOrDefault(x=>x.Id == t2.Stages[i].Id);
                var days = Math.Abs((stage.Start - t2.Stages[i].Start).Days);
                if (stage.Start < t2.Stages[i].Start)
                {
                    cost += days * stage.PriceLate;
                }
                else
                {
                    cost += days * stage.PriceEarlier;
                }
                if(stage.Duration != t2.Stages[i].Duration)
                {
                    var count = stage.Duration - t2.Stages[i].Duration;
                    cost += count * stage.PriceDurationChanged;
                }
            }
            for (var i=0; i< t1.Works.Count; i++)
            {
                var work = t1.Works.SingleOrDefault(x => x.Id == t2.Works[i].Id);
                var days = Math.Abs((work.Start - t2.Works[i].Start).Days);
                if (work.Start < t2.Works[i].Start)
                {
                    cost += days * work.PriceLate;
                }
                else
                {
                    cost += days * work.PriceEarlier;
                }
                if (work.Duration != t2.Stages[i].Duration)
                {
                    var count = work.Duration - t2.Stages[i].Duration;
                    cost += count * work.PriceDurationChanged;
                }
            }
            return cost;
        }
    }

}
