﻿using AspNetCoreMvc_eTicaret_MovieSales.Models;
using AspNetCoreMvc_eTicaret_MovieSales.Repositories;

namespace AspNetCoreMvc_eTicaret_MovieSales.Interfaces
{
    public interface ICustomerRepository 
    {
        public List<Customer> GetAll();
        public Customer Get(int id);
        public void Add(Customer customer);
        public void Update(Customer customer);
        public void Delete(int id);
        public void Delete(Customer customer);
    }
}
