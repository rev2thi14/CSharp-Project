﻿using CityBusManagement.Entity.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CityBusManagementSystem.UI.Controllers
{
    public class TripController : Controller
    {
        private IConfiguration _configuration;
        public TripController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Trip> trip = null;
            using (HttpClient client = new HttpClient())
            {
                string endPoint = _configuration["WebApiBaseUrl"] + "Trip/GetTrip";
                using (var response = await client.GetAsync(endPoint))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        trip = JsonConvert.DeserializeObject<IEnumerable<Trip>>(result);
                    }
                }
            }
            return View(trip);
        }
        public IActionResult TripEntry()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> TripEntry(Trip trip)
        {
            ViewBag.status = "";
            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(trip), Encoding.UTF8, "application/json");
                string endPoint = _configuration["WebApiBaseUrl"] + "Trip/AddTrip";
                using (var response = await client.PostAsync(endPoint, content))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        ViewBag.status = "Ok";
                        ViewBag.message = "Trip details saved successfully!";
                    }
                    else
                    {
                        ViewBag.status = "Error";
                        ViewBag.message = "Wrong entries!";
                    }
                }
            }
            return View();
        }
    }
}
