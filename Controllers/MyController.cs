using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using demo2.Models;

namespace demo2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyController : Controller
    {
        KSContext db;
        public MyController(KSContext _db)
        {
            this.db = _db;
        }

        [HttpGet("/api/spots")]
        public IEnumerable<Info> Get()
        {
            //取10筆資料
            return this.db.ScenicSpots.Take(10);
        }

        //取單筆資料
        [HttpGet("/api/spots/{id}")]
        public Info GetById(string id)
        {
            return this.db.ScenicSpots.Find(id);
        }

        // [HttpGet ("/importdb")]
        // public IActionResult ImportDB()
        // {
        //     All data = All.FromJson(System.IO.File.ReadAllText("data.json"));
        //     // TODO: Your code here
        //    // return Json(data);
        //    foreach(var item in data.Data.XmlHead.Infos.Info) {
        //        this.db.Add(item);
        //    }
        //    this.db.SaveChanges();
        //    return Content("OK");
        // }
        
    }
}