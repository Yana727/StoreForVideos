using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StoreForVideos.Models;


namespace StoreForVideos
{
    public class RentalRecordModel
    {   
        [Key]
        public int Id {get; set;} //primary key
        public int RentalID { get; set; } // change and migrate
        public int MovieID { get; set; }
        public int CustomerID { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public void Rented()
        {
            
        }
    }
}