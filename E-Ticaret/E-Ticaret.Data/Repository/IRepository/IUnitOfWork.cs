using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticaret.Data.Repository.IRepository
{
    public interface IUnitOfWork:IDisposable
    {
        IAppUserRepository AppUser { get; }
        ICartRepository Cart { get; }
        ICateogoryRepository Cateogory { get; }
        IOrderDetailsRepository OrderDetails { get; }
        IOrderProductRepository OrderProduct { get; }
        IProductRepository Product { get; }

        void Save();
    }
}
