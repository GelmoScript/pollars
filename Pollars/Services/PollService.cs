using AutoMapper;
using Pollars.Dtos;
using Pollars.Models;
using Pollars.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pollars.Services
{
    public interface IPollService : IBaseService<Poll, PollDto>
    {

    }
    public class PollService : BaseService<Poll,PollDto>, IPollService
    {
        public PollService(IMapper mapper, IRepository<Poll> repository) : base(mapper, repository)
        {

        }
    }
}
