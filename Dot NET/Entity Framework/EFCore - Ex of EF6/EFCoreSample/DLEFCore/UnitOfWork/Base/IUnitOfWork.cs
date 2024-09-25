using DLEFCore.Repository;

namespace DLEFCore.UnitOfWork.Base {
    public interface IUnitOfWork : IDisposable {
        INameRepository Names {
            get;
        }
        INameIdRepository NameIds {
            get;
        }

        int Complete();
    }
}