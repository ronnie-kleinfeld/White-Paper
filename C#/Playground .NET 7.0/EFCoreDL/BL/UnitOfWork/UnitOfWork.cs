using EFCoreDL.BL.Repository;
using EFCoreDL.DL.Context;

namespace EFCoreDL.BL.UnitOfWork {
    internal class UnitOfWork : IUnitOfWork {
        private readonly DLContext _context;

        public UnitOfWork(DLContext context) {
            _context = context;
            Departments = new DepartmentTypeRepository(_context);
            Users = new UserRepository(_context);
        }

        public IDepartmentTypeRepository Departments { get; }
        public IUserRepository Users { get; }

        public int Complete() {
            return _context.SaveChanges();
        }

        public void Dispose() {
            _context.Dispose();
        }
    }
}