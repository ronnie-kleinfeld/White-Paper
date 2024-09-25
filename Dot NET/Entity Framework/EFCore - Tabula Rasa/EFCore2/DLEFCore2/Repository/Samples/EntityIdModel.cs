using DLEFCore2.Context;
using DLEFCore2.Repository.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DLEFCore2.Repository.Samples {
    public interface IEntityIdRepository : IRepository<EntityIdModel> {
    }
    public class EntityIdRepository(DLEFCoreContext context) : BaseRepository<EntityIdModel>(context), IEntityIdRepository {
    }

    public class EntityIdMap : IEntityTypeConfiguration<EntityIdModel> {
        public void Configure(EntityTypeBuilder<EntityIdModel> builder) {
            builder
                .Property(m => m.CreatedDateTime)
                .HasDefaultValueSql("GETDATE()");
        }
    }

    [EntityTypeConfiguration(typeof(EntityIdMap))]
    public class EntityIdModel : BaseEntityModel {
        public int Id {
            get; set;
        }

        public DateTime CreatedDateTime {
            get; set;
        }
    }
}