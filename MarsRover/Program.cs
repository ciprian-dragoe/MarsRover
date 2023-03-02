using System.Collections.Generic;
using MarsRover.Model;
using MarsRover.Services;

namespace MarsRover
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      ICreateMap _mapCreator = new CreateMap();
      Map map1 = _mapCreator.CreateEmptyMap(5, 5);
      Map map2 = _mapCreator.CreateEmptyMap(10, 10);

      ICreateRandomCoord _createRandomCoord = new CreateRandomCoord();

      var randomCoord1 = _createRandomCoord.getEmptyCellCoordinate(map1);
      var randomCoord2 = _createRandomCoord.getEmptyCellCoordinate(map2);
      var map3 = new Map()
      {
        numberColumns = 2,
        numberRows = 2,
        Cells = new List<List<int>>
        {
          new List<int> { 0, 6 },
          new List<int> { 5, 0 },
        }
      };
      var randomCoord3 = _createRandomCoord.getEmptyCellCoordinate(map3); // can only be 0,0 or 1,1
    }
  }
}