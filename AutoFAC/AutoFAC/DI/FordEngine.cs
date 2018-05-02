using AutoFAC.DI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFAC.DI
{
    public class FordEngine : IEngine
    {
        public IGenerator _generator { get; set; }

        public FordEngine(IGenerator generator)
        {
            _generator = generator;
        }

        public void StartEngine()
        {
            _generator.StartGenerator();
            Console.WriteLine("Ford engine has started");
        }
    }
}
