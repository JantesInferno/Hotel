using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
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

        public static void CreateBooking(Booking booking, Room room)
        {
            int rate = (int)room.RoomType.DailyRate;
            Invoice invoice = new Invoice();
            invoice.TotalCost = (decimal)(booking.EndDate - booking.StartDate).TotalDays * rate + (booking.ExtraBeds * 200);
            invoice.DueDate = booking.EndDate.AddDays(10);
            int invoiceID = InvoiceRepo.CreateInvoice(invoice);

            booking.InvoiceID = invoiceID;

            _db.Bookings.Add(booking);
            _db.SaveChanges();
        }

        public static List<Booking> GetAllBookings() 
        {
            return _db.Bookings.Include("Customer").Include("Room").Include("Invoice").ToList();
        }

        public static List<Booking> GetBookingsByCustomerID(int customerID)
        {
            return _db.Bookings.Include("Customer").Include("Rooms").Include("Invoice").Where(x => x.CustomerID == customerID).ToList();
        }

        public static List<Booking> GetBookingsByDate(DateTime[] dates) 
        {
            List<Booking> list = new List<Booking>();
            
            foreach (DateTime date in dates)
            {
                Booking booking = _db.Bookings.Include("Customer").Include("Room").Include("Invoice").SingleOrDefault(x => x.StartDate <= date && x.EndDate >= date);
                if (booking != null && !list.Contains(booking))
                    list.Add(booking);
            }

            return list;
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
