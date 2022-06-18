using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnlineStore.Models;

namespace OnlineStore.Controllers
{
    [AllowAnonymous]
    public class StoreController : Controller
    {
        //
        // GET: /Store/
        public string Index()
        {
            return "Hello from Store.Index()";
        }
        //
        // GET: /Store/Browse
        public string Browse(string category)
        {
            string message = HttpUtility.HtmlEncode("Store.Browse, category = "
                                                    + category);

            return message;
        }
        //
        // GET: /Store/Details
        public ActionResult Details(int id)
        {
            var album = new Brand { BrandName = "Brand " + id };
            return View(album);
        }
    }


}
