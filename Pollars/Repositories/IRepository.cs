using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pollars.Models
{
	public interface IRepository<Entity> where Entity : BaseEntity
	{
		Task<IEnumerable<Entity>> Get();
		Task<Entity> GetById(int id);
		Task Add(Entity entity);
		Task Update(Entity entity);
		Task Delete(Entity entity);
	}
}
