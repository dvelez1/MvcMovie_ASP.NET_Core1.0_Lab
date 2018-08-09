using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Movie
    {

        public int ID { get; set; }
        public string Title { get; set; }

        [Display(Name="Realease Date")]
        [DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}",ApplyFormatInEditMode =true)] //Other Date Format
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }

    }

    //Create a Container Object Movies. DVG 01-13-18
    public class MovieDBContext : DbContext
    {
        public DbSet<Movie> Movies {get;set;}
    }

}