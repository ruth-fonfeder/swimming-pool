using Clean.Core.Repositories;
using swimming_pool;
using swimming_pool.Entities;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Clean.Data.Repisitories
{
    public class ClientRepositories: IClientRepository
    {
        private readonly DataContext _context;

        public ClientRepositories(DataContext context)
        {
            _context = context;
        }
        public List<Client> GetList()
        {
            return _context.Clients;
        }
    }
}
