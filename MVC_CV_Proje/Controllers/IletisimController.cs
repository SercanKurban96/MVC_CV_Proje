using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_CV_Proje.Models.Entity;
using MVC_CV_Proje.Repositories;

namespace MVC_CV_Proje.Controllers
{
    public class IletisimController : Controller
    {
        // GET: Iletisim
        GenericRepository<TblIletisim> repo = new GenericRepository<TblIletisim>();
        public ActionResult Index()
        {
            var mesajlar = repo.List();
            return View(mesajlar);
        }
    }
}