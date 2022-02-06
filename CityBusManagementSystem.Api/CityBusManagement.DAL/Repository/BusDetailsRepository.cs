﻿using CityBusManagement.DAL.Data;
using CityBusManagement.Entity.Models;
using CityBusManangement.DAL.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CityBusManagement.DAL.Repository
{
    public class BusDetailsRepository : IBusDetailsRepository
    {
        RouteDetailsDbContext _busDetailsDbContext;
        public BusDetailsRepository(RouteDetailsDbContext busDetailsDbContext)
        {
            _busDetailsDbContext = busDetailsDbContext;
        }
        public void AddBusDetails(BusDetails busdetails)
        {
            _busDetailsDbContext.busdetails.Add(busdetails);
            _busDetailsDbContext.SaveChanges();

        }
        public void DeleteBusDetails(int busNo)
        {
            var busdetails = _busDetailsDbContext.busdetails.Find(busNo);
            _busDetailsDbContext.busdetails.Remove(busdetails);
            _busDetailsDbContext.SaveChanges();
        }

        public IEnumerable<BusDetails> GetBusDetails()
        {
            return _busDetailsDbContext.busdetails.ToList();
        }

        public BusDetails GetBusNo(int busNo)
        {
            return _busDetailsDbContext.busdetails.Find(busNo);
        }

        public void UpdateBusDetails(BusDetails busdetails)
        {
            _busDetailsDbContext.Entry(busdetails).State = EntityState.Modified;
            _busDetailsDbContext.SaveChanges();
        }
    }
}
