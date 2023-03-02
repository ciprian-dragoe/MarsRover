using MarsRover.Model;

namespace MarsRover.Services
{
    public interface ICreateRandomCoord
    {
        Coordinate getEmptyCellCoordinate(Map map);
    }
}