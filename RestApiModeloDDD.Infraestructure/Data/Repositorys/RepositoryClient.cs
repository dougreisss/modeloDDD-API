using RestApiModeloDDD.Domain.Core.Interfaces.Repositorys;
using RestApiModeloDDD.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApiModeloDDD.Infraestructure.Data.Repositorys
{
    public class RepositoryClient : RepositoryBase<Client>, IRepositoryClient
    {
        private readonly SqlContext sqlContext;

        public RepositoryClient(SqlContext sqlContext) 
            : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }

    }
}
