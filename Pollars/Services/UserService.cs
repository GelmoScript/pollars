using AutoMapper;
using Pollars.Dtos;
using Pollars.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pollars.Services
{
	public interface IUserService : IBaseService<UserDto>
	{
		Task<UserDto> GetByUsername(string username);
	}
	public class UserService : IUserService
	{
		private readonly IMapper _mapper;
		private readonly IUserRepository _repository;

		public UserService(IMapper mapper, IUserRepository repository)
		{
			_mapper = mapper;
			_repository = repository;
		}

		public async Task<UserDto> GetById(int id)
		{
			var User = await _repository.GetById(id);
			return _mapper.Map<UserDto>(User);
		}

		public async Task<UserDto> GetByUsername(string username)
		{
			var users = await Get();
			return users.FirstOrDefault(user => user.Username == username);
		}

		public async Task<UserDto> Create(UserDto entityDto)
		{
			var User = _mapper.Map<User>(entityDto);
			await _repository.Add(User);
			return _mapper.Map<UserDto>(User);
		}

		public async Task<UserDto> Update(int id, UserDto entityDto)
		{
			var User = await _repository.GetById(id);

			if (User is null) return null;

			_mapper.Map(entityDto, User);

			await _repository.Update(User);

			return _mapper.Map(User, entityDto);
		}

		public async Task<UserDto> Delete(int id)
		{
			var User = await _repository.GetById(id);

			if (User is null) return null;

			await _repository.Delete(User);

			return _mapper.Map<UserDto>(User);
		}

		public async Task<IEnumerable<UserDto>> Get()
		{
			var Users = await _repository.Get();
			return _mapper.Map<IEnumerable<UserDto>>(Users);
		}
	}
}
