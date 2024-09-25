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

        public IEntityIdRepository EntitesId {
            get;
        }
        public IEntityNoIdRepository EntitesNoId {
            get;
        }
        public IGenderTypeRepository GenderType {
            get;
        }

        public int Complete() {
            return Context.SaveChanges();
        }

        public void Dispose() {
            Context.Dispose();
        }
    }
}