using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFAC.Normal
{
    public class NormalCar
    {
        public NormalEngine _engine { get; set; }
        public NormalCar()  
        {
            _engine = new NormalEngine();
        }

        public void Start()
        {
            _engine.Start();
            Console.WriteLine("Starting car");
        }
    }
}
