// Read the data from the file
using Lab1;

string[] lines = File.ReadAllLines("data.txt");

// Determine the dimensions of the matrix
int rows = lines.Length;
int columns = lines[0].Split(' ').Length;

// Create the matrix and fill it with the data
int[,] matrix = new int[rows, columns];
for (int i = 0; i < rows; i++)
{
    string[] values = lines[i].Split(' ');
    for (int j = 0; j < columns; j++)
    {
        matrix[i, j] = int.Parse(values[j]);
    }
}

// Print the matrix to the console
Console.WriteLine("This is my matrix:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write("{0} ", matrix[i, j]);
    }
    Console.WriteLine();
}

// Run Kruskal's algorithm on the matrix
List<Edge> edges = new List<Edge>();
for (int i = 0; i < rows; i++)
{
    for (int j = i + 1; j < columns; j++)
    {
        if (matrix[i, j] != 0)
        {
            edges.Add(new Edge(i, j, matrix[i, j]));
        }
    }
}
edges.Sort();

DisjointSet disjointSet = new DisjointSet(rows);
List<Edge> minimumSpanningTree = new List<Edge>();
foreach (Edge edge in edges)
{
    if (disjointSet.Find(edge.From) != disjointSet.Find(edge.To))
    {
        disjointSet.Union(edge.From, edge.To);
        minimumSpanningTree.Add(edge);
    }
}

// Print the minimum spanning tree
Console.WriteLine("Minimum Spanning Tree:");
foreach (Edge edge in minimumSpanningTree)
{
    Console.WriteLine("{0} - {1}: {2}", edge.From, edge.To, edge.Weight);
}