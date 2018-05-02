using Autofac;
using AutoFAC.DI;
using AutoFAC.DI.Interfaces;
using AutoFAC.Normal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFAC
{
    class Program
    {
        static void Main(string[] args)
        {
            //NormalCar car = new NormalCar();
            //car.Start();

            var fiatCarBuilder = new ContainerBuilder();
            fiatCarBuilder.RegisterType<DIGenerator>().As<IGenerator>();
            fiatCarBuilder.RegisterType<DICar>().As<ICar>();
            fiatCarBuilder.RegisterType<FiatEngine>().As<IEngine>();
            var fiatCarContainer = fiatCarBuilder.Build();

            ICar fiatCar = fiatCarContainer.Resolve<ICar>();
            fiatCar.StartCar();

            var fordCarBuilder = new ContainerBuilder();
            fordCarBuilder.RegisterType<DIGenerator>().As<IGenerator>();
            fordCarBuilder.RegisterType<DICar>().As<ICar>();
            fordCarBuilder.RegisterType<FordEngine>().As<IEngine>();
            var fordCarContainer = fordCarBuilder.Build();

            ICar fordCar = fordCarContainer.Resolve<ICar>();
            fordCar.StartCar();


            Console.ReadLine();



        }
    }
}
