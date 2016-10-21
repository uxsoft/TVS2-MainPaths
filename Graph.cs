using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace TVS2
{
    public class Graph
    {
        public List<Tuple<int, int>> Edges { get; set; } = new List<Tuple<int, int>>();
        public int StartVertex { get; set; } = 0;
        public int EndVertex { get; set; }

        public void Calculate()
        {
            List<IEnumerable<int>> tuples = Edges
                .Select(e => (IEnumerable<int>)(new int[] { e.Item1, e.Item2 }))
                .ToList();

            List<IEnumerable<int>> mainPaths = new List<IEnumerable<int>>();
            CalculateMainPaths(tuples, ref mainPaths);
            mainPaths = mainPaths
                .Where(p1 =>
                {
                    string p1s = String.Join(" ", p1);

                    foreach (var p2 in mainPaths)
                    {
                        string p2s = String.Join(" ", p2);
                        if (p2s.Length > p1s.Length && p2s.Contains(p1s))
                        {
                            return false;
                        }
                    }
                    return true;
                })
                .ToList();

            foreach (var tuple in mainPaths)
            {
                if (tuple.Last() == EndVertex)
                    Console.WriteLine($"{string.Join(" ", tuple)}!");
                else if (tuple.First() == tuple.Last())
                    Console.WriteLine($"{string.Join(" ", tuple)}*");
            }
        }

        public bool Joinable(IEnumerable<int> t1, IEnumerable<int> t2)
        {
            string t1s = string.Join(" ", t1.Skip(1));
            string t2s = string.Join(" ", t2.Take(t2.Count() - 1));
            return t1s == t2s;
        }

        public void CalculateMainPaths(List<IEnumerable<int>> tuples, ref List<IEnumerable<int>> mainPaths)
        {
            List<IEnumerable<int>> nextLayer = new List<IEnumerable<int>>();
            foreach (var tuple in tuples)
            {
                if (tuple.Last() == EndVertex)
                {
                    //Console.WriteLine($"{string.Join(" ", tuple)}!");
                    mainPaths.Add(tuple);
                    continue;
                }

                if (tuple.First() == tuple.Last())
                {
                    //Console.WriteLine($"{string.Join(" ", tuple)}*");
                    mainPaths.Add(tuple);
                    continue;
                }

                foreach (var tuple2 in tuples)
                {
                    if (Joinable(tuple, tuple2))
                    {
                        nextLayer.Add(tuple.Append(tuple2.Last()));
                    }
                }
            }
            if (nextLayer.Any())
                CalculateMainPaths(nextLayer, ref mainPaths);
        }
    }
}