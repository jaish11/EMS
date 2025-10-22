using EMS.Domain.DTOs;
using EMS.Domain.Entities;
using EMS.Domain.Interfaces;

namespace EMS.Application.Services
{
    public class CustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public IEnumerable<CustomerDTO> GetAllCustomers()
        {
            return _customerRepository.GetAll().Select(c => new CustomerDTO
            {
                Id = c.Id,
                Name = c.Name,
                Email = c.Email,
                Mobile = c.Mobile
            });
        }

        public CustomerDTO GetCustomerById(int id)
        {
            var c = _customerRepository.GetById(id);
            return new CustomerDTO {Id = c.Id, Name = c.Name, Email = c.Email, Mobile = c.Mobile };
        }

        public void AddCustomer(CustomerDTO dto)
        {
            //data mapping dto to entity
            var customer = new Customer { Name = dto.Name, Email = dto.Email, Mobile = dto.Mobile };
            _customerRepository.Add(customer);
        }

        public void UpdateCustomer(CustomerDTO dto)
        {
            Customer customer = new Customer();
            customer.Id = dto.Id;
            customer.Name = dto.Name;
            customer.Email = dto.Email;
            customer.Mobile = dto.Mobile;
            _customerRepository.Update(customer);
        }

        public void DeleteCustomer(int id)
        {
            _customerRepository.Delete(id);
        }
    }
}
