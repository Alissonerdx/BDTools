using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BDTools.Api.Data;
using BDTools.Api.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BDTools.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarketController : ControllerBase
    {
        private readonly BDToolsContext _db;

        public MarketController(BDToolsContext db)
        {
            _db = db;
        }

        [HttpGet]
        [Route("allitems")]
        public ActionResult<List<Item>> GetAllItems()
        {
            var items = _db.Items.ToList();
            if(items == null)
            {
                return NotFound();
            }
            return items;
        }

        [HttpGet]
        [Route("allclasses")]
        public ActionResult<List<Classe>> GetAllClasses()
        {
            var classes = _db.Classes.ToList();
            if(classes == null)
            {
                return NotFound();
            }
            return classes;
        }


    }
}