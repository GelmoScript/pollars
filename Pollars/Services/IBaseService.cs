using Pollars.Dtos;
using Pollars.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pollars.Services
{
	public interface IBaseService<Entity, EntityDto> where EntityDto : BaseDto where Entity : BaseEntity
	{
		Task<EntityDto> GetById(int id);
		Task<EntityDto> Create(EntityDto entityDto);
		Task<EntityDto> Update(int id, EntityDto entityDto);
		Task<EntityDto> Delete(int id);
		Task<IQueryable<EntityDto>> Get();
	}
}
