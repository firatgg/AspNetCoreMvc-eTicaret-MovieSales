using Microsoft.CodeAnalysis;

namespace AspNetCoreMvc_eTicaret_MovieSales.Models
{
    public class SepetDetay
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }

        public int MovieQuantity { get; set; }
        public decimal MoviePrice { get; set; }
        
        public List<SepetDetay> SepeteEkle(List<SepetDetay> sepet, SepetDetay siparis)
        {
            if(sepet.Any(s => s.MovieId == siparis.MovieId)) 
            
            { 
                //sipariş olarak gelen üründen önceden sepette var, o zaman miktarını arttırıyoruz.
                foreach(var item in sepet)
                {
                    //Aynı ürünü bulup, miktarını sipariş miktarı kadar arttıyoruz.
                    if (item.MovieId == siparis.MovieId)
                        item.MovieQuantity += siparis.MovieQuantity;
                }   
            }
            else 
            {
                //yeni ürün ilk defa sepeye atılacak
                sepet.Add(siparis);
            }
            return sepet;
        }

        public List<SepetDetay> SepettenSil(List<SepetDetay> sepet, int id)
        {

            sepet.RemoveAll(s => s.MovieId == id);
            return sepet;
        }
        public int ToplamAdet(List<SepetDetay> sepet)
        
        {
            var toplamAdet = sepet.Sum(s => s.MovieQuantity);
            return toplamAdet;
        }
        public decimal ToplamTutar(List<SepetDetay> sepet)

        {
            var toplamTutar = sepet.Sum(s => s.MovieQuantity * s.MoviePrice);
            return toplamTutar;
        }
    }
}
