using DLEF.Handlers.Base.Data;
using System.Data.Entity.ModelConfiguration;

namespace DLEF.Handlers.Base.Map {
    internal class BaseMap<T> : EntityTypeConfiguration<T> where T : BaseData {
        public BaseMap(string tableName) {
            ToTable(tableName);
        }
    }
}