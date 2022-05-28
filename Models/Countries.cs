﻿using System;
namespace JAFJ_Maui.Models
{
	public class Countries
	{
        public string Country { get; set; }
        public CountryInfo CountryInfo { get; set; }
        public double Updated { get; set; }
        public int Cases { get; set; }
        public int TodayCases { get; set; }
        public int Deaths { get; set; }
        public int TodayDeaths { get; set; }
        public int Recovered { get; set; }
        public string Continent { get; set; }
    }
}

