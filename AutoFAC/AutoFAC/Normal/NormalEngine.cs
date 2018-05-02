using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFAC.Normal
{
    public class NormalEngine
    {
        public NormalGenerator _generator { get; set; }
        public NormalEngine()
        {
            _generator = new NormalGenerator();
        }

        public void Start()
        {
            _generator.Start();
            Console.WriteLine("Starting engine");
        }
    }
}
