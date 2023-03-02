using System.Collections.Generic;

namespace MarsRover.Model
{
    public class Map
    {
        public int numberRows { get; set; }
        public int numberColumns { get; set; }
        public List<List<int>> Cells { get; set; }
    }
}