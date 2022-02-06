﻿using CityBusManagement.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CityBusManagement.DAL.Repository
{
    public interface ITripRepository
    {
        public void AddTripDetails(Trip tripdetails);
        public void UpdateTripDetails(Trip tripdetails);
        public void DeleteTripDetails(int tripNo);
        public Trip GetTripNo(int tripNo);
        IEnumerable<Trip> GetTripDetails();
    }
}
