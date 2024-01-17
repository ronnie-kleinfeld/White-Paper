using EFCoreDL.BL.Repository;

namespace EFCoreDL.BL.UnitOfWork {
    internal interface IUnitOfWork : IDisposable {
        IUserRepository Users { get; }

        int Complete();
    }
}