using System.Diagnostics.Contracts;

namespace AspNetCoreMvc_eTicaret_MovieSales.Models
{
    public class MovieSaleDetail   //film satış detayları
    {
        public int Id { get; set; }
        public int MovieSaleId { get; set; }
        public int MovieId { get; set; }
        public int Number { get; set; }
        public decimal UnitPrice { get; set; }

        //Navigation Property (Relations)
        public MovieSale MovieSale { get; set; }
        public Movie Movie { get; set; }

    }
}
