using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Repository
{
    public static class BookingRepo
    {
        private static readonly DataHandler _db;

        static BookingRepo()
        {
            _db = new DataHandler();
        }

        public static void CreateBooking(Booking booking)
        {
            _db.Bookings.Add(booking);
            _db.SaveChanges();
        }

        public static List<Booking> GetAllBookings() 
        {
            return _db.Bookings.Include("Customer").Include("Room").Include("Invoice").ToList();
        }

        public static List<Booking> GetBookingsByCustomerID(int customerID)
        {
            return _db.Bookings.Include("Customer").Include("Room").Include("Invoice").Where(x => x.CustomerID == customerID).ToList();
        }

        public static List<Booking> GetBookingsByDate(DateTime date) 
        { 
            return _db.Bookings.Include("Customer").Include("Room").Include("Invoice").Where(x => x.StartDate <= date && x.EndDate >= date).ToList();
        }

        public static List<Booking> GetBookingsByCustomerSearch(string searchTerm)
        {
            return _db.Bookings.Include("Customer").Include("Room").Include("Invoice").Where(x => x.Customer.Name.Contains(searchTerm)).ToList();
        }

        public static Booking GetBookingByID(int id)
        {
            return _db.Bookings.Include("Customer").Include("Room").Include("Invoice").SingleOrDefault(x => x.BookingID == id);
        }

        public static void UpdateBooking(Booking newBooking)
        {
            Booking oldBooking = GetBookingByID(newBooking.BookingID);
            _db.Entry(oldBooking).CurrentValues.SetValues(newBooking);
            _db.SaveChanges();
        }

        public static void DeleteBooking(Booking booking)
        {
            _db.Bookings.Remove(booking);
            _db.SaveChanges();
        }
    }
}
