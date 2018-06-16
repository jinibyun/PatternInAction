using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BusinessObjects;

namespace DataObjects
{
    /// <summary>
    /// Defines methods to access customers.
    /// </summary>
    /// <remarks>
    /// This is a database-independent interface. Implementations are database specific.
    /// </remarks>
    public interface ICustomerDao
    {
        /// <summary>
        /// Gets a specific customer.
        /// </summary>
        /// <param name="customerId">Unique customer identifier.</param>
        /// <returns>Customer.</returns>
        Customer GetCustomer(int customerId);

        /// <summary>
        /// Gets a sorted list of all customers.
        /// </summary>
        /// <param name="sortExpression">Sort order.</param>
        /// <returns>Sorted list of customers.</returns>
        List<Customer> GetCustomers(string sortExpression = "CustomerId ASC");
        
        /// <summary>
        /// Gets customer given an order.
        /// </summary>
        /// <param name="orderId">Unique order identifier.</param>
        /// <returns>Customer.</returns>
        Customer GetCustomerByOrder(int orderId);

        /// <summary>
        /// Gets customers with order statistics in given sort order.
        /// </summary>
        /// <param name="customers">Customer list.</param>
        /// <param name="sortExpression">Sort order.</param>
        /// <returns>Sorted list of customers with order statistics.</returns>
        List<Customer> GetCustomersWithOrderStatistics(string sortExpression);

        /// <summary>
        /// Inserts a new customer. 
        /// </summary>
        /// <remarks>
        /// Following insert, customer object will contain the new identifier.
        /// </remarks>
        /// <param name="customer">Customer.</param>
        void InsertCustomer(Customer customer);

        /// <summary>
        /// Updates a customer.
        /// </summary>
        /// <param name="customer">Customer.</param>
        void UpdateCustomer(Customer customer);

        /// <summary>
        /// Deletes a customer
        /// </summary>
        /// <param name="customer">Customer.</param>
        void DeleteCustomer(Customer customer);
    }
}
