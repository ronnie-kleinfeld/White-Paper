using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DLEFCore.Repository.Base {
    internal class BaseMap<T> : IEntityTypeConfiguration<T> where T : BaseModel {
        private string TableName {
            get;
        }

        internal BaseMap(string tableName) {
            TableName = tableName;
        }

        public void Configure(EntityTypeBuilder<T> builder) {
            builder.ToTable(TableName).HasNoKey();

            builder.Property(m => m.CreatedDateTime)
                .HasColumnName("CreatedDateTime")
                .HasColumnType("DateTime")
                .IsRequired();
        }
    }

    public class BaseModel {
        public DateTime CreatedDateTime {
            get;
        } = DateTime.Now;
    }
}