using AssignmentDemo.Models;
using AssignmentDemo.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDemo.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Customer> CustomerRepository { get; }
        IGenericRepository<Membership> MembershipRepository { get; }
        IGenericRepository<Order> OrderRepository { get; }
        IGenericRepository<Product> ProductRepository { get; }
        void Save();
    }
}
