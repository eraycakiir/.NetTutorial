using e_ticket.Data.Base;
using e_ticket.Models;

namespace e_ticket.Data.Services
{
    public class ProducersService:EntityBaseRepository<Producer>,IProducersService
    {
        public ProducersService(AppDbContext context):base(context)
        {

        }
    }
}
