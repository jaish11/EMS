using EMS.Domain.Entities;
using EMS.Domain.Interfaces;

namespace EMS.Infrastructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ApplicationDbContext _context;

        public CustomerRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Add(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var customer = _context.Customers.FirstOrDefault(x => x.Id == id);
            _context.Customers.Remove(customer);
            _context.SaveChanges();
        }

        public IEnumerable<Customer> GetAll()
        {
            return _context.Customers.ToList();
        }

        public Customer GetById(int id)
        {
            return _context.Customers.Find(id);
        }

        public void Update(Customer customer)
        {
            _context.Customers.Update(customer);
            _context.SaveChanges();
        }
    }
}
