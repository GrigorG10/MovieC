using MovieStoreC.Models.Responses;

namespace MovieStoreC.BL.Interfaces
{
    public interface IBusinessService
    {
        List<MovieFullDetailsResponse> GetAllMovies();
    }
}
