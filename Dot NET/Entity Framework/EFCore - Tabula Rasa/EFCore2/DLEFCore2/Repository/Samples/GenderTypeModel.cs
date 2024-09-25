using System.ComponentModel.DataAnnotations;
using DLEFCore2.Context;
using DLEFCore2.Repository.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DLEFCore2.Repository.Samples {
    public interface IGenderTypeRepository : IRepository<GenderTypeModel> {
    }
    public class GenderTypeRepository(DLEFCoreContext context) : BaseRepository<GenderTypeModel>(context), IGenderTypeRepository {
    }

    public class GenderTypeMap : IEntityTypeConfiguration<GenderTypeModel> {
        public void Configure(EntityTypeBuilder<GenderTypeModel> builder) {
            builder.Property(m => m.OrderBy).HasDefaultValueSql("-1");
            builder.Property(m => m.IsDefault).HasDefaultValue(false);
            builder.Property(m => m.Disabled).HasDefaultValue(false);
        }
    }

    [EntityTypeConfiguration(typeof(GenderTypeMap))]
    public class GenderTypeModel : BaseEntityModel {
        public int Id {
            get; set;
        }
        [MaxLength(255)]
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