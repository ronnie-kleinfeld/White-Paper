using DLEFCore2.Repository.Samples;

namespace DLEFCore2.UnitOfWork.Base {
    public interface IUnitOfWork : IDisposable {
        IDataTypesRepository DataTypesRepository {
            get;
        }
        IEntityIdRepository EntityId {
            get;
        }
        IEntityNoIdRepository EntityNoId {
            get;
        }
        IGenderTypeRepository GenderType {
            get;
        }
        IUserRepository User {
            get;
        }

        int Complete();
    }
}