using RestApiModeloDDD.Domain.Core.Interfaces.Repositorys;
using RestApiModeloDDD.Domain.Core.Interfaces.Services;
using System.Collections.Generic;

namespace RestApiModeloDDD.Domain.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> repositoryBase;

        public ServiceBase(IRepositoryBase<TEntity> repositoryBase)
        {
            this.repositoryBase = repositoryBase;
        }

        public void Add(TEntity obj)
        {
            repositoryBase.Add(obj);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return repositoryBase.GetAll();
        }

        public TEntity GetById(int id)
        {
            return repositoryBase.GetById(id);
        }

        public void Remove(TEntity obj)
        {
            repositoryBase.Remove(obj);
        }

        public void Update(TEntity obj)
        {
            repositoryBase.Update(obj);
        }
    }
}
