using System;
using System.Collections.Generic;

namespace QueueCS
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoQueue();
        }


        private static void DemoQueue()
        {
            Queue<string> movies = new Queue<string>();

            // Enqueue (Add Items)
            movies.Enqueue("Ace Ventura");
            movies.Enqueue("Batman");
            movies.Enqueue("Cable Guy");
            movies.Enqueue("Dallas Buyers Club");
            movies.Enqueue("East of Eden");

            Console.WriteLine("Default content of Queue");

            foreach (string movie in movies)
            {
                Console.WriteLine(movie);
            }

            // Dequeuing (Remove Items)
            Console.WriteLine($"Dequeuing { movies.Dequeue() }");
            Console.WriteLine($"The next item to dequeue using Peek(): { movies.Peek() }");
            Console.WriteLine($"Dequeuing { movies.Dequeue() }");


            // Create Copy
            Queue<string> queueCopy = new Queue<string>(movies.ToArray());

            Console.WriteLine("Contents of the first copy:");
            foreach (string movie in queueCopy)
            {
                Console.WriteLine(movie);
            }


            // Copy Items to Array then to another Queue
            string[] array2 = new string[movies.Count * 2];
            movies.CopyTo(array2, movies.Count);
            Queue<string> queueCopy2 = new Queue<string>(array2);
            Console.WriteLine("Contents of the second copy including nulls:");
            foreach (string movie in queueCopy2)
            {
                Console.WriteLine(movie);
            }


            // Check if Queue Contains
            Console.WriteLine($"\nqueueCopy.Contains(\"Dallas Buyers Club\") = { queueCopy.Contains("Dallas Buyers Club") }");


            // Clear 
            Console.WriteLine("\nqueueCopy.Clear()");
            queueCopy.Clear();
            Console.WriteLine($"\nqueueCopy.Count = { queueCopy.Count }");

        }

    }

}
