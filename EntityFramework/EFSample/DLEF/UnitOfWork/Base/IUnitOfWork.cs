using DLEF.Handlers;
using System;

namespace DLEF.UnitOfWork.Base {
    public interface IUnitOfWork : IDisposable {
        IAuthorRepository Authors { get; }
        IDepartmentTypeRepository Departments { get; }
        IGroupRepository Groups { get; }
        IUserRepository Users { get; }

        int Complete();
    }
}