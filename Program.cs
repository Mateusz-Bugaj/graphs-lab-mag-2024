
using System.ComponentModel;

var g = new GraphAdjList<char>();
g.AddEdgesAndVertices(new List<(char, char)> { ('A', 'B'), ('A', 'C'), ('B', 'C'), ('B', 'D'), ('F', 'G')}); ;
// g.AddVertices("ABCDE");
// g.AddEdge('A', 'B');
// g.AddEdge('A', 'C');
// g.AddEdge('B', 'C');
// g.AddEdge('B', 'D');
g.AddVertex('E');

g.Dump();

foreach (var v in GraphAlgorithms.DFS(g, 'A'))
    Console.WriteLine($"Vertex: {v}");

Console.WriteLine(string.Join(", ", g.DFS('A') ));

var l = GraphAlgorithms.DFS(g, 'A').ToList();

Console.WriteLine( g.ToDot() );

//Console.WriteLine(GraphAlgorithms.ConnectedComponents(g));
//Console.WriteLine(GraphAlgorithms.ConnectedComponentsOptymalied(g));

var components = GraphAlgorithms.ConnectedComponentsOptymaliedList(g);

foreach (var component in components)
{
    foreach(var vertex in component)
    {
        Console.WriteLine(vertex.ToString());
    }
    Console.WriteLine();
}
