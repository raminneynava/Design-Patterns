using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public interface ILaptop
    {

    }

    public class CpuLaptop: ILaptop
    {
        public override string ToString()
        {
            return "CpuLaptop";
        }
    }

    public class RamLaptop : ILaptop
    {
        public override string ToString()
        {
            return "RamLaptop";
        }
    }
    public class PowerLaptop : ILaptop
    {
        public override string ToString()
        {
            return "PowerLaptop";
        }
    }
}
