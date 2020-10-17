﻿using Atom.Models2;
using Newtonsoft.Json;
using System;
using System.IO;
using static Atom.Models2.RandomExtension;

namespace Atom.ProjectGenerator2
{
    class Program
    {
        static void Main(string[] args)
        {
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



            var random = new Random();
            var project1 = random.NextProject(2, 3, 5);
            var Time = project1.CreteTimetable();
            var JsonSerializerSettings = new JsonSerializerSettings()
            {
                MetadataPropertyHandling = MetadataPropertyHandling.ReadAhead,
                NullValueHandling = NullValueHandling.Include,
                StringEscapeHandling = StringEscapeHandling.Default,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            var ser = JsonConvert.SerializeObject(Time, JsonSerializerSettings);
            Console.WriteLine("json сериализация");
            File.WriteAllText("Etalon.txt", ser);


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
        }
    }
}
