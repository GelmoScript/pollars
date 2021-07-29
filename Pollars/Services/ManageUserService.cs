using Pollar.Core.Enums;
using Pollars.Dtos;
using Pollars.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Pollars.Services
{
	public interface IManageUserService
	{
		Task<UserResponse> CreateUser(UserDto entityDto);
		Task<UserDto> GetByUsername(string username);
		Task<bool> UserExists(string username);
	}
	public class ManageUserService : IManageUserService
	{
		private readonly IUserService _service;
		public ManageUserService(IUserService service)
		{
			_service = service;
		}

		public async Task<UserResponse> CreateUser(UserDto entityDto)
		{
			var response = new UserResponse();
			if (entityDto is null)
			{
				response.ResCode = UserResponseCode.NoDataProvided;
				return response;
			}

			if (await UserExists(entityDto.Username))
			{
				response.ResCode = UserResponseCode.UserAlreadyExists;
				return response;
			}

			if (entityDto.Password == entityDto.ConfirmPassword)
			{
				response.ResCode = UserResponseCode.PasswordsNotMatch;
				return response;
			}

			var newUser = await _service.Create(entityDto);
			response.ResCode = UserResponseCode.Created;
			response.Data = newUser;
			return response;
		}

		public async Task<UserDto> GetByUsername(string username)
		{
			var users = await _service.Get();
			return users.FirstOrDefault(user => user.Username == username);
		}

		public async Task<bool> UserExists(string username)
		{
			var users = await _service.Get();
			return users.Any(user => user.Username == username);
		}
	}
}
