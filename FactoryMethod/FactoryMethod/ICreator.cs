using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.FactoryMethod
{
    public interface ICreator
    {
        IEmailManager FactoryMethod();
    }
    public class Creator : ICreator
    {
        public IEmailManager FactoryMethod()
        {
            string config = "google";

            if(config== "google")
            {
                return new Google();
            }
            else
            {
                return new Yahoo();
            }
        }
    }
}
