using swimming_pool.Controllers;
using swimming_pool.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    internal class ClientControllerTest
    {
        public void GetClientOk()
        {
            //Arange

            //Act
            var controllers = new ClientController();
            var result = controllers.GetClient();
            //Asert
            Assert.IsType < List<Client>>(result);
        }
    }
}
