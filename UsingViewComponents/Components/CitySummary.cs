using System;
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

        //public string Invoke()
        //{
        //    return $"{repository.Cities.Count()} cities, "
        //        + $"{repository.Cities.Sum(c => c.Population)} people";
        //}

        public IViewComponentResult Invoke()
        {
            return View(new CityViewModel
            {
                Cities = repository.Cities.Count(),
                Population = repository.Cities.Sum(c => c.Population)
            });
            
        }

        //public IViewComponentResult Invoke(bool showList)
        //{
        //    if (showList)
        //    {
        //        return View("CityList", repository.Cities);
        //    }
        //    else
        //    {
        //        return View(new CityViewModel
        //        {
        //            Cities = repository.Cities.Count(),
        //            Population = repository.Cities.Sum(c => c.Population)
        //        });
        //    }
        //}
    }
}
