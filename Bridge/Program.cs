using System;

using Bridge.Bridge.Abstractions;

namespace Bridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Abstraction abstraction = new RefindeAbstraction();
            abstraction.Function();
        }
    }
}
