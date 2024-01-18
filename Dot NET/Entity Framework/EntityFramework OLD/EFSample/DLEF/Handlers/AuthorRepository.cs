using DLEF.Context;
using DLEF.Handlers.Base.Data;
using DLEF.Handlers.Base.Map;
using DLEF.Handlers.Base.Repository;
using System.ComponentModel.DataAnnotations.Schema;

namespace DLEF.Handlers {
    public interface IAuthorRepository : IRepository<AuthorData> {
    }
    public class AuthorRepository : Repository<AuthorData>, IAuthorRepository {
        public AuthorRepository(DLContext context) : base(context) {
        }
    }

    internal class AuthorIDMap : BaseIDMap<AuthorData> {
        public AuthorIDMap() : base("Authors") {
            Property(v => v.Name)
                 .IsRequired()
                 .HasMaxLength(255);
        }
    }

    public class AuthorData : BaseIDData {
        public string Name { get; set; }
    }
}