using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DLEFCore.Repository.Base {
    internal class BaseIdMap<T>(string tableName) : BaseMap<T>(tableName) where T : BaseIdModel {
        public void Configure(EntityTypeBuilder<T> builder) {
            base.Configure(builder);

            builder.HasKey(x => x.Id);
            builder.Property(m => m.Id).UseIdentityColumn();
        }
    }

    public class BaseIdModel : BaseModel {
        public int Id {
            get; set;
        }
    }
}