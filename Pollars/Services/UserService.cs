using AutoMapper;
using Pollars.Dtos;
using Pollars.Models;
using Pollars.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pollars.Services
{
	public interface IUserService : IBaseService<User,UserDto>
	{
		UserDto GetByUsername(string username);
	}
	public class UserService : BaseService<User,UserDto>, IUserService
	{
		private readonly IMapper _mapper;
		private readonly IRepository<User> _repository;

		public UserService(IMapper mapper, IRepository<User> repository) : base (mapper, repository)
		{
			_mapper = mapper;
			_repository = repository;
		}

		public UserDto GetByUsername(string username)
		{
			var user = _repository.Get(x => x.Username == username);
			return _mapper.Map<UserDto>(user);
		}
	}
}
