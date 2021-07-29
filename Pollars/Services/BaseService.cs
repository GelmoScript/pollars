using AutoMapper;
using Pollars.Dtos;
using Pollars.Models;
using Pollars.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pollars.Services
{
    public class BaseService<TEntity,TEntityDto> : IBaseService<TEntity, TEntityDto> where TEntity : BaseEntity where TEntityDto : BaseDto 
    {
        private readonly IMapper _mapper;
        private readonly IRepository<TEntity> _repository;

        public BaseService(IMapper mapper, IRepository<TEntity> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public async Task<TEntityDto> Create(TEntityDto entityDto)
        {
            var entity = _mapper.Map<TEntity>(entityDto);
            entity = await _repository.Add(entity);

            return _mapper.Map<TEntityDto>(entity);
        }

        public async Task<TEntityDto> Delete(int id)
        {
            var entity = _repository.GetById(id);
            entity = await _repository.Delete(entity);

            return _mapper.Map<TEntityDto>(entity);
        }

        public async Task<IQueryable<TEntityDto>> Get()
        {
            var entities = _repository.Get();
            return _mapper.Map<IQueryable<TEntityDto>>(entities);
        }

        public async Task<TEntityDto> GetById(int id)
        {
            var dto = _repository.GetById(id);
            return _mapper.Map<TEntityDto>(dto);
        }

        public async Task<TEntityDto> Update(int id, TEntityDto entityDto)
        {
            var entity = _repository.GetById(id);
            if (entity is null) return null;

            entity = _mapper.Map(entityDto, entity);
            entity = await _repository.Update(entity);

            return _mapper.Map<TEntityDto>(entity);
        }
    }
}
