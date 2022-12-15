using E_Ticaret.Data.Repository.IRepository;
using E_Ticaret.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticaret.Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public IAppUserRepository AppUser =>  new AppUserRepository(_context);

        public ICartRepository Cart => new CartRepository(_context);

        public ICateogoryRepository Cateogory => new CateogryRepository(_context);

        public IOrderDetailsRepository OrderDetails => new OrderDetailsRepository(_context);

        public IOrderProductRepository OrderProduct => new OrderProductRepository(_context);

        public IProductRepository Product => new ProductRepository(_context);

        public void Dispose()
        {
           _context.Dispose();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
