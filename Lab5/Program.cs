// Read the data from the file
//using Lab5;

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