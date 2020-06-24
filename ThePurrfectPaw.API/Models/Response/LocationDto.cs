﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThePurrfectPaw.API.Models.Response
{
    public class LocationDto
    {
        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string StateAbbreviation { get; set; }

        public string Zipcode { get; set; }

        public string Country { get; set; }
    }
}
