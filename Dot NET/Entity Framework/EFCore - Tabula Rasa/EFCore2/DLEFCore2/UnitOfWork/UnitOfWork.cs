using DLEFCore2.Context;
using DLEFCore2.Repository.Samples;
using DLEFCore2.UnitOfWork.Base;

namespace DLEFCore2.UnitOfWork {
    public class UnitOfWork : IUnitOfWork {
        public DLEFCoreContext Context {
            get;
        }

        public UnitOfWork(DLEFCoreContext context) {
            Context = context;
        }

        public IDataTypesRepository DataTypesRepository {
            get;
        }
        public IEntityIdRepository EntityId {
            get;
        }
        public IEntityNoIdRepository EntityNoId {
            get;
        }
        public IGenderTypeRepository GenderType {
            get;
        }

        public IUserRepository User => throw new NotImplementedException();

        public int Complete() {
            return Context.SaveChanges();
        }

        public void Dispose() {
            Context.Dispose();
        }
    }
}