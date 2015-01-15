using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeatherStationCode;

namespace WeatherStation.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            WeatherData weatherdata = new WeatherData();
            CurrentCoditionsDisplay currentDisplay = new CurrentCoditionsDisplay(weatherdata);
            //StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherdata);

            //similate new weather measurements
            weatherdata.setMeasurements(80, 65, 30);
            weatherdata.setMeasurements(82, 70, 28); 
            weatherdata.setMeasurements(78, 90, 26);

            return View(currentDisplay);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}