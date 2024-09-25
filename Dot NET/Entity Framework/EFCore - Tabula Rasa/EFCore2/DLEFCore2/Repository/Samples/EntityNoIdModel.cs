using DLEFCore2.Context;
using DLEFCore2.Repository.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DLEFCore2.Repository.Samples {
    public interface IEntityNoIdRepository : IRepository<EntityNoIdModel> {
    }
    public class EntityNoIdRepository(DLEFCoreContext context) : BaseRepository<EntityNoIdModel>(context), IEntityNoIdRepository {
    }

    public class EntityNoIdMap : IEntityTypeConfiguration<EntityNoIdModel> {
        public void Configure(EntityTypeBuilder<EntityNoIdModel> builder) {
            builder
                .HasNoKey();

            builder
                .Property(m => m.CreatedDateTime)
                .HasDefaultValueSql("GETDATE()");
        }
    }

    [EntityTypeConfiguration(typeof(EntityNoIdMap))]
    public class EntityNoIdModel : BaseEntityModel {
        public DateTime CreatedDateTime {
            get; set;
        }
    }
}