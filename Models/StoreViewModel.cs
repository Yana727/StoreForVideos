using System;

namespace StoreForVideos.Model // should I have created this via (33:33)Select? 
{
    public class StoreViewModel
    {   
        public DateTime RentalDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime ReturnDate { get; set; }

        public StoreViewModel()
        {
        }   
          public StoreViewModel(RentalRecordModel rentalRecord)
        {
            this.DueDate = rentalRecord.DueDate; 
            this.RentalDate = rentalRecord.RentalDate;
            this.DueDate = rentalRecord.DueDate;
            this.RentalDate = rentalRecord.RentalDate;     
        }   
        }
    }
