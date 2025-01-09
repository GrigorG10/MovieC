using MovieStoreC.DL.Interfaces;
using MovieStoreC.DL.StaticData;
using MovieStoreC.Models.DTO;

namespace MovieStoreC.DL.Repositories
{
    internal class ActorStaticDataRepository : IActorRepository
    {
        public List<Actor> GetAll()
        {
            return StaticDb.Actors;
        }

        public Actor? GetById(string id)
        {
            if (id <= 0) return null;

            return StaticDb.Actors
                .FirstOrDefault(x => x.Id == id);
        }
    }
}
