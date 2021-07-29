using AutoMapper;
using Pollars.Dtos;
using Pollars.Models.Questions;
using Pollars.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pollars.Services
{
    public interface IQuestionService : IBaseService<Question, QuestionDto>
    {

    }
    public class QuestionService : BaseService<Question, QuestionDto>, IQuestionService
    {
        public QuestionService(IMapper mapper, IRepository<Question> repository) : base (mapper, repository)
        {

        }
    }
}
