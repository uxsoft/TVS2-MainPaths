using System;

namespace TVS2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Graph graph = new Graph() { EndVertex = 6 };
            graph.Edges.Add(Tuple.Create(0, 4));
            graph.Edges.Add(Tuple.Create(4, 4));
            graph.Edges.Add(Tuple.Create(0, 1));
            graph.Edges.Add(Tuple.Create(1, 2));
            graph.Edges.Add(Tuple.Create(2, 3));
            graph.Edges.Add(Tuple.Create(3, 1));
            graph.Edges.Add(Tuple.Create(1, 5));
            graph.Edges.Add(Tuple.Create(5, 6));
            graph.Edges.Add(Tuple.Create(4, 6));

            Console.WriteLine("Starting calculation");
            graph.Calculate();
            Console.WriteLine("Done");
        }
    }
}
