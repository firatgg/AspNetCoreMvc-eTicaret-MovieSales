using AspNetCoreMvc_eTicaret_MovieSales.Interfaces;
using AspNetCoreMvc_eTicaret_MovieSales.Models;
using AspNetCoreMvc_eTicaret_MovieSales.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMvc_eTicaret_MovieSales.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieRepository _movieRepo;

        public MovieController(IMovieRepository movieRepo, IMapper mapper)
        {
            _movieRepo = movieRepo;
            _mapper = mapper;
        }

        private readonly IMapper _mapper;
        SepetDetay siparis = new SepetDetay();
        public IActionResult Index(int? id, string? search)


        {
            var sepet = HttpContext.Session.GetJson<List<SepetDetay>>("sepet") ?? new List<SepetDetay>();

            TempData["ToplamAdet"] = siparis.ToplamAdet(sepet);

            var movies = _movieRepo.GetAll();
            if(search != null)
            {
                movies = movies.Where(m => m.Name.ToLower().Contains(search.ToLower())).ToList();
            }
            if (id != null)
            {
                movies = movies.Where(m => m.GenreId == id).ToList();
            }
            return View(movies);
        }

        public IActionResult Populer()
        {
            var sepet = HttpContext.Session.GetJson<List<SepetDetay>>("sepet") ?? new List<SepetDetay>();
            TempData["ToplamAdet"] = siparis.ToplamAdet(sepet);


            var movies = _movieRepo.GetAll().Where(m => m.IsPopuler == true).ToList();
            return View(movies);
        }

        public IActionResult Local(bool isLocal)
        {
            var movies = _movieRepo.GetAll();
            if (isLocal)
            {
                var sepet = HttpContext.Session.GetJson<List<SepetDetay>>("sepet") ?? new List<SepetDetay>();
                TempData["ToplamAdet"] = siparis.ToplamAdet(sepet);


                movies = movies.Where(m => m.IsLocal == true).ToList();
                 ViewBag.Local = "Yerli";
            }
            else 
            {
                var sepet = HttpContext.Session.GetJson<List<SepetDetay>>("sepet") ?? new List<SepetDetay>();
                TempData["ToplamAdet"] = siparis.ToplamAdet(sepet);
                movies = movies.Where(m => m.IsLocal == false).ToList();
                 ViewBag.Local = "Yabancı";
            }


            return View(movies);
        }
        public IActionResult Details(int id) 
        {
            var sepet = HttpContext.Session.GetJson<List<SepetDetay>>("sepet") ?? new List<SepetDetay>();
            TempData["ToplamAdet"] = siparis.ToplamAdet(sepet);


            var movies = _movieRepo.Get(id);
            return View(movies);
        }
    }
}
