﻿using AspNetCoreMvc_eTicaret_MovieSales.Data;
using AspNetCoreMvc_eTicaret_MovieSales.Interfaces;
using AspNetCoreMvc_eTicaret_MovieSales.Models;

namespace AspNetCoreMvc_eTicaret_MovieSales.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MovieDbContext _context;
        public MovieRepository(MovieDbContext context)
        {
            _context = context;
        }
        public void Add(Movie movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
        }

        public void Delete(Movie movie)
        {
            _context.Movies.Remove(movie);
            _context.SaveChanges();
        }

        public void Delete(int ID)
        {
            _context.Movies.Remove(Get(ID));
            _context.SaveChanges();

        }

        public Movie Get(int ID)
        {
            return _context.Movies.Find(ID);
        }

        public List<Movie> GetAll()
        {
            return _context.Movies.ToList();
        }
            
        public void Update(Movie movie)
        {
            _context.Movies.Update(movie);
            _context.SaveChanges();

        }
    }
}
