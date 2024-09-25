using DLEFCore.Context;
using DLEFCore.Repository.Base;
using DLEFCore.Repository.Base.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DLEFCore.Repository {
    public interface INameIdRepository : IRepository<NameIdModel> {
    }
    public class NameIdRepository(DLContext context) : Repository<NameIdModel>(context), INameIdRepository {
    }

    internal class NameIdMap() : BaseIdMap<NameIdModel>("NamesId") {
        public new void Configure(EntityTypeBuilder<NameIdModel> builder) {
            base.Configure(builder);

            builder.Property(m => m.NameId).IsRequired().HasMaxLength(255);
        }
    }

    [EntityTypeConfiguration(typeof(NameIdMap))]
    public class NameIdModel : BaseIdModel {
        public string NameId {
            get; set;
        }
    }
}