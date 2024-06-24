using AspNetCoreMvc_eTicaret_MovieSales.Models;

namespace AspNetCoreMvc_eTicaret_MovieSales.Interfaces
{
    public interface IMovieRepository
    {
        public List<Movie> GetAll();
        public Movie Get(int Id);
        public void Add(Movie movie);
        public void Update(Movie movie);
        public void Delete(int ID);
        public void Delete(Movie movie);
    }
}


