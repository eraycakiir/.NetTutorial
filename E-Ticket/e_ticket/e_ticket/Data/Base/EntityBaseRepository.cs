using e_ticket.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Collections.Generic;
using System.Threading.Tasks;
                                                                                                                                                  ///Adım Adım BaseRepo mantığını yazıcam ilgili scriptleri takip et;
                                                                                                                                                  // 1;IEntityBase adında bir interface açıldı
                                                                                                                                                  // 2;Ardından IEntityBaseRepositor adında bir  generic interface açılıp IEntityBaseden kalıtım aldı ve aşağıya metodlarımız yazıldı
                                                                                                                                                  // 3;Ardından EntityBaseRepository adında Class acıldı ve yukarıdakilerden kalıtım alındı ve implement edilip metokların kodu yazıldı,,
                                                                                                                                                  // 4; Actors modeli IEntityBaseden kalıtım aldı 
                                                                                                                                                  // 5;IActor service  IEntityBaseRepository den kalıtım aldı
                                                                                                                                                  // 6; Actors Service de EntityBaseRepositort klasından ve IActor servisten kalıtım aldı   //Actoru o an kullandıgım icin ornek verdim
namespace e_ticket.Data.Base
{
    public class EntityBaseRepository<T> : IEntityBaseRepository<T> where T : class, IEntityBase, new()                                  
    {
        private readonly AppDbContext _context;
        public EntityBaseRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();

        }
        
        public async Task DeleteAsync(int id)
        { 
            var entity =  await _context.Set<T>().FirstOrDefaultAsync(n=>n.Id== id);
            EntityEntry entityEntry = _context.Entry<T>(entity);
            entityEntry.State = EntityState.Deleted;

            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync() => await _context.Set<T>().ToListAsync();
         
        public async Task<T> GetByIdAsync(int id)   //Yukardaki yazım ile bu yazım aynı örnk olsun diye bıraktım
        {
            var result = await _context.Set<T>().FirstOrDefaultAsync(n => n.Id == id);
            return result;
        }
        public async Task UpdateAsync(int id, T entity)
        {
            EntityEntry entityEntry = _context.Entry<T>(entity);
            entityEntry.State = EntityState.Modified;
           
            await _context.SaveChangesAsync();
        }
    }
}
    