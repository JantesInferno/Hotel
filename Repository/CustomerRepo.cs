using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;

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
            try
            {
                _db.Customers.Add(customer);
                _db.SaveChanges();
            }
            catch (SqlException ex)
            {
                // Unique constraint violation
                if (ex.Number == 2627)
                {
                    throw ex;
                }
            }
        }

        public static List<Customer> GetAllCustomers()
        {
            return _db.Customers.ToList();
        }

        public static List<string> GetAllCustomersAutoComplete()
        {
            List<string> customers = _db.Customers.Select(x => x.Name).ToList();
            return customers;
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

        public static bool DeleteCustomer(Customer customer)
        {
            if (customer.Bookings != null)
                return false;

            _db.Customers.Remove(customer);
            _db.SaveChanges();

            return true;
        }
    }
}
