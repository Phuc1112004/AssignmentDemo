using AssignmentDemo.Data;
using AssignmentDemo.Models;
using AssignmentDemo.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDemo.UnitOfWork
{
    // Dam bao chuong trinh chi can 1 phien ket noi DB ma khong can phai dong/mo nhieu lan
    public class UnitOfWork : IUnitOfWork
    {
        // Fields
        private readonly DataContext _context = new DataContext();
        private IGenericRepository<Customer> _customerRepository;
        private IGenericRepository<Membership> _membershipRepository;
        private IGenericRepository<Order> _orderRepository;
        private IGenericRepository<Product> _productRepository;

        public IGenericRepository<Customer> CustomerRepository => _customerRepository ??= new GenericRepository<Customer>(_context);

        public IGenericRepository<Membership> MembershipRepository => _membershipRepository ??= new GenericRepository<Membership>(_context);

        public IGenericRepository<Order> OrderRepository => _orderRepository ??= new GenericRepository<Order>(_context);

        public IGenericRepository<Product> ProductRepository => _productRepository ??= new GenericRepository<Product>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
