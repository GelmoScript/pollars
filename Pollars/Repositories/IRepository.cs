using Pollars.Models;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Pollars.Repositories
{
	public interface IRepository<Entity> where Entity : BaseEntity
	{
		IQueryable<Entity> Get(Expression<Func<Entity, bool>> predicate = null, params Expression<Func<Entity, object>>[] includeProperties);
		Entity GetById(int id);
		Task<Entity> Add(Entity entity);
		Task<Entity> Update(Entity entity);
		Task<Entity> Delete(Entity entity);
	}
}
