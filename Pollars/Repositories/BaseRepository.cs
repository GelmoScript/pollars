using Microsoft.EntityFrameworkCore;
using Pollar.Model.Contexts;
using Pollars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Pollars.Repositories
{
    public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
		private readonly DbSet<TEntity> _dbset;
		public PollarsContext _context;

		public BaseRepository(PollarsContext context)
		{
			_context = context;
			_dbset = _context.Set<TEntity>();
		}
		public IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> predicate = null, params Expression<Func<TEntity, object>>[] includeProperties)
		{
			IQueryable<TEntity> list = _dbset.AsQueryable();

			foreach (var includeProperty in includeProperties)
			{
				list = list.Include(includeProperty);
			}

			if (predicate is null)
				return list;

			return list.Where(predicate);
		}

		public TEntity GetById(int id)
		{
			var entity = _dbset.Where(x => x.Id == id).FirstOrDefault();
			return entity;
		}

		public async Task<TEntity> Add(TEntity entity)
		{
			_dbset.Add(entity);
			await _context.SaveChangesAsync();

			return entity;
		}

		public async Task<TEntity> Update(TEntity entity)
		{
			_dbset.Update(entity);
			await _context.SaveChangesAsync();

			return entity;
		}

		public async Task<TEntity> Delete(TEntity entity)
		{
			entity.Deleted = true;
			_dbset.Update(entity);
			await _context.SaveChangesAsync();

			return entity;
		}
	}
}
