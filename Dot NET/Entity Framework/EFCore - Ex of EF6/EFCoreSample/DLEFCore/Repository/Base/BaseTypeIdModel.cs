using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DLEFCore.Repository.Base {
    internal class BaseTypeMap<T>(string tableName) : BaseMap<T>(tableName) where T : BaseTypeModel {
        public void Configure(EntityTypeBuilder<T> builder) {
            base.Configure(builder);

            builder.Property(m => m.Id).IsUnicode();
            builder.Property(v => v.Name).IsRequired().HasMaxLength(255);
            builder.Property(v => v.Description).IsRequired().HasMaxLength(255);
            builder.Property(v => v.OrderBy).HasColumnType("Int");
            builder.Property(v => v.IsDefault).HasColumnType("Bit");
            builder.Property(v => v.Disabled).HasColumnType("Bit");
        }
    }

    public class BaseTypeModel : BaseModel {
        public int Id {
            get; set;
        }
        public string Name {
            get; set;
        }
        public string Description {
            get; set;
        }
        public int OrderBy {
            get; set;
        }
        public bool IsDefault {
            get; set;
        }
        public bool Disabled {
            get; set;
        }
    }
}