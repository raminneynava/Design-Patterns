using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Facade.Services;

namespace Facade
{
    public class Facade
    {
        public void doSomething()
        {
            Service1 service1 = new Service1();
            Service2 service2 = new Service2();
            Service3 service3 = new Service3();

            service1.Action1();
            service2.Action2();
            service3.Action3();

        }    
    }
}
