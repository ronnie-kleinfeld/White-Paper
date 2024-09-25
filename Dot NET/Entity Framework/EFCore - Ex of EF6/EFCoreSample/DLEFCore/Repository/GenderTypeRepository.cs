using DLEFCore.Context;
using DLEFCore.Repository.Base;
using DLEFCore.Repository.Base.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DLEFCore.Repository {
    public interface IGenderTypeRepository : IRepository<GenderTypeModel> {
    }
    public class GenderTypeRepository(DLContext context) : Repository<GenderTypeModel>(context), IGenderTypeRepository {
    }

    internal class GenderTypeMap() : BaseTypeMap<GenderTypeModel>("GenderType") {
        public new void Configure(EntityTypeBuilder<GenderTypeModel> builder) {
            base.Configure(builder);
        }
    }

    [EntityTypeConfiguration(typeof(GenderTypeMap))]
    public class GenderTypeModel : BaseTypeModel {
        public GenderTypeEnum GenderType {
            get {
                return (GenderTypeEnum)Id;
            }
        }
    }

    public enum GenderTypeEnum {
        Male,
        Female,
        Other
    }
}