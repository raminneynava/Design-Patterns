namespace AbstractFactory
{
    public interface IDesktop
    {
    }
    public class CpuDesktop : IDesktop
    {
        public override string ToString()
        {
            return "CpuDesktop";
        }
    }

    public class RamDesktop : IDesktop
    {
        public override string ToString()
        {
            return "RamDesktop";
        }
    }
    public class PowerDesktop : IDesktop
    {
        public override string ToString()
        {
            return "PowerDesktop";
        }
    }
}
