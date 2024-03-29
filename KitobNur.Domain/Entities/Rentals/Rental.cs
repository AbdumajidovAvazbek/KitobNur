using KitobNur.Domain.Comon;
using KitobNur.Domain.Users;
using System;

namespace KitobNur.Domain.Library
{
    public class Rental : Auditable<long>
    {
        public int RentalID { get; set; } // Primary Key

        public long UserId { get; set; } // Foreign Key to Readers table
        public User User { get; set; } // Navigation property

        public long BookID { get; set; } // Foreign Key to Books table
        public Book Book { get; set; } // Navigation property

    }
}
