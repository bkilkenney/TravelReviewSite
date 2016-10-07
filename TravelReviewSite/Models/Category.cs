using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;




namespace TravelReviewSite.Models
{
    public class Category
    {
        [Key]           //This is the primary key of the Category table and the foreign key of the Reviews table
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}