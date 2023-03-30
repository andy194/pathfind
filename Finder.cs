namespace Pathfinder
{
    public class Finder
    {
        private List<List<Cell>> mapGrid= new List<List<Cell>>();

        public void setMap(List<String> map)
        {
            for(int y = 0; y<map.Count; y++)
            {
                List<Cell> row = new List<Cell>();

                Console.WriteLine(map[y]);
                
                string line = map[y];

                for (int x = 0; x < line.Length; x++)
                {
                    char c = line[x];

                    if (c == ' ')
                        continue;

                    row.Add(new Cell(x, y, c.ToString()));
                }

                mapGrid.Add(row);
            }
        }

        public int findRoute(Cell startCell, Cell goalCell)
        {
            Console.WriteLine("Finding route through Map: ");

            List<Cell> map = new List<Cell>();

            Cell? current = getCell(goalCell.X, goalCell.Y);

            List<Cell> adjacent = GetAdjacent(current, map);

            // Really didn't get past this point as had to research pathfinding in gaming!
            // Looked into A* and the Dijkstra algorithm, but not a games dev so it took me longer than the
            // alloted time.  I'd have progressed to a loop as this would be a standard iterative check I think.
            
            return map.Count;
        }

        public List<Cell> GetAdjacent(Cell? cell, List<Cell> currentMap)
        {
#pragma warning disable CS8604 // Possible null reference argument.
            List<Cell> list = new List<Cell>
            {
                getCell(cell.Y - 1, cell.X),
                getCell(cell.Y + 1, cell.X),
                getCell(cell.Y, cell.X + 1),
                getCell(cell.Y, cell.X - 1)
            };
#pragma warning restore CS8604 // Possible null reference argument.

            return list.Where(r => r != null && (!r.IsPath || (r.IsPath && currentMap.Contains(r).Equals(false)))).ToList<Cell>();
        }

        public Cell? getCell(int x, int y)
        {
            if (y < 0 || y > mapGrid.Count - 1)
                return null;

            if (x < 0 || x > mapGrid[y].Count -1)
                return null;

            return mapGrid[y][x];
        }
    }
}
