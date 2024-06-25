using AspNetCoreMvc_eTicaret_MovieSales.Data;
using AspNetCoreMvc_eTicaret_MovieSales.Interfaces;
using AspNetCoreMvc_eTicaret_MovieSales.Models;
using AspNetCoreMvc_eTicaret_MovieSales.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMvc_eTicaret_MovieSales.Controllers
{
    public class CustomerController : Controller
    {

        private readonly ICustomerRepository _customerRepo;
        private readonly IMapper _mapper;
        public CustomerController(ICustomerRepository customerRepo, IMapper mapper)
        {
            _customerRepo = customerRepo;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(CustomerLoginViewModel model) 
        {
            if (ModelState.IsValid) 
            {
                var customer = _customerRepo.GetAll().FirstOrDefault(c => c.Email == model.Email &&  c.Password == model.Password);
                if (customer == null) 
                {
                    ModelState.AddModelError(string.Empty, "Hatalı email veya şifre girişi");
                }
                else
                {
                    HttpContext.Session.SetJson("user", customer);
                    return RedirectToAction("ConfirmAddress");
                }
            }
            return View(model);
        }
        public IActionResult ConfirmAddress()
        {

            //Dışarıdan gelebilecek ataklara karşı öncelikle kullanıcıyı session'dan çekp kontrol ediyoruz.

            var customer = HttpContext.Session.GetJson<Customer>("user");
            if (customer == null)
            {
                return RedirectToAction("Login");
            }
            
            return View(_mapper.Map<CustomerViewModel>(customer));
        }

        [HttpPost]
        public IActionResult ConfirmAddress(CustomerViewModel model)
        {
            _customerRepo.Update(_mapper.Map<Customer>(model));
            return RedirectToAction("ConfirmPayment");
        }


        public IActionResult ConfirmPayment() 

        {
            var customer = HttpContext.Session.GetJson<Customer>("user");
            if (customer == null)
            {
                return RedirectToAction("Login");
            }
            //sepet bilgileri session'dan çekilecek.
            var sepet = HttpContext.Session.GetJson<List<SepetDetay>>("sepet");
            SepetDetay sd = new SepetDetay();
            int toplamAdet = sd.ToplamAdet(sepet);
            decimal toplamTutar = sd.ToplamTutar(sepet);

            MovieSaleViewModel movieSaleViewModel = new MovieSaleViewModel();
            movieSaleViewModel.CustomerId = customer.Id;
            movieSaleViewModel.Date = DateTime.Now;
            movieSaleViewModel.TotalQuantity = toplamAdet;
            movieSaleViewModel.TotalPrice = toplamTutar;
            
            CustomerFaturaViewModel customerFaturaViewModel = new CustomerFaturaViewModel()
            {
                customerViewModel = _mapper.Map<CustomerViewModel>(customer),
                satisViewModel = movieSaleViewModel,
                sepetDetayListesi = sepet

            };


            return View(customerFaturaViewModel);

        }
        [HttpPost]
        public IActionResult ConfirmPayment(CustomerFaturaViewModel model)
        {
            return View();
        }

        public IActionResult Create() 
        {
            return View();
        }
    }
}
