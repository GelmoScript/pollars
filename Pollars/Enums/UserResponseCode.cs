using System;
using System.Collections.Generic;
using System.Text;

namespace Pollar.Core.Enums
{
	public enum UserResponseCode
	{
		Created = 1,
		UserAlreadyExists,
		UserNotExist,
		IncorrectPassword,
		PasswordsNotMatch,
		NoDataProvided
	}
}
