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
    public class ServiceCliente : ServiceBase<Cliente>, IServiceCliente
    {
        private readonly IRepositoryCliente repositoryCliente;

        public ServiceCliente(IRepositoryCliente repositoryCliente) : base(repositoryCliente)
        {
            this.repositoryCliente = repositoryCliente;
        }
    }
}
