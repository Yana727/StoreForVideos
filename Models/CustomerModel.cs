using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace StoreForVideos.Models
{
    public class CustomerModel
    {  
        public int Id { get; set; } 
        public string  CustomerName { get; set; }
        public int CustomerPhone { get; set; }
    }
}
