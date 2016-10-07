using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelReviewSite.Models
{
    public class Review
    {
        [Key] //Primary Key of the Reviews table

        public int ID { get; set; }
        public string ReviewTitle { get; set; }
        public string ReviewContent { get; set; }
        public DateTime PublishDate { get; set; }
        

        [ForeignKey("Category")]  //CategoryID will be the FK of this table and the PK of Categories table
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }



    }
}