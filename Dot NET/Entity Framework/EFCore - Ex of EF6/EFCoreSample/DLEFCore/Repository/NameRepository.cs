using DLEFCore.Context;
using DLEFCore.Repository.Base;
using DLEFCore.Repository.Base.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DLEFCore.Repository {
    public interface INameRepository : IRepository<NameModel> {
    }
    public class NameRepository(DLContext context) : Repository<NameModel>(context), INameRepository {
    }

    internal class NameMap() : BaseMap<NameModel>("Name") {
        public new void Configure(EntityTypeBuilder<NameModel> builder) {
            base.Configure(builder);

            builder.Property(m => m.Name).IsRequired().HasMaxLength(255);
        }
    }

    [EntityTypeConfiguration(typeof(NameMap))]
    //[Table("Name")]
    public class NameModel : BaseModel {
        //[Required]
        //[MaxLength(255)]
        public string Name {
            get; set;
        }
    }
}