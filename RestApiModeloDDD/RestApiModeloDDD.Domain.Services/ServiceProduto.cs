using RestApiModeloDDD.Domain.Core.Interfaces.Repositories;
using RestApiModeloDDD.Domain.Core.Interfaces.Services;
using RestApiModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApiModeloDDD.Domain.Services
{
    public class ServiceProduto : ServiceBase<Produto>, IServiceProduto
    {
        private readonly IRepositoryProduto repositoryProduto;

        public ServiceProduto(IRepositoryProduto repositoryProduto) : base(repositoryProduto)
        {
            this.repositoryProduto = repositoryProduto;
        }
    }
}
