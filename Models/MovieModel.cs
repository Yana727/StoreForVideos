using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StoreForVideos.Models;


namespace StoreForVideos.Models
{
    public class MovieModel
    {   
        [Key]
        public int Id { get; set; }   
        public string MovieName { get; set; }   
        public string MovieDescription { get; set; } 
        public int GenreID { get; set; }
        public bool CheckedOut { get; set; }
    }
}
