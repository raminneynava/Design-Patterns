using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class Decorator : Component
    {
        private readonly Component _component;

        protected Decorator(Component component)
        {
            _component = component;
        }

        public override void Operation()
        {
            _component.Operation();
        }
    }
    public class ConcreateDecorator : Decorator
    {
        public ConcreateDecorator(Component component) : base(component)
        {

        }
        public override void Operation()
        {
            base.Operation();
            NewFeature();
        }
        public void NewFeature()
        {
            Console.WriteLine("NewFeature");
        }
    }
    public class ConcreateDecorator2 : Decorator
    {
        public ConcreateDecorator2(Component component) : base(component)
        {

        }
        public override void Operation()
        {
            base.Operation();
            NewFeature();
        }
        public void NewFeature()
        {
            Console.WriteLine("NewFeature2");
        }
    }
}
