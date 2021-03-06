﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UsingViewComponents.Models;

namespace UsingViewComponents.Components
{
    public class CitySummary : ViewComponent
    {
        private ICityRepository repository;

        public CitySummary(ICityRepository repo)
        {
            repository = repo;
        }

        // from page 699
        //public string Invoke()
        //{
        //    return $"{repository.Cities.Count()} cities, "
        //        + $"{repository.Cities.Sum(c => c.Population)} people";
        //}

        // from page 704
        //public IViewComponentResult Invoke()
        //{
        //    return View(new CityViewModel
        //    {
        //        Cities = repository.Cities.Count(),
        //        Population = repository.Cities.Sum(c => c.Population)
        //    });

        //}

        // from page 706
        //public IViewComponentResult Invoke()
        //{
        //    return Content("This is a <h3><i>string</i></h3>");
        //}

        // from page 709
        //public IViewComponentResult Invoke()
        //{
        //    string target = RouteData.Values["id"] as string;
        //    var cities = repository.Cities
        //        .Where(city => target == null ||
        //            string.Compare(city.Country, target, true) == 0);

        //    return View(new CityViewModel
        //    {
        //        Cities = cities.Count(),
        //        Population = cities.Sum(c => c.Population)
        //    });
        //}

        // from page 711
        public IViewComponentResult Invoke(bool showList)
        {
            if (showList)
            {
                return View("CityList", repository.Cities);
            }
            else
            {
                return View(new CityViewModel
                {
                    Cities = repository.Cities.Count(),
                    Population = repository.Cities.Sum(c => c.Population)
                });
            }
        }

    }
}
