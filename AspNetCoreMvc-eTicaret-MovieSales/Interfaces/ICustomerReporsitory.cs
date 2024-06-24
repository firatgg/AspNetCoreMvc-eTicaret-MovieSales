using AspNetCoreMvc_eTicaret_MovieSales.Models;

namespace AspNetCoreMvc_eTicaret_MovieSales.Interfaces
{
    public interface ICustomerReporsitory
    {
        public List<Customer> GetAll();
        public Customer Get(int id);
        public void Add(Customer customer);
        public void Update(Customer customer);
        public void Delete(int id);
        public void Delete(Customer customer);
    }
}
