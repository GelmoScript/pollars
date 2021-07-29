using System;
using System.Collections.Generic;
using System.Text;

namespace Pollars.Dtos
{
	public class BaseDto : IBaseDto
	{
		public int Id { get; set; }
		public bool Deleted { get; set; }
	}
}
