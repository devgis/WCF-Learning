﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using Artech.WcfServices.Service.Interface;
using System.Runtime.Remoting;
using System.Diagnostics;

namespace Artech.WcfServices.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ChannelFactory<ICalculator> channelFactory = new ChannelFactory<ICalculator>("calculatorservice"))
            {
                ICalculator serviceProxy = channelFactory.CreateChannel();
                serviceProxy.Add(1, 2);
                serviceProxy.Add(1, 2);
            }
            Console.Read();
        }
    }
}