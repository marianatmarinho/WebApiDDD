using RestApiModeloDDD.Domain.Core.Interfaces.Repositories;
using RestApiModeloDDD.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApiModeloDDD.Domain.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> repository;
        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            this.repository = repository;
        }
        public void Add(TEntity obj)
        {
            repository.Add(obj);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return repository.GetAll();
        }

        public TEntity GetByID(int id)
        {
            return repository.GetById(id);
        }

        public void Remove(TEntity obj)
        {
            repository.Remove(obj);
        }

        public void Update(TEntity obj)
        {
            repository.Update(obj);
        }
    }
}
