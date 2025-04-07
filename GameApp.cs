using FinderTest;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FinderTest
{
    class GameApp
    {
        public void Run()
        {
            List<Games> orders = GetData("data.txt"); //textovka jak se jmenuje

            while (true)  //nekonecnej loop
            {
                Console.WriteLine("Zadejte ID: ");
                string orderNumber = (Console.ReadLine()); 


                Console.WriteLine("Zadejte Jmeno: ");
                string pin = (Console.ReadLine());

                var order = orders.FirstOrDefault(o => o.id == orderNumber && o.name == pin);



                if (order != null)
                {
                    Console.WriteLine($"Hra: {order.name}, Žánr: {order.genre}, Velikost: {order.size}, Hodin nahráno:{order.hours}, Velikost: {order.size}GB, Nainstalováno: {order.installed}, Průměrná délka hraní: {order.avgSession}, Naposledy hráno: {order.lastPlayed}, Odemknutých achievementů:{order.achievements}, Dokončeno: {order.completed}, Hodnocení: {order.reviews} ");
                }
                else
                {
                    Console.WriteLine("Hra nebyla nalezena.");
                }

                Console.WriteLine("Chcete pokračovat? (Ano/Exit): ");
                string response = Console.ReadLine().ToLower();
                if (response != "ano")
                {
                    break;
                }
            }
        }
        private List<Games> GetData(string fileName)
        {
            var orders = new List<Games>();
            string[] lines = File.ReadAllLines(fileName);

            foreach (var line in lines)
            {
                string[] sp = line.Split(';');
                var order = new Games()
                {
                    ////id;name;genre;hours;size_GB;installed;avg_session;last_played;achievements;completed;review_rating
                    id = sp[0],
                    name = sp[1],
                    genre = sp[2],
                    hours = sp[3],
                    size = sp[4],
                    installed = sp[5].Trim().ToLower() == "true",
                    avgSession = sp[6],
                    lastPlayed = sp[7],
                    achievements = sp[8],
                    completed = sp[9].Trim().ToLower() == "true",
                    reviews = sp[10],

                };
                orders.Add(order);
            }

            return orders;
        }
    }
}
