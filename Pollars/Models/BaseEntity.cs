using System;
using System.Collections.Generic;
using System.Text;

namespace Pollars.Models
{
	public class BaseEntity
	{
		public int Id { get; set; }
		public bool Deleted { get; set; }
	}
}
