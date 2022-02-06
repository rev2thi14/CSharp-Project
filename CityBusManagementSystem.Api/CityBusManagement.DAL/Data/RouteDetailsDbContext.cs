﻿using CityBusManagement.Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CityBusManagement.DAL.Data
{
    public class RouteDetailsDbContext:DbContext
    {
        public RouteDetailsDbContext(DbContextOptions<RouteDetailsDbContext> options) : base(options)
        {
        }
        public DbSet<RouteDetails> routedetails { get; set; }
        public DbSet<BusDetails> busdetails { get; set; }
        public DbSet<BusStop> busstop { get; set; }
        public DbSet<Trip> trip { get; set; }
        public DbSet<Employee> employee { get; set; }

    }
}
