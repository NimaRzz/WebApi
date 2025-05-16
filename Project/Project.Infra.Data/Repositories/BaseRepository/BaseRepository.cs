using Project.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project.Domain.Entities.Offices;
using Project.Domain.Repository.BaseRepository;
using Project.Domain.Common.Dto;

namespace Project.Infra.Data.Repositories.BaseRepository
{
    public class BaseRepository : IBaseRepository
    {
        private readonly DataBaseContext _context;

        public BaseRepository(DataBaseContext context)
        {
            _context = context;
        }

     
        public async Task<ResultDto<T>> Get<T>(object Id) where T : class
        {

            T entity = null;
            if (Id is long longId)
            {
                entity = await _context.Set<T>().AsNoTracking().FirstOrDefaultAsync(e => EF.Property<long>(e, "Id") == longId);
            }

            if (Id is string stringId)
            {
                entity = await _context.Set<T>().AsNoTracking().FirstOrDefaultAsync(e => EF.Property<string>(e, "Id") == stringId);
            }


            if (entity != null)
            {
                return new ResultDto<T>
                {
                    Data = entity,
                    IsSuccess = true
                };
            }
            return new ResultDto<T>
            {
                IsSuccess = false
            };
        }

        public async Task<ResultDto<List<T>>> GetAll<T>() where T : class
        {
            var entity = await _context.Set<T>().AsNoTracking().ToListAsync();

            if (entity == null)
            {
                return new ResultDto<List<T>>()
                {
                    IsSuccess = false
                };
            }

            return new ResultDto<List<T>>()
            {
                Data = entity,
                IsSuccess = true,
            };
        }

        public async Task Add<T>(T Object) where T : class
        {
            await _context.Set<T>().AddAsync(Object);
        }

        public async Task AddRange<T>(List<T> Object) where T : class
        {
            await _context.Set<T>().AddRangeAsync(Object);
        }

        public async Task Update<T>(T Object) where T : class
        {
            if (Object != null)
            {
                var entry = _context.Entry(Object);

                // استخراج RowVersion از رکورد قدیمی

                entry.CurrentValues.SetValues(Object);

                entry.State = EntityState.Modified;

                entry.Property("InsertTime").IsModified = false;

            }

        }

        public async Task Delete<T>(T Object) where T : class
        {

            if (Object != null)
            { 
                _context.Remove(Object);
            }
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
