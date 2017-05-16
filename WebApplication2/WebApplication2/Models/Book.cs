using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication2.Models
{
        public class Book
        {            
            public int Id { get; set; }            
            public string Name { get; set; }            
            public string Author { get; set; }
            public string Description { get; set; }
            public string Genre { get; set; }
            public string PictureUrl { get; set; }
    }    
}