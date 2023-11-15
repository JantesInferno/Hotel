using System;
using System.Collections.Generic;
using System.Linq;

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
            invoice.TotalCost = (decimal)(booking.EndDate.Date - booking.StartDate.Date).TotalDays * rate + (booking.ExtraBeds * 200);
            if ((booking.EndDate.Date - DateTime.Today.Date).TotalDays >= 10)
                invoice.DueDate = booking.EndDate.AddDays(-10);
            else
                invoice.DueDate = booking.StartDate.Date;

            int invoiceID = InvoiceRepo.CreateInvoice(invoice);

            booking.InvoiceID = invoiceID;

            _db.Bookings.Add(booking);
            _db.SaveChanges();
        }

        public static List<Booking> CheckDueDates()
        {
            List<Booking> bookings = GetAllBookings();
            List<Booking> dues = new List<Booking>();   
            
            foreach (Booking booking in bookings)
            {
                if (booking.Invoice.DueDate != null)
                {
                    if (booking.Invoice.DueDate == DateTime.Now.Date)
                    {
                        dues.Add(booking);
                    }
                }
            }

            return dues;
        }

        public static List<Booking> GetAllBookings() 
        {
            return _db.Bookings.ToList();
        }

        public static List<Booking> GetBookingsByCustomerID(int customerID)
        {
            return _db.Bookings.Where(x => x.CustomerID == customerID).ToList();
        }

        public static List<Booking> GetBookingsByDate(DateTime[] dates) 
        {
            List<Booking> list = new List<Booking>();
            
            foreach (DateTime date in dates)
            {
                List<Booking> bookings = _db.Bookings.Include("Invoice").Include("Room").Include("Customer").Where(x => x.StartDate <= date && x.EndDate >= date).ToList();
                foreach (Booking booking in bookings)
                {
                    if (booking != null && !list.Contains(booking))
                        list.Add(booking);
                }
            }

            return list;
        }

        public static List<Booking> GetBookingsByCustomerSearch(string searchTerm)
        {
            return _db.Bookings.Where(x => x.Customer.Name.Contains(searchTerm)).ToList();
        }

        public static Booking GetBookingByID(int id)
        {
            return _db.Bookings.SingleOrDefault(x => x.BookingID == id);
        }

        public static void UpdateBooking(Booking newBooking)
        {
            Booking oldBooking = GetBookingByID(newBooking.BookingID);
            _db.Entry(oldBooking).CurrentValues.SetValues(newBooking);
            _db.SaveChanges();
        }

        public static void DeleteBooking(Booking booking)
        {
            _db.Invoices.Remove(booking.Invoice);
            _db.Bookings.Remove(booking);
            _db.SaveChanges();
        }
    }
}
