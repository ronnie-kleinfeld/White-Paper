using DLEFCore2.Context;
using DLEFCore2.Repository.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;

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

            builder.HasData(
                new GenderTypeModel {
                    Id = 1,
                    Name = "Male",
                    Description = "Male",
                    OrderBy = 1,
                    IsDefault = true
                },
                new GenderTypeModel {
                    Id = 2,
                    Name = "Female",
                    Description = "Female",
                    OrderBy = 2
                },
                new GenderTypeModel {
                    Id = 3,
                    Name = "Other",
                    Description = "Other",
                    OrderBy = 3
                });
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

    public enum GenderTypeEnum {
        Male = 1,
        Female = 2,
        Other = 3
    }
}