using DLEF.Handlers.Base.Data;

namespace DLEF.Handlers.Base.Map {
    internal class BaseTypeIDMap<T> : BaseIDMap<T> where T : BaseTypeIDData {
        public BaseTypeIDMap(string tableName) : base(tableName) {
            Property(v => v.Name).IsRequired().HasMaxLength(255);
            Property(v => v.Description).IsRequired().HasMaxLength(255);
            Property(v => v.OrderBy).HasColumnType("Int");
            Property(v => v.IsDefault).HasColumnType("Bit");
            Property(v => v.Disabled).HasColumnType("Bit");
        }
    }
}