using AutoMapper;
using Entities;
using Entities.DTO;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurchasePointCalcApi_tests
{
    public class CustomerRepository_tests
    {
        private readonly DbContextOptions<RepositoryContext> _options;
        private readonly IMapper _mapper;
        private readonly RepositoryContext _repositoryContext;
        private readonly CustomerRepository _customerRepository;
        private readonly List<Customer> customersData = new List<Customer>
        {
            new Customer
            {
                IdCustomer = Guid.NewGuid(),
                Name = "John",
                Email = "john@gmail.com",
                Purchases = new List<Purchase>
                {
                    new Purchase
                    {
                        IdPurchase = Guid.NewGuid(),
                        PurchaseDate = DateTime.Now,
                        TotalAmount = 100.0m,
                        Customer = null
                    },
                    new Purchase
                    {
                        IdPurchase = Guid.NewGuid(),
                        PurchaseDate = DateTime.Now.AddDays(-7),
                        TotalAmount = 50.0m,
                        Customer = null
                    }
                }
            },
            new Customer
            {
                IdCustomer = Guid.NewGuid(),
                Name = "Noor",
                Email = "Noor@gmail.com",
                Purchases = new List<Purchase>
                {
                    new Purchase
                    {
                        IdPurchase = Guid.NewGuid(),
                        PurchaseDate = DateTime.Now.AddDays(-14),
                        TotalAmount = 75.0m,
                        Customer = null
                    },
                    new Purchase
                    {
                        IdPurchase = Guid.NewGuid(),
                        PurchaseDate = DateTime.Now.AddDays(-21),
                        TotalAmount = 200.0m,
                        Customer = null
                    }
                }
            }
        };



        [Fact]
        public void GetAllCustomers_ReturnsAllCustomersInAscendingOrderOfTheirNames()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<RepositoryContext>()
                .UseInMemoryDatabase(databaseName: "GetAllCustomers_ReturnsAllCustomersInAscendingOrderOfTheirNames")
                .Options;

            var repositoryContext = new RepositoryContext(options);
            var customerRepository = new CustomerRepository(repositoryContext);

            var customers = customersData;

            foreach (var customer in customers)
            {
                customerRepository.CreateCustomer(customer);
            }

            repositoryContext.SaveChanges();

            // Act
            var result = customerRepository.GetAllCustomers();

            // Assert
            Assert.Equal("Noor", result.LastOrDefault()?.Name);
            
        }
        [Theory]
        [InlineData(25, 0)]
        [InlineData(50, 0)]
        [InlineData(60, 10)]
        [InlineData(100, 50)]
        [InlineData(150, 150)]
        public void CalculatePurchasePoints_ShouldReturnCorrectPoints(decimal totalAmount, int expectedPoints)
        {
            // Arrange
            var customerRepo = new CustomerRepository(null);

            // Act
            var result = customerRepo.CalculatePurchasePoints(totalAmount);

            // Assert
            Assert.Equal(expectedPoints, result);
        }

    }
}
