using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeekProject.Models
{
    public class Book
    {

        public int Id { get; set; }

       
        public string BookName { get; set; }
        public double ISBN { get; set; }
        public string AuthorName { get; set; }

        public string Publisher { get; set; }

        public string BookType { get; set; }
        
        public string Description  { get; set; }

        public int Price { get; set; }
       
        public DateTime PublishedDate { get; set; }

        //Navigation Properties
        public Category Category { get; set; }//This is not a column

        //ForeignKey

        public int CategoryId { get; set; }

    }
}