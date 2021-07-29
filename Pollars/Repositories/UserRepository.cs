using Microsoft.EntityFrameworkCore;
using Pollar.Model.Contexts;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pollars.Models
{
	public interface IUserRepository : IRepository<User>
	{

	}
	public class UserRepository : IUserRepository
	{
		private readonly DbSet<User> _dbset;
		public PollarsContext _context;

		public UserRepository(PollarsContext context)
		{
			_context = context;
			_dbset = _context.Set<User>();
		}
		public async Task<IEnumerable<User>> Get()
		{
			var Users = await _dbset.AsNoTracking().ToListAsync();
			return Users.Where(User => !User.Deleted).ToList();
		}

		public async Task<User> GetById(int id)
		{
			var User = await Get();
			return User.Where(kv => kv.Id == id).FirstOrDefault();
		}

		public async Task Add(User entity)
		{
			_dbset.Add(entity);
			await _context.SaveChangesAsync();
		}

		public async Task Update(User entity)
		{
			_dbset.Update(entity);
			await _context.SaveChangesAsync();
		}

		public async Task Delete(User entity)
		{
			entity.Deleted = true;
			_dbset.Update(entity);
			await _context.SaveChangesAsync();
		}
	}
}
