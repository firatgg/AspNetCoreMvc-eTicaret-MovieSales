﻿namespace AspNetCoreMvc_eTicaret_MovieSales.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public List<MovieSale> MovieSales { get; set; }
    }
}
