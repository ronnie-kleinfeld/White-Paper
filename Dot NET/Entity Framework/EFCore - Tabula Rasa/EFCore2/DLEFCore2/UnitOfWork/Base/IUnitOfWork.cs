using DLEFCore2.Repository.Samples;

namespace DLEFCore2.UnitOfWork.Base {
    public interface IUnitOfWork : IDisposable {
        IEntityIdRepository EntitesId {
            get;
        }
        IEntityNoIdRepository EntitesNoId {
            get;
        }

        int Complete();
    }
}