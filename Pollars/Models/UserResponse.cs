using Pollar.Core.Enums;
using Pollars.Dtos;

namespace Pollars.Models
{
	public class UserResponse
	{
		public UserResponseCode ResCode { get; set; }
		public UserDto Data { get; set; }
	}
}
