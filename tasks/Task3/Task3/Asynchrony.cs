using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using static System.Console;

namespace Task3
{
    public static class Asynchrony
    {
        public static void Run()
        {
            var random = new Random();

            var xs = new[] { 1, 2, 3, 4 };
            var tasks = new List<Task<int>>();

            foreach (var x in xs)
            {
                // "Task" stellt einen Asyncronen vorgang dar!
                // "Awaitable (Delay)" Aufgaben, die Erst nach (random mit max 10) Verzögerung abgeschlossen werden!
                var task = Task.Run(() =>
                {
                    WriteLine($"computing result for {x}");
                    Task.Delay(TimeSpan.FromSeconds(5.0 + random.Next(10))).Wait();
                    WriteLine($"done computing result for {x}");
                    return x * x;
                });

                tasks.Add(task);    //Fügt am Ende der Liste ein Objekt hinzu
            }

            WriteLine("doing something else ...");

         // Push.Run();             //Other Example  z.B.: Mouse movements!

            var tasks2 = new List<Task<int>>();
            foreach (var task in tasks.ToArray())
            {
                                    // Erstellt eine Fortsetzung, die Asyncron ausgeführt wird, wenn "t.Result" abgeschlossen wurde!
                tasks2.Add(
                    task.ContinueWith(t => { WriteLine($"result is {t.Result}"); return t.Result; })  
                );
            }
            ReadLine();        
        }
    }
}
