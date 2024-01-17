using EFCoreDL.DL.Context;
using EFCoreDL.DL.Model.Base;
using System.Linq.Expressions;

namespace EFCoreDL.BL.Repository.Base {
    public abstract class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : BaseModel {
        protected readonly DLContext Context;

        public DLContext DLContext {
            get { return Context as DLContext; }
        }

        public BaseRepository(DLContext context) {
            Context = context;
        }

        public TEntity Get(int id) {
            // Here we are working with a DbContext, not PlutoContext. So we don't have DbSets 
            // such as Courses or Authors, and we need to use the generic Set() method to access them.
            return Context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll() {
            // Note that here I've repeated Context.Set<TEntity>() in every method and this is causing
            // too much noise. I could get a reference to the DbSet returned from this method in the 
            // constructor and store it in a private field like _entities. This way, the implementation
            // of our methods would be cleaner:
            // 
            // _entities.ToList();
            // _entities.Where();
            // _entities.SingleOrDefault();
            // 
            // I didn't change it because I wanted the code to look like the videos. But feel free to change
            // this on your own.
            return Context.Set<TEntity>().ToList();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate) {
            return Context.Set<TEntity>().Where(predicate);
        }

        public TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate) {
            return Context.Set<TEntity>().SingleOrDefault(predicate);
        }

        public void Add(TEntity entity) {
            entity.CreatedDateTime = DateTime.Now;
            Context.Set<TEntity>().Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities) {
            foreach (TEntity tEntity in entities) {
                tEntity.CreatedDateTime = DateTime.Now;
            }
            Context.Set<TEntity>().AddRange(entities);
        }

        public void Remove(TEntity entity) {
            Context.Set<TEntity>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities) {
            Context.Set<TEntity>().RemoveRange(entities);
        }
    }
}