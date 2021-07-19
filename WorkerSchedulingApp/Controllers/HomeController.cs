using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using WorkerSchedulingApp.Models;
//home controller
namespace WorkerSchedulingApp.Controllers
{

    public class HomeController : Controller
    {
        private IHttpContextAccessor http { get; set; }
        private IWorkScheduleUnitOfWork data { get; set; }

        public HomeController(IWorkScheduleUnitOfWork unit, IHttpContextAccessor ctx)
        {
            data = unit;
            http = ctx;
        }

        public ViewResult Index(int id)
        {
            //if passed to method, stored in session
            if (id > 0)
            {
                http.HttpContext.Session.SetInt32("dayid", id);
            }

            //option for day query
            var dayOptions = new QueryOptions<Day>
            {
                OrderBy = d => d.DayId
            };

            // options position query
            var positionOptions = new QueryOptions<Position>
            {
                Includes = "Worker, Day"
            };
            //order by day, or else filter by day and order by time
            if (id == 0)
            {
                positionOptions.OrderBy = p => p.DayId;
            }
            else
            {
                positionOptions.Where = p => p.DayId == id;
                positionOptions.OrderBy = p => p.MilitaryTime;
            }

            // execute queries
            ViewBag.Days = data.Days.List(dayOptions);
            return View(data.Positions.List(positionOptions));
        }
    }
}
