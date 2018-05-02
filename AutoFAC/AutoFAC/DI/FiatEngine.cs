using AutoFAC.DI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFAC.DI
{
    public class FiatEngine : IEngine
    {
        public IGenerator diGenerator { get; set; }

        public FiatEngine(IGenerator generator)
        {
            diGenerator = generator;
        }

        public void StartEngine()
        {
            diGenerator.StartGenerator();
            Console.WriteLine("Fiat Engine has started");
        }
    }
}
