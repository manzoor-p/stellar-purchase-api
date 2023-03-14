using AutoMapper;
using Contracts;
using Entities.DTO;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using PurchasePointCalcAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurchasePointCalcApi_tests
{
    public class CustomerControllerTest
    {
        private readonly Mock<ILoggerManager> _logger;
        private readonly Mock<IRepositoryWrapper> _repository;
        private readonly Mock<IMapper> _mapper;
        private readonly CustomerController _controller;
        private readonly List<Customer> customersList =
            new List<Customer>()
            {
                new Customer { IdCustomer = Guid.NewGuid(), Name = "Vinod", Email = "Vinod@hotmail.com" },
                new Customer { IdCustomer = Guid.NewGuid(), Name = "Preeti", Email = "Preeti@hotmail.com" }
            };
        public CustomerControllerTest()
        {
            _logger = new Mock<ILoggerManager>();
            _repository = new Mock<IRepositoryWrapper>();
            _mapper = new Mock<IMapper>();
            _controller = new CustomerController(_logger.Object, _repository.Object, _mapper.Object);
        }

        [Fact]
        public void GetAllCustomers_ReturnsOkResult_WithListOfCustomers()
        {
            // Arrange
            var customers = new List<Customer>()
            {
                new Customer { IdCustomer = Guid.NewGuid(), Name = "Vinod", Email = "Vinod@hotmail.com" },
                new Customer { IdCustomer = Guid.NewGuid(), Name = "Preeti", Email = "Preeti@hotmail.com" }
            };
            _repository.Setup(repo => repo.Customer.GetAllCustomers()).Returns(customers);
            
            var customerDtos = new List<CustomerDto>()
            {
                new CustomerDto { IdCustomer = customers[0].IdCustomer, Name = customers[0].Name, Email = customers[0].Email },
                new CustomerDto { IdCustomer = customers[1].IdCustomer, Name = customers[1].Name, Email = customers[1].Email }
            };
            _mapper.Setup(m => m.Map<IEnumerable<CustomerDto>>(customers)).Returns(customerDtos);

            // Act
            var result = _controller.GetAllCustomers();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var customersResult = Assert.IsType<List<CustomerDto>>(okResult.Value);
            Assert.Equal(customerDtos, customersResult);
        }
        [Fact]
        public void GetCustomerById_ReturnsOkResult_WithCustomer()
        {
            // Arrange
            var id = Guid.NewGuid();
            var customer = new Customer { IdCustomer = id, Name = "Vinod", Email = "Vinod@gmail.com" };
            _repository.Setup(repo => repo.Customer.GetCustomerById(id)).Returns(customer);
            _mapper.Setup(m => m.Map<CustomerDto>(customer)).Returns(new CustomerDto());

            // Act
            var result = _controller.GetCustomerById(id);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var customerResult = Assert.IsType<CustomerDto>(okResult.Value);
            Assert.NotNull(customerResult);
        }
        [Fact]
        public void GetCustomerById_ReturnsNotFoundResult_WhenCustomerNotFound()
        {
            // Arrange
            var id = Guid.NewGuid();
            _repository.Setup(repo => repo.Customer.GetCustomerById(id)).Returns((Customer)null);

            // Act
            var result = _controller.GetCustomerById(id);

            // Assert
            Assert.IsType<NotFoundResult>(result);
        }
    }

}
