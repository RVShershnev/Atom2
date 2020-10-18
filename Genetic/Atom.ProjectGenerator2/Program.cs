using Atom.Models2;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using static Atom.Models2.RandomExtension;

using System.Security.Cryptography.X509Certificates;
using Mono.Options;

namespace Atom.ProjectGenerator2
{
    class Program
    {
        static void Main(string[] args)
        {
            string costMax = "30";
         
            var optionSet = new OptionSet
            {
                {"cm|costMax=", "costMax", x=>costMax = x }              
            };
            // Тестовый проект с хорошо определенными параметрами.
            //var TestProject = new Project()
            //{
            //    Stages = new List<Stage>()
            //    {
            //        new Stage()
            //        {
            //            Id = "1",
            //            Name = "Проектирование",
            //            Duration = 90,
            //            DurationMin = 60,
            //            PriceEarlier = 50000,
            //            PriceDurationChanged = 60000,
            //            PriceLate = 70000,
            //            Start = new DateTime(2020, 1, 1)
            //        },
            //        new Stage()
            //        {
            //            Id = "2",
            //            Name = "Строительство",
            //            Duration = 180,
            //            DurationMin = 120,
            //            PriceEarlier = 50000,
            //            PriceDurationChanged = 60000,
            //            PriceLate = 70000,
            //            Start = new DateTime(2020, 1, 1)
            //        },
            //        new Stage()
            //        {
            //            Id = "3",
            //            Name = "Испытания",
            //            Duration = 90,
            //            DurationMin = 60,
            //            PriceEarlier = 50000,
            //            PriceDurationChanged = 60000,
            //            PriceLate = 70000,
            //            Start = new DateTime(2020, 1, 1)
            //        }
            //    },
            //    Groups = new List<Group>()
            //    {
            //        new Group()
            //        {
            //            Works = new List<Work>()
            //            {
            //               new Work()
            //               {

            //               }
            //            }
            //        }
            //    }


            ////};

            //Console.WriteLine("Hello World!");

            //var project = random.NextProject(2,15,20000);

            //var JsonSerializerSettings = new JsonSerializerSettings()
            //{
            //    MetadataPropertyHandling = MetadataPropertyHandling.ReadAhead,
            //    NullValueHandling = NullValueHandling.Include,
            //    StringEscapeHandling = StringEscapeHandling.Default,
            //    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            //};
            //var ser = JsonConvert.SerializeObject(project, JsonSerializerSettings);
            //Console.WriteLine(ser);
            //File.WriteAllText("1.txt", ser);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Нажмите любую кнопку");
            Console.ReadLine();

            GeneticEnviroment.CostExtr = Convert.ToDouble(costMax);
            GeneticEnviroment.Frozen = new TimeSpan(20,0,0,0) ;
            GeneticEnviroment.NowDateTime = new DateTime(2020, 2, 1);

            var random = new Random();
            var project1 = random.NextProject(2, 5, 20);
            var Time = project1.CreteTimetable();
            var JsonSerializerSettings = new JsonSerializerSettings()
            {
                MetadataPropertyHandling = MetadataPropertyHandling.ReadAhead,
                NullValueHandling = NullValueHandling.Include,
                StringEscapeHandling = StringEscapeHandling.Default,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            var ser = JsonConvert.SerializeObject(Time, JsonSerializerSettings);      
            File.WriteAllText("Etalon.json", ser);
            Console.WriteLine("json сериализация");

            var ListWorkEtanol = Time.Works;
            JsonSerializerSettings = new JsonSerializerSettings()
            {
                NullValueHandling = NullValueHandling.Include,
                StringEscapeHandling = StringEscapeHandling.Default,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            ser = JsonConvert.SerializeObject(ListWorkEtanol, JsonSerializerSettings);
            File.WriteAllText("EtalonWork.json", ser);

            
            var t = new DateTime(2020, 2, 1);
            project1.RandomCompleteWorks(t);
            project1.ExportTimetable("test.txt");
            var s = project1.CreteTimetable();                        
            var ser1 = JsonConvert.SerializeObject(s, JsonSerializerSettings);
            Console.WriteLine("json сериализация");
            File.WriteAllText("1.txt", ser1);

            //var BigProject = random.NextProject(2, 15, 200000);
            //var q = new DateTime(2020, 2, 1);
            //BigProject.RandomCompleteWorks(t);    
            //BigProject.ExportTimetable("BigTable.txt");

            Runner r = new Runner();
            var newTimetable = r.Run(project1);       
            JsonSerializerSettings = new JsonSerializerSettings()
            {
                MetadataPropertyHandling = MetadataPropertyHandling.ReadAhead,
                NullValueHandling = NullValueHandling.Include,
                StringEscapeHandling = StringEscapeHandling.Default,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            ser = JsonConvert.SerializeObject(newTimetable, JsonSerializerSettings);           
            File.WriteAllText("Optimal.json", ser);
            Console.WriteLine("json сериализация");

            var ListWorkOptimum = newTimetable.Works;
            JsonSerializerSettings = new JsonSerializerSettings()
            {              
                NullValueHandling = NullValueHandling.Include,
                StringEscapeHandling = StringEscapeHandling.Default,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            ser = JsonConvert.SerializeObject(ListWorkOptimum, JsonSerializerSettings);
            File.WriteAllText("OptimalWork.json", ser);
        }
    }
}
