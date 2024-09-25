using DLEFCore.Context;
using DLEFCore.Repository;
using DLEFCore.UnitOfWork.Base;

namespace DLEFCore.UnitOfWork {
    public class UnitOfWork : IUnitOfWork {
        public DLContext DLContext {
            get;
        }

        public UnitOfWork(DLContext context) {
            DLContext = context;

            Names = new NameRepository(context);
            NameIds = new NameIdRepository(context);
        }

        public INameRepository Names {
            get;
        }
        public INameIdRepository NameIds {
            get;
        }

        public int Complete() {
            return DLContext.SaveChanges();
        }

        public void Dispose() {
            DLContext.Dispose();
        }
    }
}