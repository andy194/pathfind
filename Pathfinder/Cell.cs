using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder
{
    public class Cell
    {
        public Cell(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public Cell(int x, int y, string content)
        {
            this.Contents = content;
            this.X = x;
            this.Y = y;
        }
        public string? Contents { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int count { get; set; }
        public bool IsPath { 
            get
            {
                return Contents == ".";
            }
        }
    }
}
