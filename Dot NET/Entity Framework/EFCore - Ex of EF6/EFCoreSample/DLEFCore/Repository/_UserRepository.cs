using DLEFCore.Context;
using DLEFCore.Repository.Base;
using DLEFCore.Repository.Base.Map;
using DLEFCore.Repository.Base.Repository;

namespace DLEFCore.Repository {
    public interface IUserRepository : IRepository<UserModel> {
        UserModel GetUserByID(int ID);
    }
    public class _UserRepository : Repository<UserModel>, IUserRepository {
        public _UserRepository(DLContext context) : base(context) {
        }

        public UserModel GetUserByID(int ID) {
            return DLContext.Users.FirstOrDefault(x => x.Id == ID);
        }
    }

    internal class UserIdFluentApi : BaseIdMap<UserModel> {
        public UserIdFluentApi() : base("Users") {
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

    public class UserModel : BaseIdModel {
        public string UserName {
            get; set;
        }
        public string FirstName {
            get; set;
        }
        public string LastName {
            get; set;
        }
        public DepartmentTypeModel DepartmentType {
            get; set;
        }
        // set as virtual to get Lazy Loading
        public virtual int DepartmentID {
            get; set;
        }
        public ICollection<GroupModel> Groups {
            get; private set;
        }

        public UserModel() {
            Groups = new HashSet<GroupModel>();
        }
    }
}