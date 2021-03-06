﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_Start.Models;

namespace MVC_Start.Controllers
{
  public class HomeController : Controller
  {
        public IActionResult Index(int id)
    {
            GuestContact contact = new GuestContact();
            contact.Name = "Rameez";
            contact.id = id;
           // contact.testText = d.TryGetValue("Name", out Name);
       // contact.Phone = "9048640208";
       // contact.Email = "rameezbadri@usf.edu";
            return View(contact);
    }
    [HttpPost]
    public IActionResult Index(GuestContact contact)
        {
            char[] arr = contact.Name.ToCharArray();
            Array.Reverse(arr);
            contact.Name = new string(arr);
            return View(contact);
        }

public IActionResult IndexWithLayout()
    {
      return View();
    }

    /// <summary>
    /// Replicate the chart example in the JavaScript presentation
    /// 
    /// Typically LINQ and SQL return data as collections.
    /// Hence we start the example by creating collections representing the x-axis labels and the y-axis values
    /// However, chart.js expects data as a string, not as a collection.
    ///   Hence we join the elements in the collections into strings in the view model
    /// </summary>
    /// <returns>View that will display the chart</returns>
    public ViewResult DemoChart()
    {
      string[] ChartLabels = new string[] { "Africa", "Asia", "Europe", "Latin America", "North America" };
      int[] ChartData = new int[] { 2478, 5267, 734, 784, 433 };

      ChartModel Model = new ChartModel
      {
        ChartType = "bar",
        Labels = String.Join(",", ChartLabels.Select(d => "'" + d + "'")),
        Data = String.Join(",", ChartData.Select(d => d)),
        Title = "Predicted world population (millions) in 2050"
      };

      return View(Model);
    }

        public IActionResult InClassHtmlLinks()
        {
            GuestContact contact = new GuestContact();
            contact.Name = "Rameez HTML";
            contact.Phone = "4544545";
            contact.Email = "rb@usf.edu";
            return View(contact);
        }
       
        [HttpPost]
        public IActionResult InClassHtmlLinks(GuestContact contact)
        {
            char[] arr = contact.Name.ToCharArray();
            Array.Reverse(arr);
            contact.Name = new string(arr);
            return View(contact);
        }
    }
}