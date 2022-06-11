using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class SingletonLazy
    {
        public string _name="ramin";
        public int _age=32;
        private static readonly  Lazy<SingletonLazy> instance = new Lazy<SingletonLazy>(()=>new SingletonLazy());
        private SingletonLazy()
        {

        }
        public static SingletonLazy GeTinstance()
        {
            return instance.Value;
        }
    }
}
