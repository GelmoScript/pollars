using Pollars.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pollars.Services
{
	public interface IBaseService<EntityDto> where EntityDto : BaseDto
	{
		Task<EntityDto> GetById(int id);
		Task<EntityDto> Create(EntityDto entityDto);
		Task<EntityDto> Update(int id, EntityDto entityDto);
		Task<EntityDto> Delete(int id);
		Task<IEnumerable<EntityDto>> Get();
	}
}
