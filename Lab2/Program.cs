using EllipticCurve.Utils;

List<Integer> eilerPath(int[][] matrixAdjacency)
{
    Stack<Integer> stack = new Stack<>();
    List<Integer> list = new ArrayList<>();
    int v = 0;
    int u;
    int edge;
    stack.push(v);
    while (!stack.empty())
    {
        edge = findAdjacencyVertex(matrixAdjacency, stack.peek());
        if (edge == -1)
        {
            list.add(stack.pop());
        }
        else
        {
            u = edge;
            matrixAdjacency[stack.peek()][u]--;
            matrixAdjacency[u][stack.peek()]--;
            stack.push(u);
        }
    }
    return list;
}

private int findAdjacencyVertex(int[][] matrixAdjacency, int edge)
{
    for (int i = 0; i < matrixAdjacency.length; i++)
    {
        if (matrixAdjacency[edge][i] > 0)
        {
            return i;
        }
    }
    return -1;
}