using AutoFAC.DI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFAC.DI
{
    public class DICar : ICar
    {
        public IEngine diEngine { get; set; }

        public DICar(IEngine engine)
        {
            diEngine = engine;
        }

        public void StartCar()
        {
            diEngine.StartEngine();
            Console.WriteLine("DI Car has been started");
        }
    }
}
