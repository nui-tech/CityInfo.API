﻿using CityInfo.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore(); // auto property init syntax
        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {

                new CityDto()
                {
                    Id =  1,
                    Name = "New York City",
                    Description = "The one with that big park.",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Central Park",
                            Description = "The mose visited urban park in the United States."
                        },
                        new PointOfInterestDto
                        {
                                Id = 2,
                            Name = "Empire State Building",
                            Description = "The mose visited urban park in the United States."
                        }
                    }
                },
                new CityDto()
                {
                    Id =  2,
                    Name = "BKK",
                    Description = "The one with that big park.",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Central Park",
                            Description = "The mose visited urban park in the United States."
                        },
                        new PointOfInterestDto
                        {
                                Id = 2,
                            Name = "Empire State Building",
                            Description = "The mose visited urban park in the United States."
                        }
                    }
                },
                new CityDto()
                {
                    Id =  3,
                    Name = "CHCH",
                    Description = "The one with that big park.",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Central Park",
                            Description = "The mose visited urban park in the United States."
                        },
                        new PointOfInterestDto
                        {
                                Id = 2,
                            Name = "Empire State Building",
                            Description = "The mose visited urban park in the United States."
                        }
                    }
                }


            };
        }
    }
}
