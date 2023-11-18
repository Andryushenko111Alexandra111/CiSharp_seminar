// int Prompt(string massage)
// {
//     System.Console.WriteLine(massage);
//     string inputString = Console. ReadLine();
//     int number = Convert.ToInt32(inputString);
//     return number;
// }

﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication
{
    public class Program
    {
        private static Dictionary<string, string[]> _graph = new Dictionary<string, string[]>();

        public static void Main(string[] args)
        {
            _graph.Add("Вы", new[] { "Алиса", "Тэди", "Гари" });
            _graph.Add("Тэди", new[] { "Анна", "Пётр" });
            _graph.Add("Алиса", new[] { "Дима" });
            _graph.Add("Гари", new[] { "Том", "Джон" });
            _graph.Add("Анна", Array.Empty<string>());
            _graph.Add("Пётр", Array.Empty<string>());
            _graph.Add("Том", Array.Empty<string>());
            _graph.Add("Джон", Array.Empty<string>());
            Search("Вы");
        }

        private static bool Search(string name)
        {
            var searchQueue = new Queue<string>(_graph[name]);
            var searched = new List<string>();
            while (searchQueue.Any())
            {
                var person = searchQueue.Dequeue();
                if (!searched.Contains(person))
                {
                    if (PersonIsSeller(person))
                    {
                        Console.WriteLine($"{person} является продавцом манго!!!");
                        return true;
                    }
                    else
                    {
                        searchQueue = new Queue<string>(searchQueue.Concat(_graph[person]));
                        searched.Add(person);
                    }
                }
            }
            return false;
        }

        private static bool PersonIsSeller(string name)
        {
            return name.EndsWith("н");
        }
    }
}