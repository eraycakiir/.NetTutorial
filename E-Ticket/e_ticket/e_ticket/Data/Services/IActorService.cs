using e_ticket.Models;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace e_ticket.Data.Services
{
    public interface IActorService
    {
       Task<IEnumerable<Actor>> GetAllAsync();

        Task <Actor> GetByIdAsync(int id);

        Task AddAsync(Actor actor);
        Actor Update(int id, Actor newActor);
        void Delete(int id);
        

    }
}
