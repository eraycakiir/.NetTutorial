using E_Ticaret.Data.Repository.IRepository;
using E_Ticaret.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticaret.Data.Repository
{
    public class CateogryRepository : Repository<Category>, ICateogoryRepository
    {
        private ApplicationDbContext _context;
        public CateogryRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
