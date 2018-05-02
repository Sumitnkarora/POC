using AutoFAC.DI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFAC.DI
{
    public class DIGenerator : IGenerator
    {

        public void StartGenerator()
        {
            Console.WriteLine("DI Generator started");
        }
    }
}
