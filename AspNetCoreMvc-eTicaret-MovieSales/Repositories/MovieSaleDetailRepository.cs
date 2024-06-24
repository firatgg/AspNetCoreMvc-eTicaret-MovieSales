using AspNetCoreMvc_eTicaret_MovieSales.Data;
using AspNetCoreMvc_eTicaret_MovieSales.Models;

namespace AspNetCoreMvc_eTicaret_MovieSales.Repositories
{
    public class MovieSaleDetailRepository
    {
        private readonly MovieDbContext _context;
        public MovieSaleDetailRepository(MovieDbContext context)
        {
            _context = context;
        }
        public void Add(MovieSaleDetail movieSaleDetail)
        {
            _context.MovieSaleDetails.Add(movieSaleDetail);
            _context.SaveChanges();
        }

        public void Delete(MovieSaleDetail movieSaleDetail)
        {
            _context.MovieSaleDetails.Remove(movieSaleDetail);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            _context.MovieSaleDetails.Remove(Get(id));
            _context.SaveChanges();

        }

        public MovieSaleDetail Get(int id)
        {
            return _context.MovieSaleDetails.Find(id);
        }

        public List<MovieSaleDetail> GetAll()
        {
            return _context.MovieSaleDetails.ToList();
        }

        public void Update(MovieSaleDetail movieSaleDetail)
        {
            _context.MovieSaleDetails.Update(movieSaleDetail);
            _context.SaveChanges();

        }
    }
}
