using E_Ticaret.Data.Repository.IRepository;
using E_Ticaret.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticaret.Data.Repository
{
    public class OrderProductRepository : Repository<OrderProduct>, IOrderProductRepository
    {
        private ApplicationDbContext _context;
        public OrderProductRepository(ApplicationDbContext context) : base(context)
        {
            private ApplicationDbContext _context;
    }
    }
}
