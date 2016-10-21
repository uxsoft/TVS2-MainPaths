using System;

namespace TVS2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Graph graph = new Graph() { EndVertex = 8 };
            graph.Edges.Add(Tuple.Create(0, 1));
            graph.Edges.Add(Tuple.Create(1, 2));
            graph.Edges.Add(Tuple.Create(1, 6));
            graph.Edges.Add(Tuple.Create(2, 3));
            graph.Edges.Add(Tuple.Create(2, 4));
            graph.Edges.Add(Tuple.Create(3, 5));
            graph.Edges.Add(Tuple.Create(4, 5));
            graph.Edges.Add(Tuple.Create(5, 6));
            graph.Edges.Add(Tuple.Create(6, 7));
            graph.Edges.Add(Tuple.Create(7, 8));
            graph.Edges.Add(Tuple.Create(7, 9));
            graph.Edges.Add(Tuple.Create(9, 10));
            graph.Edges.Add(Tuple.Create(9, 11));
            graph.Edges.Add(Tuple.Create(10, 12));
            graph.Edges.Add(Tuple.Create(11, 12));
            graph.Edges.Add(Tuple.Create(12, 13));
            graph.Edges.Add(Tuple.Create(13, 7));

            Console.WriteLine("Starting calculation");
            graph.Calculate();
            Console.WriteLine("Done");
        }

        public static void LectureExample()
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

        public static void Homework()
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
