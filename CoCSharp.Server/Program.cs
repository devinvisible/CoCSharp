﻿using System;
using System.Net;
using System.Threading;

namespace CoCSharp.Server
{
    public class Program
    {
        public static CoCServer Server { get; set; }

        public static void Main(string[] args)
        {
            Console.Title = "CoC# Server";

            Server = new CoCServer();
            Server.Start(new IPEndPoint(IPAddress.Any, 9339));
            Console.WriteLine("CoC# Server listening on port *:9339");
            Thread.Sleep(-1);
        }
    }
}
