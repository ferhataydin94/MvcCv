﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;
namespace MvcCv.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        
        // GET: Default
        DbCvEntities1 db = new DbCvEntities1();   
        public ActionResult Index()
        {
            var degerler = db.TblHakkimda.ToList();
            return View(degerler);
        }

        public PartialViewResult SosyalMedya()
        {
            var sosyalMedya = db.TblSosyalMedya.Where(x=>x.Durum==true).ToList();
            return PartialView(sosyalMedya);
        }
        public PartialViewResult Deneyim()
        {
            var deneyimler = db.TblDeneyimlerim.ToList();
            return PartialView(deneyimler);
        }

        public PartialViewResult Egitimlerim()
        {
            var egitimlerim = db.TblEgitimlerim.ToList();
            return PartialView(egitimlerim);
        }

        public PartialViewResult Yeteneklerim()
        {
            var yeteneklerim = db.TblYeteneklerim.ToList();
            return PartialView(yeteneklerim);
        }

        public PartialViewResult Hobilerim()
        {
            var hobilerim = db.TblHobilerim.ToList();
            return PartialView(hobilerim);
        }

        public PartialViewResult Sertifikalarim()
        {
            var sertifakalarim = db.TblSertifikalarim.ToList();
            return PartialView(sertifakalarim);
        }
        [HttpGet]
        public PartialViewResult Iletisim()
        {
            
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult Iletisim(TblIletisim t)
        {
            t.Tarih = DateTime.Now;
            db.TblIletisim.Add(t);
           
            db.SaveChanges();
            return PartialView();
        }

    }
}