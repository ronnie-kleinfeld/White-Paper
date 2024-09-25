using DLEFCore.Context;
using DLEFCore.Repository.Base;
using DLEFCore.Repository.Base.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DLEFCore.Repository {
    public interface IAuthorRepository : IRepository<AuthorModel> {
    }

    public class _AuthorRepository(DLContext context) : Repository<AuthorModel>(context), IAuthorRepository {
    }

    internal class AuthorMap() : BaseMap<AuthorModel>("Authors") {
        public new void Configure(EntityTypeBuilder<AuthorModel> builder) {
            base.Configure(builder);

            builder.Property(m => m.Name).IsRequired().HasMaxLength(255);
        }
    }

    [EntityTypeConfiguration(typeof(AuthorMap))]
    //[Table("Authors")]
    public class AuthorModel : BaseIdModel {
        //[Required]
        //[MaxLength(255)]
        public string Name {
            get; set;
        }
    }
}