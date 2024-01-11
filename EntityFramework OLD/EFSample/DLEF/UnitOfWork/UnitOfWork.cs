using DLEF.Context;
using DLEF.Handlers;
using DLEF.UnitOfWork.Base;

namespace DLEF.UnitOfWork {
    public class UnitOfWork : IUnitOfWork {
        private readonly DLContext _context;

        public UnitOfWork(DLContext context) {
            _context = context;
            Authors = new AuthorRepository(_context);
            Departments = new DepartmentTypeRepository(_context);
            Groups = new GroupRepository(_context);
            Users = new UserRepository(_context);
        }

        public IAuthorRepository Authors { get; private set; }
        public IDepartmentTypeRepository Departments { get; }
        public IGroupRepository Groups { get; }
        public IUserRepository Users { get; }

        public int Complete() {
            return _context.SaveChanges();
        }

        public void Dispose() {
            _context.Dispose();
        }
    }
}