using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public abstract  class Strategy
    {
        public abstract void AlgoritmInterface();
    }


    public class ConcreateStrategyA : Strategy
    {
        public override void AlgoritmInterface()
        {
            Console.WriteLine("ConcreateStrategyA.AlgoritmInterface()");
        }
    }

    public class ConcreateStrategyB : Strategy
    {
        public override void AlgoritmInterface()
        {
            Console.WriteLine("ConcreateStrategyB.AlgoritmInterface()");
        }
    }

    public class ConcreateStrategyC : Strategy
    {
        public override void AlgoritmInterface()
        {
            Console.WriteLine("ConcreateStrategyC.AlgoritmInterface()");
        }
    }

    public class Context
    {
        private Strategy _strategy;
        public Context(Strategy strategy)
        {
            _strategy= strategy;
        }

        public void ContextInterface()
        {
            _strategy.AlgoritmInterface();
        }
    }
}
