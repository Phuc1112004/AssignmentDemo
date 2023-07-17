using AssignmentDemo.Data;
using AssignmentDemo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDemo.Repository
{
    // Generic: chung chung, co the dung cho bat ky class nao (Customer, Membership, v.v.)
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly DataContext _context; // readonly: bat buoc phai khoi tao trong contructor, khong the thay doi gia tri cua bien trong phuong thức khac
        private readonly DbSet<T> _table;
        public GenericRepository(DataContext context)
        {
            _context = context;
            _table = _context.Set<T>(); // lay bang ma minh can (vd: bang Customers, Memberships, v.v)
        }
        public void Add(T entity) // T: customer(vd: Id = 1, Name = "Phuc")
        {
            _table.Add(entity);
      
        }

        public void Delete(int id)
        {
            // var: tra ve null khi khong tim thay
            var result = _table.Find(id); // Tim khach hang co Id = 15 se khong tim thay va bi null
            _table.Remove(result);
          
        }

        public List<T> GetAll(List<string> includes = null) // vd: o bang Orders, tham so includes bao gom thong tin khach hang (ten, phone, email, v.v) 
        {
            IQueryable<T> query = _table; // la bang Orders
            if (includes is not null) // includes null nghia la minh chi can xem Id cua khach hang (khong can ten, phone, email)
            {
                foreach (var includedProperty in includes) // { "Customer" }
                {
                    query = query.Include(includedProperty);
                }
            }
            return query.AsNoTracking().ToList(); // AsNoTracking: Khong tu y thay doi thong tin tra ve
        }

        public T GetById(int id)
        {
            var result = _table.Find(id);
            //if (result is null) { return null; }
            //else { return result; }
            return result;
        }

        public void Update(int id, T entity)
        {
            // Tim ra khach hang co ID can update
            var result = _table.Find(id);

            // Thay the thong tin cu bang thong tin moi
            // CurrentValues: thong tin cu
            /// SetValues: thong tin moi
            _context.Entry(result).CurrentValues.SetValues(entity);
        }
    }
}
