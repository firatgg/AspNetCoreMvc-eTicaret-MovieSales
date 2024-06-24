using AspNetCoreMvc_eTicaret_MovieSales.Models;

namespace AspNetCoreMvc_eTicaret_MovieSales.Interfaces
{
    public interface IMovieSaleDetailRepository
    {
        public List<MovieSaleDetail> GetAll();
        public MovieSaleDetail Get(int id);
        public void Add(MovieSaleDetail movieSaleDetail);
        public void Update(MovieSaleDetail movieSaleDetail);
        public void Delete(int id);
        public void Delete(MovieSaleDetail movieSaleDetail);

    }
}
