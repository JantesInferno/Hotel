using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Repository
{
    public class InvoiceRepo
    {
        private static readonly DataHandler _db;

        static InvoiceRepo()
        {
            _db = new DataHandler();
        }

        public static int CreateInvoice(Invoice invoice)
        {
            _db.Invoices.Add(invoice);
            _db.SaveChanges();

            return invoice.InvoiceID;
        }

        public static List<Invoice> GetAllInvoices()
        {
            return _db.Invoices.ToList();
        }
        /*

        public static Invoice GetInvoiceByInvoiceID(int invoiceID)
        {
            return _db.Invoices.Find(invoiceID);
        }

        public static Invoice GetInvoiceByBookingID(int bookingID)
        {
            return _db.Invoices.Include("Bookings").SingleOrDefault(x => x.Bookings.== bookingID);
        }

        public static List<Invoice> GetInvoiceByCustomerID(int customerID)
        {
            return _db.Invoices.Where(x => x.Booking.CustomerID == customerID).ToList();
        }*/

        public static void UpdateInvoice(Invoice newInvoice) 
        {
            Invoice oldInvoice = _db.Invoices.Find(newInvoice.InvoiceID);
            _db.Entry(oldInvoice).CurrentValues.SetValues(newInvoice);
            _db.SaveChanges();
        }

        public static void DeleteInvoice(Invoice invoice)
        {
            _db.Invoices.Remove(invoice);
            _db.SaveChanges();
        }
    }
}
