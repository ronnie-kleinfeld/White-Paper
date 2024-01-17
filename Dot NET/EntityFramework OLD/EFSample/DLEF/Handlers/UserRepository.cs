using DLEF.Context;
using DLEF.Handlers.Base.Data;
using DLEF.Handlers.Base.Map;
using DLEF.Handlers.Base.Repository;
using System.Collections.Generic;
using System.Linq;

namespace DLEF.Handlers {
    public interface IUserRepository : IRepository<UserData> {
        UserData GetUserByID(int ID);
    }
    public class UserRepository : Repository<UserData>, IUserRepository {
        public UserRepository(DLContext context) : base(context) {
        }

        public UserData GetUserByID(int ID) {
            return DLContext.Users.FirstOrDefault(x => x.ID == ID);
        }
    }

    internal class UserIDMap : BaseIDMap<UserData> {
        public UserIDMap() : base("Users") {
            Property(v => v.UserName).IsRequired().HasMaxLength(255);
            Property(v => v.FirstName).HasMaxLength(255);
            Property(v => v.LastName).HasMaxLength(255);

            HasRequired(u => u.DepartmentType)
                .WithMany(d => d.Users)
                .HasForeignKey(u => u.DepartmentID)
                .WillCascadeOnDelete(false);

            HasMany(u => u.Groups)
                .WithMany(g => g.Users)
                .Map(m => {
                    m.ToTable("UsersGroups");
                    m.MapLeftKey("UserID");
                    m.MapRightKey("GroupID");
                });
        }
    }

    public class UserData : BaseIDData {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DepartmentTypeData DepartmentType { get; set; }
        // set as virtual to get Lazy Loading
        public virtual int DepartmentID { get; set; }
        public ICollection<GroupData> Groups { get; private set; }

        public UserData() {
            Groups = new HashSet<GroupData>();
        }
    }
}