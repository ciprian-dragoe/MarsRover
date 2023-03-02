using MarsRover.Model;

namespace MarsRover.Services
{
    public interface ICreateMap
    {
        Map CreateEmptyMap(int nrRows, int nrColumns);
    }
}