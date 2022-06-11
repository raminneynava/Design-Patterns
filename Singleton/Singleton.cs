using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class Singleton
    { 
        private static readonly Singleton instance= new Singleton();
        private Singleton()
        {

        }
        public static Singleton GeTinstance()
        {
            return instance;
        }
    }
}
