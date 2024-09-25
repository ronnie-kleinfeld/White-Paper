using DLEFCore2.Context;
using DLEFCore2.Repository.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;

namespace DLEFCore2.Repository.Samples {
    public interface IGroupRepository : IRepository<GroupModel> {
    }
    public class GroupRepository(DLEFCoreContext context) : BaseRepository<GroupModel>(context), IGroupRepository {
    }

    public class GroupMap : IEntityTypeConfiguration<GroupModel> {
        public void Configure(EntityTypeBuilder<GroupModel> builder) {
            builder
                .Property(m => m.CreatedDateTime)
                .HasDefaultValueSql("GETDATE()");
        }
    }

    [EntityTypeConfiguration(typeof(GroupMap))]
    public class GroupModel : BaseEntityModel {
        public int Id {
            get; set;
        }

        public DateTime CreatedDateTime {
            get; set;
        }

        [MaxLength(100)]
        public string GroupName {
            get; set;
        }

        public List<UserGroupModel> GroupUsers {
            get;
        }
    }
}