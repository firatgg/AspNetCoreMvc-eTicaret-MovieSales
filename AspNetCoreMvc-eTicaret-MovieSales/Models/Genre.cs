﻿using System.Reflection.Metadata.Ecma335;

namespace AspNetCoreMvc_eTicaret_MovieSales.Models
{
    public class Genre //Film Türü
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //Navigation Property (Relations)

        public List<Movie> Movies { get; set; }
    }
}
