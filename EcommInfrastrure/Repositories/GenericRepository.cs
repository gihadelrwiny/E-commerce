using EcommCore.interfaces;
using EcommInfrastrure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace EcommInfrastrure.Repositories
{
   public class GenericRepository<T> : IgenericRepository<T> where T : class
    {
        private readonly AppDbContext _context;
        public GenericRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task addasync(T entity)
        {
            await _context.Set<T>().AddAsync(entity); //set because حسب النوع
                await _context.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
       => await _context.Set<T>().AsNoTracking().ToListAsync();

        public async Task<IReadOnlyList<T>> GetAllAsync(params Expression<Func<T, object>>[] includes)//dynamic include
        {
            var entity =  _context.Set<T>().AsQueryable();//عشان لسة هضيف حجات تانية
            foreach( var item in includes)
            {
                entity = entity.Include(item);
            }
         return   await entity.ToListAsync();


        }

        public async Task<T> GetByIdAsync(int id)
        {
            var entity =await _context.Set<T>().FindAsync(id);
            return entity;
        }

        public async Task<T> GetByIdAsync(int id, params Expression<Func<T, object>>[] includes)
        {
            var entity = _context.Set<T>().AsQueryable();//عشان لسة هضيف حجات تانية
            foreach (var item in includes)
            {
                entity = entity.Include(item);
            }
            var result = await entity.FirstOrDefaultAsync(e => EF.Property<int>(e, "Id") == id);
            return result;
        }

        public async Task removeasync(int id)
        {
            var entity = await _context.Set<T>().FindAsync(id);
             _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
           
        }

        public async Task updateasync(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
