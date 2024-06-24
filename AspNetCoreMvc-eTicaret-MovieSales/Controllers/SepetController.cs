﻿using AspNetCoreMvc_eTicaret_MovieSales.Interfaces;
using AspNetCoreMvc_eTicaret_MovieSales.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMvc_eTicaret_MovieSales.Controllers
{
    public class SepetController : Controller
    {
        private readonly IMovieRepository _movieRepo;

        public SepetController(IMovieRepository movieRepo)
        {
            _movieRepo = movieRepo;
        }
        List<SepetDetay> sepet;
        SepetDetay siparis = new SepetDetay();

        public IActionResult Index()
        {
            sepet = SepetAl();
            TempData["ToplamAdet"] = siparis.ToplamAdet(sepet);
            TempData["ToplamTutar"] = siparis.ToplamTutar(sepet);

            return View(sepet);
        }

        public IActionResult Ekle(int Id, int Adet)
        {
            
            var movie = _movieRepo.Get(Id);
            sepet = SepetAl();
            SepetDetay siparis = new SepetDetay();
            siparis.MovieId = movie.Id;
            siparis.MovieName = movie.Name;
            siparis.MovieQuantity = Adet;
            siparis.MoviePrice = movie.Price;
            sepet = siparis.SepeteEkle(sepet, siparis);
            SepetKaydet(sepet);
            return RedirectToAction("Index");
        }


        public List<SepetDetay> SepetAl() 
        
        {

            var sepet = HttpContext.Session.GetJson<List<SepetDetay>>("sepet") ?? new List<SepetDetay>();
            return sepet;
        }

        public void SepetKaydet(List<SepetDetay> sepet)

        {
            HttpContext.Session.SetJson("sepet", sepet);


        }
    }
}
