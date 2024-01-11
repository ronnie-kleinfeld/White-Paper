using DLEF.Handlers.Base.Data;

namespace DLEF.Handlers.Base.Map {
    internal class BaseIDMap<T> : BaseMap<T> where T : BaseIDData {
        public BaseIDMap(string tableName) : base(tableName) {
            HasKey(t => t.ID);

            Property(t => t.CreatedDateTime)
                .HasColumnName("CreatedDateTime")
                .HasColumnType("DateTime")
                .IsRequired();
        }
    }
}