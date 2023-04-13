//// Read the data from the file
////using Lab3;
//class Program()
//{
//    string[] lines = File.ReadAllLines("data.txt");

//    // Determine the dimensions of the matrix
//    int rows = lines.Length;
//    int columns = lines[0].Split(' ').Length;

//    // Create the matrix and fill it with the data
//    static int[,] distances = new int[rows, columns];
//        for (int i = 0; i<rows; i++)
//        {
//            string[] values = lines[i].Split(' ');
//            for (int j = 0; j<columns; j++)
//            {
//                distances[i, j] = int.Parse(values[j]);
//}
//        }

//        // Print the matrix to the console
//        Console.WriteLine("This is my matrix:");
//for (int i = 0; i < rows; i++)
//{
//    for (int j = 0; j < columns; j++)
//    {
//        Console.Write("{0} ", distances[i, j]);
//    }
//    Console.WriteLine();
//}

//static int[] path = new int[6];
//    static bool[] visited = new bool[6];
//    static int shortestDistance = int.MaxValue;

//    static void Main()
//    {




//        static void FindShortestPath(int city, int visitedCities, int distance)
//        {
//            if (visitedCities == 63) // all cities visited
//            {
//                distance += distances[city, 0]; // add distance back to starting city
//                if (distance < shortestDistance)
//                {
//                    shortestDistance = distance;
//                }
//                return;
//            }

//            for (int i = 1; i < 6; i++)
//            {
//                if (!visited[i])
//                {
//                    visited[i] = true;
//                    path[city] = i;
//                    int newDistance = distance + distances[city, i];
//                    FindShortestPath(i, visitedCities | (1 << i), newDistance);
//                    visited[i] = false;
//                }
//            }
//        }

//        FindShortestPath(0, 0, 0);
//        Console.WriteLine("Shortest distance: " + shortestDistance);
//    }
//}