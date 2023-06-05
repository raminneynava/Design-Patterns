using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public interface IFactory
    {
        IDesktop CreateDesktop();
        ILaptop CreateLaptop();
    }

    public class ConcreateCpuFactory : IFactory
    {
        public IDesktop CreateDesktop()
        {
            return new CpuDesktop();
        }

        public ILaptop CreateLaptop()
        {
            return new CpuLaptop();
        }
    }
    public class ConcreateRamFactory : IFactory
    {
        public IDesktop CreateDesktop()
        {
            return new RamDesktop();
        }

        public ILaptop CreateLaptop()
        {
            return new RamLaptop();
        }
    }
    public class ConcreatePowerFactory : IFactory
    {
        public IDesktop CreateDesktop()
        {
            return new PowerDesktop();
        }

        public ILaptop CreateLaptop()
        {
            return new PowerLaptop();
        }
    }
}
