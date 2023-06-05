using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod2
{
    public interface IEmailManager
    {
        void Send();
    }



    public class Google : IEmailManager
    {
        public void Send()
        {
           //google code
        }
    }

    public class Yahoo : IEmailManager
    {
        public void Send()
        {
          //yahoo code
        }
    }

    public class Hotmail : IEmailManager
    {
        public void Send()
        {
            //Hotmail code
        }
    }
}
