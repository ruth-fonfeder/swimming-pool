using Clean.Core.Repositories;
using Clean.Core.Services;
using swimming_pool.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Service
{
    internal class ClientService: IClientService
    {
        private readonly IClientRepository _clientRepositories;

        public ClientService(IClientRepository clientRepositories)
        {
            _clientRepositories = clientRepositories;
        }

        public List<Client> GetAll()
        {
            return _clientRepositories.GetList();
        }
    }
}
