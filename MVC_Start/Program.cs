﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace MVC_Start
{
  public class Program
  {
    public static void Main(string[] args)
    {
      BuildWebHost(args).Run();
            Debug.WriteLine(" Rameez updated");
            Debug.WriteLine(" Changes by Neelima");
            Debug.WriteLine(" round2");
            Debug.WriteLine(" Eric_Update");

        }

    public static IWebHost BuildWebHost(string[] args) =>
        WebHost.CreateDefaultBuilder(args)
            .UseStartup<Startup>()
            .Build();
  }
}
