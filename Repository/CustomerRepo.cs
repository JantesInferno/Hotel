using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Repository
{
    public static class CustomerRepo
    {
        private static readonly DataHandler _db;

        static CustomerRepo()
        {
            _db = new DataHandler();
        }

        public static void CreateCustomer(Customer customer)
        {
            _db.Customers.Add(customer);
            _db.SaveChanges();
        }

        public static List<Customer> GetAllCustomers()
        {
            return _db.Customers.ToList();
        }

        public static Customer GetCustomerById(int id)
        {
            return _db.Customers.Find(id);
        }

        public static List<Customer> GetCustomersBySearch(string searchTerm) 
        { 
            return _db.Customers.Where(x => x.Name.Contains(searchTerm)).ToList();
        }

        public static List<Booking> GetCustomersBookingsBySearch(string searchTerm)
        {

            return BookingRepo.GetBookingsByCustomerSearch(searchTerm);
        }

        public static void UpdateCustomer(Customer newCustomer)
        {
            Customer oldCustomer = GetCustomerById(newCustomer.CustomerID);
            _db.Entry(oldCustomer).CurrentValues.SetValues(newCustomer);
            _db.SaveChanges();
        }

        public static void DeleteCustomer(Customer customer)
        {
            // if no bookings
            _db.Customers.Remove(customer);
            _db.SaveChanges();
        }
    }
}
