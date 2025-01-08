using swimming_pool.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Core.Repositories
{
    public interface IClientRepository
    {
        List<Client> GetList();
        
    }
}
