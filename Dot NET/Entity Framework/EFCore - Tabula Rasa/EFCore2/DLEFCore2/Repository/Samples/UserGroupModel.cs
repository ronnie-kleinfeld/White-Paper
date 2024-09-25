using DLEFCore2.Repository.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Emit;

namespace DLEFCore2.Repository.Samples {
    public class UserGroupMap : IEntityTypeConfiguration<UserGroupModel> {
        public void Configure(EntityTypeBuilder<UserGroupModel> builder) {
            builder
                .HasKey(ug => new { ug.UserId, ug.GroupId });

            builder
                .HasOne(ug => ug.User)
                .WithMany(ug => ug.UserGroups)
                .HasForeignKey(ug => ug.UserId);

            builder
                .HasOne(ug => ug.Group)
                .WithMany(ug => ug.GroupUsers)
                .HasForeignKey(ug => ug.GroupId);
        }
    }

    public class UserGroupModel : BaseEntityModel {
        [Key]
        public int Id {
            get; set;
        }

        public int UserId {
            get; set;
        }
        public UserModel User {
            get; set;
        }

        public int GroupId {
            get; set;
        }
        public GroupModel Group {
            get; set;
        }
    }
}