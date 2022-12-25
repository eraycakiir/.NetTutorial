using e_ticket.Data.Base;
using e_ticket.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_ticket.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor> , IActorService
    {
        
        public ActorsService(AppDbContext context) : base(context) { }
    }
}
