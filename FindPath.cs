using System.Collections.Generic;

namespace PathFinding
{
	public class FindPath
	{
		private bool[] marked;
		private int[] edgeTo;

		public FindPath(int edges, Cell startPosition, Cell goalPosition)
		{
			bool[] marked = new bool[edges];
			int[] edgeTo = new int[edges];
			Dfs(startPosition, goalPosition);
		}

		public void Dfs(Cell startPosition, Cell goalPosition)
		{
			Queue<Cell> q = new Queue<Cell>();	
			marked[startPosition.edge] = true;
			q.Enqueue(startPosition);

		}

	}
}