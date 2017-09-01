using System;

namespace StoreForVideos.Model
{
    public class StoreViewModel
    {   
        public int Id {get; set;} //primary key
        public int RentalID { get; set; }
        public int MovieID { get; set; }
        public int CustomerID { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime ReturnDate { get; set; }

        public StoreViewModel()
        {
        }   
          public StoreViewModel(RentalRecordModel rentalRecord)
        {
            this.Id = Id; 
            this.RentalID = rentalRecord.RentalID; 
            this.MovieID = rentalRecord.MovieID;
            this.CustomerID = rentalRecord.CustomerID;
            this.DueDate = rentalRecord.DueDate; 
            this.RentalDate = rentalRecord.RentalDate;
            this.DueDate = rentalRecord.DueDate;
            this.RentalDate = rentalRecord.RentalDate;     
        }   
        }
    }
