﻿using Microsoft.AspNetCore.Mvc;
using TempManager.Models;
using System;
using System.Linq;



namespace TempManager.Controllers
{
    public class ValidationController : Controller{
        private TempManagerContext data { get; set; }
        public ValidationController(TempManagerContext ctx){
            data = ctx;
        }
        public JsonResult CheckDate(string date){
            DateTime dt = DateTime.Parse(date);
            Temp temp = data.Temps.FirstOrDefault(t => t.Date == dt);

            if (temp == null)
                return Json(true);
            else
                return Json($"Error! The date '{date}' is already in the database.");
        }
    }
}
