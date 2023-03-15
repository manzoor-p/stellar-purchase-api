using Contracts;
using Entities;
using Entities.DTO;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
    {
        public CustomerRepository(RepositoryContext repositoryContext)
            : base(repositoryContext) { }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return GetAll()
                .OrderBy(o => o.Name)
                .ToList();
        }

        public Customer GetCustomerById(Guid customerId) {
            return FindByCondition(customer => customer.IdCustomer.Equals(customerId))
                .FirstOrDefault();
        }

        public Customer GetCustomerWithDetails(Guid customerId)
        {
            return FindByCondition(customer => customer.IdCustomer.Equals(customerId))
                .Include(purchase => purchase.Purchases)
                .FirstOrDefault();            
        }
        public void CreateCustomer(Customer customer) {
            Create(customer);
        }
        public void UpdateCustomer(Customer customer)
        {
            Update(customer);
        }

        public void DeleteCustomer(Customer customer)
        {
            Delete(customer);
        }

        public List<CustomerPurchasePointsDTO> GetAllCustomersPurchases(DateTime startDate, DateTime endDate) {            
            List<Customer> allCustomerPurchases = GetAll() //gets all customers from customer table.
                .Include(c => c.Purchases) //eager loading of related purchases and to avoid an additional database round trip.
                .Where(c => //Filtering the customers who has the purchase entries that fall under the specified date range.
                         c.Purchases.Any(p => p.PurchaseDate >= startDate && p.PurchaseDate <= endDate) == true)
                .Select(c => new Customer
                { 
                    Name = c.Name,
                    Email = c.Email,
                    //Considering the only purchases that has been done during the specified date range.
                    Purchases = (List<Purchase>) c.Purchases.Where(p=> p.PurchaseDate >= startDate && p.PurchaseDate <= endDate)
                })
                .ToList();

            List<CustomerPurchasePointsDTO> allCustomersPoints = allCustomerPurchases
                .Select(c => new CustomerPurchasePointsDTO
                {
                    CustomerName = c.Name,
                    Email = c.Email,
                    MonthlyPoints = (IEnumerable<MonthlyPointsDto>)c.Purchases
                        //this will group the purchases based on the month of purchase.
                        //this is not restricted to only 3months, based on the start and end date it will group into the no of months.
                        .GroupBy(p => new { p.PurchaseDate.Year, p.PurchaseDate.Month })
                        .Select(g => new MonthlyPointsDto { // MonthlyPointsDto is a Data transfer object created so that the actual data can be transformed to the required format.
                            Year = g.Key.Year,
                            Month = g.Key.Month,
                            //sending the total amount to CalculatePurchasePoints method to get the sum of points calculated on each purchase amount.
                            MonthlySum = g.Sum(p => CalculatePurchasePoints(p.TotalAmount))
                        }),
                    TotalPoints = c.Purchases.Sum(p => CalculatePurchasePoints(p.TotalAmount))
                }
                ).ToList();
            return allCustomersPoints;
        }

        //Method to calculate the purchase points based on the purchase amount.
        public int CalculatePurchasePoints(decimal totalAmount)
        {
            int points = 0;

            //Math.Floor has been used to convert to the nearest lower number
            //Becuase we want to add a point for each dollar spent over 50 and 100.
            int purchaseAmount = (int)Math.Floor(totalAmount);
            if (purchaseAmount <= 50)
            {
                return points;
            }
            if (purchaseAmount > 50 && purchaseAmount <= 100)
            {
                return points = purchaseAmount - 50;
            }
            else
            {
                return points = purchaseAmount - 50 + purchaseAmount - 100;
            }
        }
        }
    }
